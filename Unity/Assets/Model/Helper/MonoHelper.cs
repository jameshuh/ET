using System.Reflection;
using UnityEngine;

namespace DCET.Model
{
	public static class MonoHelper
	{
		private const string codeAssetName = "code.unity3d";
		private const string codePrefabName = "Code";

		public const string Core = "Unity.DCET.Core.Hotfix";
		public const string Message = "Unity.DCET.Message.Hotfix";
		public const string Config = "Unity.DCET.Config.Hotfix";
		public const string BehaviorTree = "Unity.DCET.BehaviorTree.Hotfix";
		public const string FairyGUI = "Unity.DCET.FairyGUI.Hotfix";
		public const string Hotfix = "Unity.DCET.Hotfix";

		public static string CoreDll = $"{Core}.dll";
		public static string MessageDll = $"{Message}.dll";
		public static string ConfigDll = $"{Config}.dll";
		public static string BehaviorTreeDll = $"{BehaviorTree}.dll";
		public static string FairyGUIDll = $"{FairyGUI}.dll";
		public static string HotfixDll = $"{Hotfix}.dll";

		public static string CorePdb = $"{Core}.pdb";
		public static string MessagePdb = $"{Message}.pdb";
		public static string ConfigPdb = $"{Config}.pdb";
		public static string BehaviorTreePdb = $"{BehaviorTree}.pdb";
		public static string FairyGUIPdb = $"{FairyGUI}.pdb";
		public static string HotfixPdb = $"{Hotfix}.pdb";

		public static string CoreDllAssetBytes = $"Assets/Res/Code/{Core}.dll.bytes";
		public static string MessageDllAssetBytes = $"Assets/Res/Code/{Message}.dll.bytes";
		public static string ConfigDllAssetBytes = $"Assets/Res/Code/{Config}.dll.bytes";
		public static string BehaviorTreeDllAssetBytes = $"Assets/Res/Code/{BehaviorTree}.dll.bytes";
		public static string FairyGUIDllAssetBytes = $"Assets/Res/Code/{FairyGUI}.dll.bytes";
		public static string HotfixDllAssetBytes = $"Assets/Res/Code/{Hotfix}.dll.bytes";

		public static void StartHotfix()
		{
			Game.Scene.GetComponent<ResourcesComponent>().LoadBundle(codeAssetName);

			var code = (GameObject)Game.Scene.GetComponent<ResourcesComponent>().GetAsset(codeAssetName, codePrefabName);

			LoadHotfixAssembly(code.Get<TextAsset>(CoreDll).bytes, code.Get<TextAsset>(CorePdb).bytes);
			LoadHotfixAssembly(code.Get<TextAsset>(MessageDll).bytes, code.Get<TextAsset>(MessagePdb).bytes);
			LoadHotfixAssembly(code.Get<TextAsset>(ConfigDll).bytes, code.Get<TextAsset>(ConfigPdb).bytes);
			LoadHotfixAssembly(code.Get<TextAsset>(BehaviorTreeDll).bytes, code.Get<TextAsset>(BehaviorTreePdb).bytes);
			LoadHotfixAssembly(code.Get<TextAsset>(FairyGUIDll).bytes, code.Get<TextAsset>(FairyGUIPdb).bytes);
			LoadMainHotfixAssembly(code.Get<TextAsset>(HotfixDll).bytes, code.Get<TextAsset>(HotfixPdb).bytes);

			Game.Scene.GetComponent<ResourcesComponent>().UnloadBundle(codeAssetName);

			Log.Debug($"当前使用的是Mono模式");
		}

		private static void LoadHotfixAssembly(byte[] assBytes, byte[] pdbBytes)
		{
			var assembly = Assembly.Load(assBytes, pdbBytes);

			if (assembly != null)
			{
				var types = assembly.GetTypes();

				if (types != null)
				{
					foreach (var item in types)
					{
						Game.Hotfix.AddHotfixType(item);
					}
				}
			}
		}

		private static void LoadMainHotfixAssembly(byte[] assBytes, byte[] pdbBytes)
		{
			var mainAssembly = Assembly.Load(assBytes, pdbBytes);

			if (mainAssembly != null)
			{
				var types = mainAssembly.GetTypes();

				if (types != null)
				{
					foreach (var item in types)
					{
						Game.Hotfix.AddHotfixType(item);
					}
				}

				var start = new MonoStaticMethod(mainAssembly.GetType("DCET.Hotfix.Init"), "Start");

				start.Run();
			}
		}
	}
}
