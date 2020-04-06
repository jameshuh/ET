namespace DCETRuntime
{
	public static class UnityEngineHelper
	{
		public static bool op_Implicit(UnityEngine.Object obj)
		{
			return obj;
		}

		public static bool op_Equality(UnityEngine.Object obj1, UnityEngine.Object obj2)
		{
			return obj1 == obj2;
		}

		public static bool op_Inequality(UnityEngine.Object obj1, UnityEngine.Object obj2)
		{
			return obj1 != obj2;
		}
	}
}
