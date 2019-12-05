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
    public class DCETModelSessionIdleCheckerComponentAwakeSystemWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DCET.Model.SessionIdleCheckerComponentAwakeSystem);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Awake", _m_Awake);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					DCET.Model.SessionIdleCheckerComponentAwakeSystem gen_ret = new DCET.Model.SessionIdleCheckerComponentAwakeSystem();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to DCET.Model.SessionIdleCheckerComponentAwakeSystem constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Awake(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.SessionIdleCheckerComponentAwakeSystem gen_to_be_invoked = (DCET.Model.SessionIdleCheckerComponentAwakeSystem)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    DCET.Model.SessionIdleCheckerComponent _self = (DCET.Model.SessionIdleCheckerComponent)translator.GetObject(L, 2, typeof(DCET.Model.SessionIdleCheckerComponent));
                    int _checkInteral = LuaAPI.xlua_tointeger(L, 3);
                    int _recvMaxIdleTime = LuaAPI.xlua_tointeger(L, 4);
                    int _sendMaxIdleTime = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.Awake( _self, _checkInteral, _recvMaxIdleTime, _sendMaxIdleTime );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
