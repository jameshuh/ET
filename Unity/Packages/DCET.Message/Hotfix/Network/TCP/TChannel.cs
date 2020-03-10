using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using DCETRuntime;

namespace DCET
{
	/// <summary>
	/// 封装Socket,将回调push到主线程处理
	/// </summary>
	public sealed class TChannel : AChannel
	{
		public TChannelProxy Proxy { get; }
		private IPEndPoint remoteIpEndPoint;

		public TChannel(IPEndPoint ipEndPoint, TService service): base(service, ChannelType.Connect)
		{
			this.Proxy = new TChannelProxy(ipEndPoint, service.Proxy);
			this.Proxy.OnStartRecv += OnStartRecv;
			this.Proxy.OnRead += OnRead;
			this.Proxy.OnError += OnError;
			this.RemoteAddress = Proxy.RemoteAddress;
			this.remoteIpEndPoint = ipEndPoint;
		}
		
		public TChannel(Socket socket, TService service): base(service, ChannelType.Accept)
		{
			this.Proxy = new TChannelProxy(socket, service.Proxy);
			this.RemoteAddress = Proxy.RemoteAddress;
			this.remoteIpEndPoint = (IPEndPoint)socket.RemoteEndPoint;
		}

		public override void Dispose()
		{
			if (this.IsDisposed)
			{
				return;
			}
			
			base.Dispose();

			this.Proxy?.Dispose();
			this.remoteIpEndPoint = null;
		}

		public override void Start()
		{
			if (this.ChannelType == ChannelType.Accept)
			{
				this.Proxy.StartRecv();
			}
			else
			{
				this.Proxy.ConnectAsync(this.remoteIpEndPoint);
			}
		}
		
		private TService GetService()
		{
			return (TService)this.Service;
		}

		public override MemoryStream Stream
		{
			get
			{
				return this.Proxy.Stream;
			}
		}
		
		public override void Send(MemoryStream stream)
		{
			if (this.IsDisposed)
			{
				throw new Exception("TChannel已经被Dispose, 不能发送消息");
			}

			this.Proxy.Send(stream);
			this.GetService().MarkNeedStartSend(this.Id);
		}

		private void OnStartRecv()
		{
			this.GetService().MarkNeedStartSend(this.Id);
		}

		public bool IsSending => this.Proxy.IsSending;

		public void StartSend()
		{
			this.Proxy.StartSend();
		}
	}
}