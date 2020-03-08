using System.Reflection;

namespace DCET
{
	public class TypeHelper
	{
		public static void Init()
		{
#if __CSharpLua__
			InitByLua();
#else
			InitByMono();
#endif
		}

#if __CSharpLua__
		private static void InitByLua()
		{
			/*
			[[
			for k,v in pairs(DCET) do
				if v ~= DCET.Runtime then
					DCET.Game.getEventSystem():AddType(System.typeof(v))
				end
			end
			]]
			*/
		}
#else
		private static void InitByMono()
		{
			Game.EventSystem.AddAssemblyType(Runtime.MonoHelper.Core);
			Game.EventSystem.AddAssemblyType(Runtime.MonoHelper.Config);
			Game.EventSystem.AddAssemblyType(Runtime.MonoHelper.FairyGUI);
			Game.EventSystem.AddAssemblyType(Runtime.MonoHelper.Message);
			Game.EventSystem.AddAssemblyType(Runtime.MonoHelper.BehaviorTree);
			Game.EventSystem.AddAssemblyType(Runtime.MonoHelper.Hotfix);

			Runtime.MongoHelper.LookupTypes(Game.EventSystem.GetAllType());
		}
#endif
	}
}