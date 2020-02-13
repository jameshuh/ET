using System;

namespace DCET.Hotfix
{
	public class TypeHelper
	{
		public static void InitHotfixType()
		{
#if __CSharpLua__
			InitHotfixTypeByLua();
#else
			InitHotfixTypeByMono();
#endif
		}

#if __CSharpLua__
		private static void InitHotfixTypeByLua()
		{
			/*
			[[
			for k,v in pairs(DCET.Hotfix) do
				if v.__metadata__ and v.__metadata__.class then
					DCET.Hotfix.Game.getHotfix():AddHotfixType(System.typeof(v))
				end
			end
			]]
			*/
		}
#else
		private static void InitHotfixTypeByMono()
		{
			var assemblies = AppDomain.CurrentDomain.GetAssemblies();

			if (assemblies != null)
			{
				foreach (var assembly in assemblies)
				{
					if (assembly != null && !string.IsNullOrWhiteSpace(assembly.FullName) && assembly.FullName.Contains("Hotfix"))
					{
						var types = assembly.GetTypes();

						if (types != null)
						{
							foreach (var item in types)
							{
								Game.Hotfix.AddHotfixType(item);
							}
						}
					}
				}
			}
		}
#endif
	}
}