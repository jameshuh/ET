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
    public class DCETModelIdGeneraterWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DCET.Model.IdGenerater);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 6, 3, 2);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GenerateSceneId", _m_GenerateSceneId_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GenerateSceneInstanceId", _m_GenerateSceneInstanceId_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GenerateId", _m_GenerateId_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetProcessId", _m_GetProcessId_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HeadPos", DCET.Model.IdGenerater.HeadPos);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Head", _g_get_Head);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "AppId", _g_get_AppId);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "HeadMask", _g_get_HeadMask);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "AppId", _s_set_AppId);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "HeadMask", _s_set_HeadMask);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "DCET.Model.IdGenerater does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GenerateSceneId_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        long gen_ret = DCET.Model.IdGenerater.GenerateSceneId(  );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GenerateSceneInstanceId_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    long _id = LuaAPI.lua_toint64(L, 1);
                    
                        long gen_ret = DCET.Model.IdGenerater.GenerateSceneInstanceId( _id );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GenerateId_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        long gen_ret = DCET.Model.IdGenerater.GenerateId(  );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetProcessId_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    long _v = LuaAPI.lua_toint64(L, 1);
                    
                        int gen_ret = DCET.Model.IdGenerater.GetProcessId( _v );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Head(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushint64(L, DCET.Model.IdGenerater.Head);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AppId(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushint64(L, DCET.Model.IdGenerater.AppId);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HeadMask(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushint64(L, DCET.Model.IdGenerater.HeadMask);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AppId(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.IdGenerater.AppId = LuaAPI.lua_toint64(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_HeadMask(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.IdGenerater.HeadMask = LuaAPI.lua_toint64(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
