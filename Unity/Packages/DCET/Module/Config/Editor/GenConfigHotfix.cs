using UnityEditor;

namespace DCET.Editor
{
	[InitializeOnLoad]
	public class GenConfigHotfix
	{
		static GenConfigHotfix()
		{
			CopyDll();
		}

		public static void CopyDll()
		{
			GenCoreHotfix.CopyDll("Unity.DCET.Config.Hotfix");
		}

		[MenuItem("CSharpLua/Compile ConfigHotfix")]
		public static void CompileLua()
		{
			GenCoreHotfix.CompileLua("Unity.DCET.Config.Hotfix", "./Packages/DCET/Module/Config/Hotfix", "Config");
		}
	}
}
