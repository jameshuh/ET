namespace ET
{
	public static class Define
	{
#if UNITY_EDITOR && !ASYNC
		public static bool IsAsync = false;
#else
        public static bool IsAsync = true;
#endif
#if UNITY_EDITOR
        public static bool IsEditorMode = true;
#else
		public static bool IsEditorMode = false;
#endif
    }
}