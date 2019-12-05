#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class DCETModelOuterOpcodeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DCET.Model.OuterOpcode);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 16, 0, 0);
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "C2M_TestRequest", DCET.Model.OuterOpcode.C2M_TestRequest);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "M2C_TestResponse", DCET.Model.OuterOpcode.M2C_TestResponse);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Actor_TransferRequest", DCET.Model.OuterOpcode.Actor_TransferRequest);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Actor_TransferResponse", DCET.Model.OuterOpcode.Actor_TransferResponse);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "C2G_EnterMap", DCET.Model.OuterOpcode.C2G_EnterMap);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "G2C_EnterMap", DCET.Model.OuterOpcode.G2C_EnterMap);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnitInfo", DCET.Model.OuterOpcode.UnitInfo);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "M2C_CreateUnits", DCET.Model.OuterOpcode.M2C_CreateUnits);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Frame_ClickMap", DCET.Model.OuterOpcode.Frame_ClickMap);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "M2C_PathfindingResult", DCET.Model.OuterOpcode.M2C_PathfindingResult);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "C2R_Ping", DCET.Model.OuterOpcode.C2R_Ping);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "R2C_Ping", DCET.Model.OuterOpcode.R2C_Ping);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "G2C_Test", DCET.Model.OuterOpcode.G2C_Test);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "C2M_Reload", DCET.Model.OuterOpcode.C2M_Reload);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "M2C_Reload", DCET.Model.OuterOpcode.M2C_Reload);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "DCET.Model.OuterOpcode does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        
        
        
        
        
		
		
		
		
    }
}
