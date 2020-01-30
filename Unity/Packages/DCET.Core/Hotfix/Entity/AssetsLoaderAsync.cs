using System.Threading.Tasks;
using UnityEngine;

namespace DCET.Hotfix
{
	[ObjectSystem]
	public class AssetsLoaderAsyncAwakeSystem : AwakeSystem<AssetsLoaderAsync, AssetBundle>
	{
		public override void Awake(AssetsLoaderAsync self, AssetBundle a)
		{
			self.Awake(a);
		}
	}

	[ObjectSystem]
	public class AssetsLoaderAsyncUpdateSystem : UpdateSystem<AssetsLoaderAsync>
	{
		public override void Update(AssetsLoaderAsync self)
		{
			self.Update();
		}
	}

	public class AssetsLoaderAsync : Entity
	{
		private AssetBundle assetBundle;

		private AssetBundleRequest request;

		private TaskCompletionSource<bool> tcs;

		public void Awake(AssetBundle ab)
		{
			this.assetBundle = ab;
		}

		public void Update()
		{
			if (!this.request.isDone)
			{
				return;
			}

			var t = tcs;
			t.SetResult(true);
		}

		public override void Dispose()
		{
			if (this.IsDisposed)
		{
				return;
			}
			base.Dispose();

			this.assetBundle = null;
			this.request = null;
		}

		public async Task<UnityEngine.Object[]> LoadAllAssetsAsync()
		{
			await InnerLoadAllAssetsAsync();
			return this.request.allAssets;
		}

		private Task InnerLoadAllAssetsAsync()
		{
			this.tcs = new TaskCompletionSource<bool>();
			this.request = assetBundle.LoadAllAssetsAsync();
			return this.tcs.Task;
		}
	}
}
