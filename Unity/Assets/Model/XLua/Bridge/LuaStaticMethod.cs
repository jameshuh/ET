using XLua;

namespace DCET.Model
{
	public class LuaStaticMethod : IStaticMethod
	{
		private LuaEnv luaEnv;
		private LuaFunction luaFunction;

		public LuaStaticMethod(LuaEnv luaEnv, string methodName)
		{
			this.luaEnv = luaEnv;
			luaFunction = this.luaEnv.Global.GetInPath<LuaFunction>(methodName);
		}

		public override void Run()
		{
			luaFunction.Call();
		}

		public override void Run(object a)
		{
			luaFunction.Call(a);
		}

		public override void Run(object a, object b)
		{
			luaFunction.Call(a, b);
		}

		public override void Run(object a, object b, object c)
		{
			luaFunction.Call(a, b, c);
		}
	}
}