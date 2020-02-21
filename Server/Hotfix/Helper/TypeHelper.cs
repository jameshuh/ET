namespace DCET
{
	public static class TypeHelper
	{
		public static void InitAllType()
		{
			Game.EventSystem.AddAssemblyType("Core");
			Game.EventSystem.AddAssemblyType("Config");
			Game.EventSystem.AddAssemblyType("CoroutineLock");
			Game.EventSystem.AddAssemblyType("DB");
			Game.EventSystem.AddAssemblyType("Message");
			Game.EventSystem.AddAssemblyType("Numeric");
			Game.EventSystem.AddAssemblyType("Pathfinding");			
			Game.EventSystem.AddAssemblyType("BehaviorTree");
			Game.EventSystem.AddAssemblyType("Runtime");
			Game.EventSystem.AddAssemblyType("Hotfix");
			Game.EventSystem.AddAssemblyType("Benchmark");
		}
	}
}
