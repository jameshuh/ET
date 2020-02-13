using UnityEngine;

namespace DCET.Model
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
