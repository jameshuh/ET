using DCET.Model;
using UnityEditor;

namespace DCET.Editor
{
	[InitializeOnLoad]
	public class GenFairyGUIHotfix
	{
		static GenFairyGUIHotfix()
		{
			if (GenCoreHotfix.CopyDll("Unity.DCET.FairyGUI.Hotfix") && Define.IsLua)
			{
				GenCoreHotfix.CompileLua("Unity.DCET.FairyGUI.Hotfix", "./Packages/DCET.FairyGUI/Hotfix", "FairyGUI", true);
			}
		}
	}
}
