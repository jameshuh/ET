using System;
using System.Threading;
using UnityEngine;

namespace DCET.Model
{
	public class Init : MonoBehaviour
	{
		private const string configAssetName = "config.unity3d";
		private const string codeAssetName = "code.unity3d";
		private const string codePrefabName = "Code";

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

				InitHotfixAssemblys();

				Game.EventSystem.Run(EventIdType.TestHotfixSubscribMonoEvent, "TestHotfixSubscribMonoEvent");
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private static void InitHotfixAssemblys()
		{
			Game.Scene.GetComponent<ResourcesComponent>().LoadBundle(codeAssetName);

			GameObject code = (GameObject)Game.Scene.GetComponent<ResourcesComponent>().GetAsset(codeAssetName, codePrefabName);
			
			Game.Hotfix.LoadHotfixAssembly(code.Get<TextAsset>(HotfixAssembly.CoreDll).bytes, code.Get<TextAsset>(HotfixAssembly.CorePdb).bytes);
			Game.Hotfix.LoadHotfixAssembly(code.Get<TextAsset>(HotfixAssembly.MessageDll).bytes, code.Get<TextAsset>(HotfixAssembly.MessagePdb).bytes);
			Game.Hotfix.LoadHotfixAssembly(code.Get<TextAsset>(HotfixAssembly.ConfigDll).bytes, code.Get<TextAsset>(HotfixAssembly.ConfigPdb).bytes);
			Game.Hotfix.LoadHotfixAssembly(code.Get<TextAsset>(HotfixAssembly.BehaviorTreeDll).bytes, code.Get<TextAsset>(HotfixAssembly.BehaviorTreePdb).bytes);
			Game.Hotfix.LoadHotfixAssembly(code.Get<TextAsset>(HotfixAssembly.FairyGUIDll).bytes, code.Get<TextAsset>(HotfixAssembly.FairyGUIPdb).bytes);
			Game.Hotfix.LoadMainHotfixAssembly(code.Get<TextAsset>(HotfixAssembly.HotfixDll).bytes, code.Get<TextAsset>(HotfixAssembly.HotfixPdb).bytes);

			Game.Scene.GetComponent<ResourcesComponent>().UnloadBundle(codeAssetName);

#if ILRuntime
			ILHelper.InitILRuntime(Game.Hotfix.appDomain);
#endif
			Game.Hotfix.GotoHotfix();
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