using UnityEditor;

namespace DCET.Editor
{
	[InitializeOnLoad]
	public class CopyConfigHotfixDll
	{
		static CopyConfigHotfixDll()
		{
			CopyCoreHotfixDll.Copy("Unity.DCET.Config.Hotfix");
		}
	}
}
