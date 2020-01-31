using DCET.Model;
using UnityEditor;

namespace DCET.Editor
{
	[InitializeOnLoad]
	public class GenBehaviorTreeHotfix
	{
		static GenBehaviorTreeHotfix()
		{
			if (GenCoreHotfix.CopyDll("Unity.DCET.BehaviorTree.Hotfix") && Define.IsLua)
			{
				GenCoreHotfix.CompileLua("Unity.DCET.BehaviorTree.Hotfix", "./Packages/DCET.BehaviorTree/Hotfix", "BehaviorTree");
			}
		}
	}
}
