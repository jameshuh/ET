using UnityEditor;

namespace DCET.Editor
{
	[InitializeOnLoad]
	public class CopyBehaviorTreeHotfixDll
	{
		static CopyBehaviorTreeHotfixDll()
		{
			CopyCoreHotfixDll.Copy("Unity.DCET.BehaviorTree.Hotfix");
		}
	}
}
