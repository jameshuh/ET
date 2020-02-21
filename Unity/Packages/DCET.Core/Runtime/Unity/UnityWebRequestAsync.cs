using System;
using System.Threading.Tasks;
using UnityEngine.Networking;

namespace DCET.Runtime
{
	public class AcceptAllCertificate : CertificateHandler
	{
		protected override bool ValidateCertificate(byte[] certificateData)
		{
			return true;
		}
	}

	public class UnityWebRequestAsync : IDisposable
	{
		public static AcceptAllCertificate certificateHandler = new AcceptAllCertificate();
		
		public UnityWebRequest Request;

		public bool isCancel;

		public TaskCompletionSource<string> tcs;

		public void Dispose()
		{
			GameLoop.onUpdate -= Update;
			this.Request?.Dispose();
			this.Request = null;
			this.isCancel = false;
		}

		public float Progress
		{
			get
			{
				if (this.Request == null)
				{
					return 0;
				}
				return this.Request.downloadProgress;
			}
		}

		public ulong ByteDownloaded
		{
			get
			{
				if (this.Request == null)
				{
					return 0;
				}
				return this.Request.downloadedBytes;
			}
		}

		public void Update()
		{
			if (this.isCancel)
			{
				this.tcs.SetResult($"request error: {this.Request.error}");
				return;
			}
			
			if (!this.Request.isDone)
			{
				return;
			}
			if (!string.IsNullOrEmpty(this.Request.error))
			{
				this.tcs.SetResult($"request error: {this.Request.error}");
				return;
			}

			this.tcs.SetResult(string.Empty);
		}

		public Task<string> DownloadAsync(string url)
		{
			this.tcs = new TaskCompletionSource<string>();
			
			url = url.Replace(" ", "%20");
			this.Request = UnityWebRequest.Get(url);
			this.Request.certificateHandler = certificateHandler;
			this.Request.SendWebRequest();

			GameLoop.onUpdate -= Update;
			GameLoop.onUpdate += Update;

			return this.tcs.Task;
		}
	}
}
