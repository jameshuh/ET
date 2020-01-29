#if UNITY_EDITOR
using System.IO;
using System.Threading.Tasks;
using UnityEditor;
#endif
using UnityEngine;

namespace DCET.Model
{
	public static class ResourcesHelper
	{
		public static Object Load(string path)
		{
			return Resources.Load(path);
		}

		public static async Task<Object[]> LoadAssets(string assetBundleName)
		{
			if (!Define.IsAsync)
			{
#if UNITY_EDITOR
				var paths = AssetDatabase.GetAssetPathsFromAssetBundle(assetBundleName);

				if (paths != null)
				{
					var assets = new Object[paths.Length];
					var index = 0;

					foreach (string s in paths)
					{
						var assetName = Path.GetFileNameWithoutExtension(s);
						assets[index] = AssetDatabase.LoadAssetAtPath<Object>(s);
						index++;
					}

					return assets;
				}				
#endif
				return null;
			}

			string p = Path.Combine(PathHelper.AppHotfixResPath, assetBundleName);

			if (!File.Exists(p))
			{
				p = Path.Combine(PathHelper.AppResPath, assetBundleName);
			}

			AssetBundle assetBundle = null;

			using (AssetsBundleLoaderAsync assetsBundleLoaderAsync = new AssetsBundleLoaderAsync())
			{
				assetBundle = await assetsBundleLoaderAsync.LoadAsync(p);
			}

			if (assetBundle == null)
			{
				Log.Error($"assets bundle not found: {assetBundleName}");
				return null;
			}

			if (!assetBundle.isStreamedSceneAssetBundle)
			{
				using (AssetsLoaderAsync assetsLoaderAsync = new AssetsLoaderAsync(assetBundle))
				{
					return await assetsLoaderAsync.LoadAllAssetsAsync();
				}
			}

			return null;
		}
	}
}
