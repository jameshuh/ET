using System;
using System.Threading;
using UnityEngine;

namespace DCET.Model
{
	public class Init : MonoBehaviour
	{
		private const string configAssetName = "config.unity3d";

		private void Start()
		{
			StartAsync().Coroutine();
		}
		
		private async ETVoid StartAsync()
		{
			try
			{
				SynchronizationContext.SetSynchronizationContext(OneThreadSynchronizationContext.Instance);

				DontDestroyOnLoad(gameObject);

				MongoHelper.LookupAssembly(typeof(IConfig));

				Game.EventSystem.Add(typeof(ResourcesComponent).Assembly);
				Game.EventSystem.Add(typeof(ConfigComponent).Assembly);
				Game.EventSystem.Add(typeof(Entity).Assembly);
				Game.EventSystem.Add(typeof(CoroutineLockComponent).Assembly);
				Game.EventSystem.Add(typeof(FUI).Assembly);
				Game.EventSystem.Add(typeof(NetworkComponent).Assembly);
				Game.EventSystem.Add(typeof(NumericComponent).Assembly);
				Game.EventSystem.Add(typeof(Init).Assembly);

				Game.Scene.AddComponent<TimerComponent>();
				Game.Scene.AddComponent<GlobalConfigComponent>();
				Game.Scene.AddComponent<NetOuterComponent>();
				Game.Scene.AddComponent<ResourcesComponent>();
				Game.Scene.AddComponent<PlayerComponent>();
				Game.Scene.AddComponent<UnitComponent>();
				Game.Scene.AddComponent<FUIPackageComponent>();
				Game.Scene.AddComponent<FUIComponent>();
				Game.Scene.AddComponent<FUIInitComponent>();

				// 下载ab包
				await BundleHelper.DownloadBundle();

				// 加载配置
				Game.Scene.GetComponent<ResourcesComponent>().LoadBundle(configAssetName);
				Game.Scene.AddComponent<ConfigComponent>();
				Game.Scene.GetComponent<ResourcesComponent>().UnloadBundle(configAssetName);
				Game.Scene.AddComponent<OpcodeTypeComponent>();
				Game.Scene.AddComponent<MessageDispatcherComponent>();

				LuaHelper.StartHotfix();

				Game.EventSystem.Run(EventIdType.TestHotfixSubscribMonoEvent, "TestHotfixSubscribMonoEvent");
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private void Update()
		{
			OneThreadSynchronizationContext.Instance.Update();
			Game.Hotfix.Update?.Invoke();
			Game.EventSystem.Update();
		}

		private void LateUpdate()
		{
			Game.Hotfix.LateUpdate?.Invoke();
			Game.EventSystem.LateUpdate();
		}

		private void OnApplicationQuit()
		{
			Game.Hotfix.OnApplicationQuit?.Invoke();
			Game.Close();
		}
	}
}