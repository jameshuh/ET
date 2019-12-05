using UnityEditor;

namespace DCET.Editor
{
	[InitializeOnLoad]
	public class GenFairyGUIHotfix
	{
		static GenFairyGUIHotfix()
		{
			CopyDll();
		}

		public static void CopyDll()
		{
			GenCoreHotfix.CopyDll("Unity.DCET.FairyGUI.Hotfix");
		}

		[MenuItem("CSharpLua/Compile FairyGUIHotfix")]
		public static void CompileLua()
		{
			GenCoreHotfix.CompileLua("Unity.DCET.FairyGUI.Hotfix", "./Packages/DCET/Module/FairyGUI/Hotfix", "FairyGUI");
		}
	}
}
