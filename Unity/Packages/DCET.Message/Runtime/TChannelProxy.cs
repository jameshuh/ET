using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace DCETRuntime
{
	public static class ErrorCode
	{
		public const int ERR_PeerDisconnect = 102008;
		public const int ERR_SocketError = 102010;
	}

	/// <summary>
	/// 封装Socket,将回调push到主线程处理
	/// </summary>
	public sealed class TChannelProxy : IDisposable
	{
		public Action<int> OnError;
		public Action OnStartRecv;
		public Action<MemoryStream> OnRead;
		public string RemoteAddress { get; }
		public MemoryStream Stream { get; }

		private SocketAsyncEventArgs innArgs = new SocketAsyncEventArgs();
		private SocketAsyncEventArgs outArgs = new SocketAsyncEventArgs();

		private readonly CircularBuffer recvBuffer = new CircularBuffer();
		private readonly CircularBuffer sendBuffer = new CircularBuffer();

		private Socket socket;
		private bool isConnected;
		private TServiceProxy service;
		private readonly PacketParser parser;
		private readonly byte[] packetSizeCache;

		public TChannelProxy(IPEndPoint ipEndPoint, TServiceProxy service)
		{
			this.service = service;
			int packetSize = service.PacketSizeLength;
			this.packetSizeCache = new byte[packetSize];
			this.Stream = service.MemoryStreamManager.GetStream("message", ushort.MaxValue);
			
			this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			this.socket.NoDelay = true;
			this.parser = new PacketParser(packetSize, this.recvBuffer, this.Stream);
			this.innArgs.Completed += this.OnComplete;
			this.outArgs.Completed += this.OnComplete;

			this.RemoteAddress = ipEndPoint.ToString();
			this.isConnected = false;
			this.IsSending = false;
		}
		
		public TChannelProxy(Socket socket, TServiceProxy service)
		{
			this.service = service;
			int packetSize = service.PacketSizeLength;
			this.packetSizeCache = new byte[packetSize];
			this.Stream = service.MemoryStreamManager.GetStream("message", ushort.MaxValue);
			
			this.socket = socket;
			this.socket.NoDelay = true;
			this.parser = new PacketParser(packetSize, this.recvBuffer, this.Stream);
			this.innArgs.Completed += this.OnComplete;
			this.outArgs.Completed += this.OnComplete;

			this.RemoteAddress = socket.RemoteEndPoint.ToString();
			this.isConnected = true;
			this.IsSending = false;
		}

		public void Dispose()
		{
			this.socket.Close();
			this.innArgs.Dispose();
			this.outArgs.Dispose();
			this.innArgs = null;
			this.outArgs = null;
			this.socket = null;
			this.Stream.Dispose();
		}

		private TServiceProxy GetServiceProxy()
		{
			return this.service;
		}

		public void Send(MemoryStream stream)
		{
			switch (this.GetServiceProxy().PacketSizeLength)
			{
				case Packet.PacketSizeLength4:
					if (stream.Length > ushort.MaxValue * 16)
					{
						throw new Exception($"send packet too large: {stream.Length}");
					}
					this.packetSizeCache.WriteTo(0, (int) stream.Length);
					break;
				case Packet.PacketSizeLength2:
					if (stream.Length > ushort.MaxValue)
					{
						throw new Exception($"send packet too large: {stream.Length}");
					}
					this.packetSizeCache.WriteTo(0, (ushort) stream.Length);
					break;
				default:
					throw new Exception("packet size must be 2 or 4!");
			}

			this.sendBuffer.Write(this.packetSizeCache, 0, this.packetSizeCache.Length);
			this.sendBuffer.WriteStream(stream);
		}

		private void OnComplete(object sender, SocketAsyncEventArgs e)
		{
			switch (e.LastOperation)
			{
				case SocketAsyncOperation.Connect:
					OneThreadSynchronizationContext.Instance.Post(this.OnConnectComplete, e);
					break;
				case SocketAsyncOperation.Receive:
					OneThreadSynchronizationContext.Instance.Post(this.OnRecvComplete, e);
					break;
				case SocketAsyncOperation.Send:
					OneThreadSynchronizationContext.Instance.Post(this.OnSendComplete, e);
					break;
				case SocketAsyncOperation.Disconnect:
					OneThreadSynchronizationContext.Instance.Post(this.OnDisconnectComplete, e);
					break;
				default:
					throw new Exception($"socket error: {e.LastOperation}");
			}
		}

		public void ConnectAsync(IPEndPoint ipEndPoint)
		{
			this.outArgs.RemoteEndPoint = ipEndPoint;
			if (this.socket.ConnectAsync(this.outArgs))
			{
				return;
			}
			OnConnectComplete(this.outArgs);
		}

		private void OnConnectComplete(object o)
		{
			if (this.socket == null)
			{
				return;
			}
			SocketAsyncEventArgs e = (SocketAsyncEventArgs) o;
			
			if (e.SocketError != SocketError.Success)
			{
				this.OnError?.Invoke((int)e.SocketError);	
				return;
			}

			e.RemoteEndPoint = null;
			this.isConnected = true;
			this.StartRecv();

			this.OnStartRecv?.Invoke();
		}

		private void OnDisconnectComplete(object o)
		{
			SocketAsyncEventArgs e = (SocketAsyncEventArgs)o;
			this.OnError?.Invoke((int)e.SocketError);
		}

		public void StartRecv()
		{
			int size = this.recvBuffer.ChunkSize - this.recvBuffer.LastIndex;
			this.RecvAsync(this.recvBuffer.Last, this.recvBuffer.LastIndex, size);
		}

		public void RecvAsync(byte[] buffer, int offset, int count)
		{
			try
			{
				this.innArgs.SetBuffer(buffer, offset, count);
			}
			catch (Exception e)
			{
				throw new Exception($"socket set buffer error: {buffer.Length}, {offset}, {count}", e);
			}
			
			if (this.socket.ReceiveAsync(this.innArgs))
			{
				return;
			}
			OnRecvComplete(this.innArgs);
		}

		private void OnRecvComplete(object o)
		{
			if (this.socket == null)
			{
				return;
			}
			SocketAsyncEventArgs e = (SocketAsyncEventArgs) o;

			if (e.SocketError != SocketError.Success)
			{
				this.OnError?.Invoke((int)e.SocketError);
				return;
			}

			if (e.BytesTransferred == 0)
			{
				this.OnError?.Invoke(ErrorCode.ERR_PeerDisconnect);
				return;
			}

			this.recvBuffer.LastIndex += e.BytesTransferred;
			if (this.recvBuffer.LastIndex == this.recvBuffer.ChunkSize)
			{
				this.recvBuffer.AddLast();
				this.recvBuffer.LastIndex = 0;
			}

			// 收到消息回调
			while (true)
			{
				try
				{
					if (!this.parser.Parse())
					{
						break;
					}
				}
				catch (Exception exception)
				{
					Log.Error($"ip: {this.RemoteAddress} {exception}");
					this.OnError?.Invoke(ErrorCode.ERR_SocketError);
					return;
				}

				try
				{
					this.OnRead?.Invoke(this.parser.GetPacket());
				}
				catch (Exception ee)
				{
					Log.Exception(ee);
				}
			}

			if (this.socket == null)
			{
				return;
			}
			
			this.StartRecv();
		}

		public bool IsSending { get; private set; }

		public void StartSend()
		{
			if(!this.isConnected)
			{
				return;
			}
			
			// 没有数据需要发送
			if (this.sendBuffer.Length == 0)
			{
				this.IsSending = false;
				return;
			}

			this.IsSending = true;

			int sendSize = this.sendBuffer.ChunkSize - this.sendBuffer.FirstIndex;
			if (sendSize > this.sendBuffer.Length)
			{
				sendSize = (int)this.sendBuffer.Length;
			}

			this.SendAsync(this.sendBuffer.First, this.sendBuffer.FirstIndex, sendSize);
		}

		public void SendAsync(byte[] buffer, int offset, int count)
		{
			try
			{
				this.outArgs.SetBuffer(buffer, offset, count);
			}
			catch (Exception e)
			{
				throw new Exception($"socket set buffer error: {buffer.Length}, {offset}, {count}", e);
			}
			if (this.socket.SendAsync(this.outArgs))
			{
				return;
			}
			OnSendComplete(this.outArgs);
		}

		private void OnSendComplete(object o)
		{
			if (this.socket == null)
			{
				return;
			}
			SocketAsyncEventArgs e = (SocketAsyncEventArgs) o;

			if (e.SocketError != SocketError.Success)
			{
				this.OnError?.Invoke((int)e.SocketError);
				return;
			}
			
			if (e.BytesTransferred == 0)
			{
				this.OnError?.Invoke(ErrorCode.ERR_PeerDisconnect);
				return;
			}
			
			this.sendBuffer.FirstIndex += e.BytesTransferred;
			if (this.sendBuffer.FirstIndex == this.sendBuffer.ChunkSize)
			{
				this.sendBuffer.FirstIndex = 0;
				this.sendBuffer.RemoveFirst();
			}
			
			this.StartSend();
		}
	}
}