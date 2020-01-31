using DCET.Model;
using UnityEditor;

namespace DCET.Editor
{
	[InitializeOnLoad]
	public class GenMessageHotfix
	{
		static GenMessageHotfix()
		{
			if (GenCoreHotfix.CopyDll("Unity.DCET.Message.Hotfix") && Define.IsLua)
			{
				GenCoreHotfix.CompileLua("Unity.DCET.Message.Hotfix", "./Packages/DCET.Message/Hotfix", "Message");
			}
		}
	}
}
