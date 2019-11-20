using UnityEditor;

namespace DCET.Editor
{
	[InitializeOnLoad]
	public class CopyFairyGUIHotfixDll
	{
		static CopyFairyGUIHotfixDll()
		{
			CopyCoreHotfixDll.Copy("Unity.DCET.FairyGUI.Hotfix");
		}
	}
}
