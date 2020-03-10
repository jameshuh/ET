using DCETRuntime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace DCET
{
	public sealed class TService : AService
	{
		public TServiceProxy Proxy { get; }

		private readonly Dictionary<long, TChannel> idChannels = new Dictionary<long, TChannel>();

		/// <summary>
		/// 即可做client也可做server
		/// </summary>
		public TService(int packetSizeLength, IPEndPoint ipEndPoint, Action<AChannel> acceptCallback)
		{
			this.Proxy = new TServiceProxy(packetSizeLength, ipEndPoint);
			this.Proxy.OnAccept += OnAcceptSocket;
			this.AcceptCallback += acceptCallback;
		}

		private void OnAcceptSocket(Socket acceptSocket)
		{
			TChannel channel = new TChannel(acceptSocket, this);
			this.idChannels[channel.Id] = channel;
			channel.Parent = this;

			try
			{
				this.OnAccept(channel);
			}
			catch (Exception exception)
			{
				Log.Exception(exception);
			}
		}

		public TService(int packetSizeLength)
		{
			this.Proxy = new TServiceProxy(packetSizeLength);
		}
		
		public override void Dispose()
		{
			if (this.IsDisposed)
			{
				return;
			}
			
			base.Dispose();

			foreach (long id in this.idChannels.Keys.ToArray())
			{
				TChannel channel = this.idChannels[id];
				channel.Dispose();
			}

			this.Proxy?.Dispose();
		}

		public override AChannel GetChannel(long id)
		{
			TChannel channel = null;
			this.idChannels.TryGetValue(id, out channel);
			return channel;
		}

		public override AChannel ConnectChannel(IPEndPoint ipEndPoint)
		{
			TChannel channel = new TChannel(ipEndPoint, this);
			this.idChannels[channel.Id] = channel;
			channel.Parent = this;
			return channel;
		}

		public override AChannel ConnectChannel(string address)
		{
			IPEndPoint ipEndPoint = NetworkHelper.ToIPEndPoint(address);
			return this.ConnectChannel(ipEndPoint);
		}

		public void MarkNeedStartSend(long id)
		{
			this.Proxy.MarkNeedStartSend(id);
		}

		public override void Remove(long id)
		{
			TChannel channel;
			if (!this.idChannels.TryGetValue(id, out channel))
			{
				return;
			}
			if (channel == null)
			{
				return;
			}
			this.idChannels.Remove(id);
			channel.Dispose();
		}

		public override void Update()
		{
			foreach (long id in this.Proxy.needStartSendChannel)
			{
				TChannel channel;
				if (!this.idChannels.TryGetValue(id, out channel))
				{
					continue;
				}

				if (channel.IsSending)
				{
					continue;
				}

				try
				{
					channel.StartSend();
				}
				catch (Exception e)
				{
					Log.Exception(e);
				}
			}

			this.Proxy.needStartSendChannel.Clear();
		}
	}
}