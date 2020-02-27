namespace DCET.Runtime
{
	public static class HotfixHelper
	{
		public static void StartHotfix()
		{
#if TOLUA
			LuaHelper.StartHotfix();
#else
			MonoHelper.StartHotfix();
#endif
		}
	}
}
