using FairyGUI;
using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace DCET.Runtime
{
	public class Init : MonoBehaviour
	{
		private async void Awake()
		{
			try
			{
				SynchronizationContext.SetSynchronizationContext(OneThreadSynchronizationContext.Instance);

				DontDestroyOnLoad(gameObject);

				await DownloadBundle();

				HotfixHelper.StartHotfix();
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private async Task DownloadBundle()
		{
			GRoot.inst.SetContentScaleFactor(1920, 1080);

			ModelBinder.BindAll();

			if (!Define.IsEditorMode)
			{
				using (FUIPackage fuiPackage = new FUIPackage("FUI/Model"))
				{
					using (FUIDownloader fuiDownloader = new FUIDownloader())
					{
						await fuiDownloader.DownloadAsync();
					}
				}
			}			
		}

		private void Start()
		{
			try
			{
				GameLoop.onStart?.Invoke();
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private void OnEnable()
		{
			try
			{
				GameLoop.onEnable?.Invoke();
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private void OnDisable()
		{
			try
			{
				GameLoop.onDisable?.Invoke();
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private void Update()
		{
			try
			{
				OneThreadSynchronizationContext.Instance.Update();
				GameLoop.onUpdate?.Invoke();
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private void LateUpdate()
		{
			try
			{
				GameLoop.onLateUpdate?.Invoke();
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private void FixedUpdate()
		{
			try
			{
				GameLoop.onFixedUpdate?.Invoke();
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private void OnDestroy()
		{
			try
			{
				GameLoop.onDestroy?.Invoke();
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private void OnApplicationPause(bool isPause)
		{
			try
			{
				GameLoop.onApplicationPause?.Invoke(isPause);
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private void OnApplicationFocus(bool isFocus)
		{
			try
			{
				GameLoop.onApplicationFocus?.Invoke(isFocus);
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private void OnApplicationQuit()
		{
			try
			{
				GameLoop.onApplicationQuit?.Invoke();

				Lua.Default.Dispose();
				AssetBundles.Default.Dispose();
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}
	}
}