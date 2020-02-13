using DCET.Model;
using UnityEditor;
using UnityEngine;

namespace DCET.Editor
{
	[InitializeOnLoad]
	public class GenHotfix
	{
		static GenHotfix()
		{
			if (GenCoreHotfix.CopyDll("Unity.DCET.Hotfix") && Define.IsLua)
			{
				GenCoreHotfix.CompileLua("Unity.DCET.Hotfix", Application.dataPath + "/Hotfix", "Hotfix", false);
			}
		}
	}
}
