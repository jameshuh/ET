using UnityEditor;

namespace DCET.Editor
{
	[InitializeOnLoad]
	public class GenBehaviorTreeHotfix
	{
		static GenBehaviorTreeHotfix()
		{
			CopyDll();
		}

		[MenuItem("CSharpLua/Compile BehaviorTreeHotfix")]
		public static void CompileLua()
		{
			GenCoreHotfix.CompileLua("Unity.DCET.BehaviorTree.Hotfix", "./Packages/DCET/Module/BehaviorTree/Hotfix", "BehaviorTree");
		}

		public static void CopyDll()
		{
			GenCoreHotfix.CopyDll("Unity.DCET.BehaviorTree.Hotfix");
		}
	}
}
