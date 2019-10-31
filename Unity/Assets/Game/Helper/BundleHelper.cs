using System;
using UnityEngine;

namespace ETModel
{
	public static class BundleHelper
	{
		public static async ETTask DownloadBundle()
		{
			if (Define.IsAsync)
			{
				try
				{
					using (BundleDownloaderComponent bundleDownloaderComponent = Game.Scene.AddComponent<BundleDownloaderComponent>())
					{
						await bundleDownloaderComponent.StartAsync();
						
						Game.EventSystem.Run(EventIdType.LoadingBegin);
						
						await bundleDownloaderComponent.DownloadAsync();
					}
					
					Game.EventSystem.Run(EventIdType.LoadingFinish);
					
					Game.Scene.GetComponent<ResourcesComponent>().LoadOneBundle("StreamingAssets");
					ResourcesComponent.AssetBundleManifestObject = (AssetBundleManifest)Game.Scene.GetComponent<ResourcesComponent>().GetAsset("StreamingAssets", "AssetBundleManifest");
				}
				catch (Exception e)
				{
					Log.Error(e);
				}

			}
		}
	}
}
