using UnityEngine;

namespace DCET.Runtime
{
	public static class HotfixHelper
	{
		public static void StartHotfix()
		{
			if (Define.IsLua)
			{
				LuaHelper.StartHotfix();
			}
			else
			{
				MonoHelper.StartHotfix();
			}
		}
	}
}
