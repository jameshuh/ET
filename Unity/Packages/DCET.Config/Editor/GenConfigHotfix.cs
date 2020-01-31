using DCET.Model;
using UnityEditor;

namespace DCET.Editor
{
	[InitializeOnLoad]
	public class GenConfigHotfix
	{
		static GenConfigHotfix()
		{
			if (GenCoreHotfix.CopyDll("Unity.DCET.Config.Hotfix") && Define.IsLua)
			{
				GenCoreHotfix.CompileLua("Unity.DCET.Config.Hotfix", "./Packages/DCET.Config/Hotfix", "Config");
			}
		}
	}
}
