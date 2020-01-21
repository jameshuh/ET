using DCET.Model;
using System;
using System.Threading.Tasks;

namespace ETModel
{
	public static class BundleHelper
	{
		public static async Task DownloadBundle()
		{
			if (Define.IsAsync)
			{
				try
				{
					using (BundleDownloaderComponent bundleDownloaderComponent = new BundleDownloaderComponent())
					{
						await bundleDownloaderComponent.StartAsync();
						
						await bundleDownloaderComponent.DownloadAsync();
					}
				}
				catch (Exception e)
				{
					Log.Error(e);
				}
			}
		}
	}
}
