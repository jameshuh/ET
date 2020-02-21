using System.Reflection;
using UnityEngine;

namespace DCET.Runtime
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

		public static async void StartHotfix()
		{
			Log.Debug($"当前使用的是Mono模式");

			var code = await AssetBundles.Default.LoadAssetAsync(codeAssetName, codePrefabName) as GameObject;

			if (code)
			{
				Assembly.Load(code.GetTextAsset(CoreDll).bytes, code.GetTextAsset(CorePdb).bytes);
				Assembly.Load(code.GetTextAsset(MessageDll).bytes, code.GetTextAsset(MessagePdb).bytes);
				Assembly.Load(code.GetTextAsset(ConfigDll).bytes, code.GetTextAsset(ConfigPdb).bytes);
				Assembly.Load(code.GetTextAsset(BehaviorTreeDll).bytes, code.GetTextAsset(BehaviorTreePdb).bytes);
				Assembly.Load(code.GetTextAsset(FairyGUIDll).bytes, code.GetTextAsset(FairyGUIPdb).bytes);

				var mainAssembly = Assembly.Load(code.GetTextAsset(HotfixDll).bytes, code.GetTextAsset(HotfixPdb).bytes);
				var start = new MonoStaticMethod(mainAssembly.GetType("DCET.Init"), "Start");
				start.Run();
			}			
		}
	}
}
