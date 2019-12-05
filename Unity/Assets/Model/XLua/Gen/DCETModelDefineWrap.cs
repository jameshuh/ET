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
    public class DCETModelDefineWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DCET.Model.Define);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 4, 4);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "IsAsync", _g_get_IsAsync);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "IsEditorMode", _g_get_IsEditorMode);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "IsDevelopmentBuild", _g_get_IsDevelopmentBuild);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "IsILRuntime", _g_get_IsILRuntime);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "IsAsync", _s_set_IsAsync);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "IsEditorMode", _s_set_IsEditorMode);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "IsDevelopmentBuild", _s_set_IsDevelopmentBuild);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "IsILRuntime", _s_set_IsILRuntime);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "DCET.Model.Define does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsAsync(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, DCET.Model.Define.IsAsync);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsEditorMode(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, DCET.Model.Define.IsEditorMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsDevelopmentBuild(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, DCET.Model.Define.IsDevelopmentBuild);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsILRuntime(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, DCET.Model.Define.IsILRuntime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsAsync(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.Define.IsAsync = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsEditorMode(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.Define.IsEditorMode = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsDevelopmentBuild(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.Define.IsDevelopmentBuild = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsILRuntime(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.Define.IsILRuntime = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
