using UnityEditor;
using UnityEngine;

namespace DCET.Editor
{
	[InitializeOnLoad]
	public class GenHotfix
	{
		static GenHotfix()
		{
			CopyDll(); 
		}

		public static void CopyDll()
		{
			GenCoreHotfix.CopyDll("Unity.DCET.Hotfix");
		}

		[MenuItem("CSharpLua/Compile Hotfix")]
		public static void CompileLua()
		{
			GenCoreHotfix.CompileLua("Unity.DCET.Hotfix", Application.dataPath + "/Hotfix", "Hotfix");
		}
	}
}
