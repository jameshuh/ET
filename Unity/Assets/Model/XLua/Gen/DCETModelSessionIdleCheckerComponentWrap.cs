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
using DCET.Model;

namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class DCETModelSessionIdleCheckerComponentWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DCET.Model.SessionIdleCheckerComponent);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 4, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Check", _m_Check);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "CheckInterval", _g_get_CheckInterval);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "RecvMaxIdleTime", _g_get_RecvMaxIdleTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SendMaxIdleTime", _g_get_SendMaxIdleTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "RepeatedTimer", _g_get_RepeatedTimer);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "CheckInterval", _s_set_CheckInterval);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "RecvMaxIdleTime", _s_set_RecvMaxIdleTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "SendMaxIdleTime", _s_set_SendMaxIdleTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "RepeatedTimer", _s_set_RepeatedTimer);
            
			
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
					
					DCET.Model.SessionIdleCheckerComponent gen_ret = new DCET.Model.SessionIdleCheckerComponent();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to DCET.Model.SessionIdleCheckerComponent constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Check(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.SessionIdleCheckerComponent gen_to_be_invoked = (DCET.Model.SessionIdleCheckerComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Check(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CheckInterval(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.SessionIdleCheckerComponent gen_to_be_invoked = (DCET.Model.SessionIdleCheckerComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.CheckInterval);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RecvMaxIdleTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.SessionIdleCheckerComponent gen_to_be_invoked = (DCET.Model.SessionIdleCheckerComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.RecvMaxIdleTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SendMaxIdleTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.SessionIdleCheckerComponent gen_to_be_invoked = (DCET.Model.SessionIdleCheckerComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.SendMaxIdleTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RepeatedTimer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.SessionIdleCheckerComponent gen_to_be_invoked = (DCET.Model.SessionIdleCheckerComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushint64(L, gen_to_be_invoked.RepeatedTimer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CheckInterval(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.SessionIdleCheckerComponent gen_to_be_invoked = (DCET.Model.SessionIdleCheckerComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CheckInterval = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_RecvMaxIdleTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.SessionIdleCheckerComponent gen_to_be_invoked = (DCET.Model.SessionIdleCheckerComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.RecvMaxIdleTime = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SendMaxIdleTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.SessionIdleCheckerComponent gen_to_be_invoked = (DCET.Model.SessionIdleCheckerComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.SendMaxIdleTime = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_RepeatedTimer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.SessionIdleCheckerComponent gen_to_be_invoked = (DCET.Model.SessionIdleCheckerComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.RepeatedTimer = LuaAPI.lua_toint64(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
