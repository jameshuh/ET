using ETModel.Model;
using FairyGUI;
using System;
using System.Threading.Tasks;

namespace DCET.Model
{
	public class FUIDownloader : IDisposable
	{
		private FUILoading fuiLoading;
		private BundleDownloader bundleDownloader;

		public FUIDownloader()
		{
			fuiLoading = FUILoading.CreateInstance();
			GRoot.inst.AddChild(fuiLoading);
			fuiLoading.MakeFullScreen();

			bundleDownloader = new BundleDownloader();

			GameLoop.onUpdate += Update;
		}

		private void Update()
		{
			fuiLoading.loadingText.text = bundleDownloader.Progress.ToString() + "%";
		}

		public void Dispose()
		{
			GameLoop.onUpdate -= Update;
			fuiLoading.Dispose();
			fuiLoading = null;
			bundleDownloader.Dispose();
			bundleDownloader = null;
		}

		public async Task DownloadAsync()
		{
			await bundleDownloader.StartAsync();

			await bundleDownloader.DownloadAsync();
		}
	}
}
