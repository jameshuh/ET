namespace DCET
{
	public static class Game
	{
		private static EventSystem eventSystem;

		public static EventSystem EventSystem
		{
			get
			{
				return eventSystem ?? (eventSystem = new EventSystem());
			}
		}
		
		private static Scene scene;

		public static Scene Scene
		{
			get
			{
				if (scene != null)
				{
					return scene;
				}
				scene = new Scene() { Name = "ClientM" };
				return scene;
			}

#if SERVER
			set
			{
				scene = value;
			}
#endif
		}

		private static ObjectPool objectPool;

		public static ObjectPool ObjectPool
		{
			get
			{
				if (objectPool != null)
				{
					return objectPool;
				}
				objectPool = new ObjectPool() { Name = "ClientM" };
				return objectPool;
			}
		}

#if SERVER
		public static Options Options;
#endif

		public static void Close()
		{
			scene?.Dispose();
			scene = null;
			
			objectPool?.Dispose();
			objectPool = null;
					
			eventSystem = null;
#if SERVER
			Options = null;
#endif
	}
}
}