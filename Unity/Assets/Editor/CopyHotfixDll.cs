using UnityEditor;

namespace DCET.Editor
{
	[InitializeOnLoad]
	public class CopyHotfixDll
	{
		static CopyHotfixDll()
		{
			CopyCoreHotfixDll.Copy("Unity.DCET.Hotfix");
		}
	}
}
