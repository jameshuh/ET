using UnityEditor;

namespace DCET.Editor
{
	[InitializeOnLoad]
	public class GenMessageHotfix
	{
		static GenMessageHotfix()
		{
			CopyDll();
		}

		public static void CopyDll()
		{
			GenCoreHotfix.CopyDll("Unity.DCET.Message.Hotfix");
		}

		[MenuItem("CSharpLua/Compile MessageHotfix")]
		public static void CompileLua()
		{
			GenCoreHotfix.CompileLua("Unity.DCET.Message.Hotfix", "./Packages/DCET.Message/Hotfix", "Message");
		}
	}
}
