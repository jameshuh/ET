namespace DCET.Model
{
	public static class HotfixAssembly
	{
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
	}
}
