using System.Reflection;

namespace DCET
{
	public class TypeHelper
	{
		public static void InitAllType()
		{
#if __CSharpLua__
			InitAllTypeByLua();
#else
			InitAllTypeByMono();
#endif
		}

#if __CSharpLua__
		private static void InitAllTypeByLua()
		{
			/*
			[[
			for k,v in pairs(DCET) do
				if v.__metadata__ and v.__metadata__.class then
					DCET.Game.getEventSystem():AddType(System.typeof(v))
				end
			end
			]]
			*/
		}
#else
		private static void InitAllTypeByMono()
		{
			Game.EventSystem.AddAssemblyType(Runtime.MonoHelper.Core);
			Game.EventSystem.AddAssemblyType(Runtime.MonoHelper.Config);
			Game.EventSystem.AddAssemblyType(Runtime.MonoHelper.FairyGUI);
			Game.EventSystem.AddAssemblyType(Runtime.MonoHelper.Message);
			Game.EventSystem.AddAssemblyType(Runtime.MonoHelper.BehaviorTree);
			Game.EventSystem.AddAssemblyType(Runtime.MonoHelper.Hotfix);
		}
#endif
	}
}