using UnityEditor;

namespace DCET.Editor
{
	[InitializeOnLoad]
	public class CopyMessageHotfixDll
	{
		static CopyMessageHotfixDll()
		{
			CopyCoreHotfixDll.Copy("Unity.DCET.Message.Hotfix");
		}
	}
}
