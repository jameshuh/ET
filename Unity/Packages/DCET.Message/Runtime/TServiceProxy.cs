using Microsoft.IO;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace DCETRuntime
{
	public sealed class TServiceProxy : IDisposable
	{		
		public RecyclableMemoryStreamManager MemoryStreamManager = new RecyclableMemoryStreamManager();		
		public List<long> needStartSendChannel = new List<long>();		
		public int PacketSizeLength { get; }
		public Action<Socket> OnAccept = null;

		private readonly SocketAsyncEventArgs innArgs = new SocketAsyncEventArgs();
		private Socket acceptor;

		/// <summary>
		/// 即可做client也可做server
		/// </summary>
		public TServiceProxy(int packetSizeLength, IPEndPoint ipEndPoint)
		{
			this.PacketSizeLength = packetSizeLength;
			
			this.acceptor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			this.acceptor.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
			this.innArgs.Completed += this.OnComplete;
			
			this.acceptor.Bind(ipEndPoint);
			this.acceptor.Listen(1000);

			this.AcceptAsync();
		}

		public TServiceProxy(int packetSizeLength)
		{
			this.PacketSizeLength = packetSizeLength;
		}
		
		public void Dispose()
		{
			this.acceptor?.Close();
			this.acceptor = null;
			this.innArgs.Dispose();
		}

		private void OnComplete(object sender, SocketAsyncEventArgs e)
		{
			switch (e.LastOperation)
			{
				case SocketAsyncOperation.Accept:
					OneThreadSynchronizationContext.Instance.Post(this.OnAcceptComplete, e);
					break;
				default:
					throw new Exception($"socket accept error: {e.LastOperation}");
			}
		}
		
		public void AcceptAsync()
		{
			this.innArgs.AcceptSocket = null;
			if (this.acceptor.AcceptAsync(this.innArgs))
			{
				return;
			}
			OnAcceptComplete(this.innArgs);
		}

		private void OnAcceptComplete(object o)
		{
			if (this.acceptor == null)
			{
				return;
			}
			SocketAsyncEventArgs e = (SocketAsyncEventArgs)o;
			
			if (e.SocketError != SocketError.Success)
			{
				Log.Error($"accept error {e.SocketError}");
				this.AcceptAsync();
				return;
			}
			
			try
			{
				this.OnAccept?.Invoke(e.AcceptSocket);
			}
			catch (Exception exception)
			{
				Log.Error(exception);
			}

			if (this.acceptor == null)
			{
				return;
			}
			
			this.AcceptAsync();
		}
		
		public void MarkNeedStartSend(long id)
		{
			this.needStartSendChannel.Add(id);
		}
	}
}