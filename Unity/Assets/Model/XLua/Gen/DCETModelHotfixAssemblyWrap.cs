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
    public class DCETModelHotfixAssemblyWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DCET.Model.MonoHelper);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 7, 18, 18);
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Core", DCET.Model.MonoHelper.Core);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Message", DCET.Model.MonoHelper.Message);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Config", DCET.Model.MonoHelper.Config);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BehaviorTree", DCET.Model.MonoHelper.BehaviorTree);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FairyGUI", DCET.Model.MonoHelper.FairyGUI);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Hotfix", DCET.Model.MonoHelper.Hotfix);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "CoreDll", _g_get_CoreDll);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MessageDll", _g_get_MessageDll);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ConfigDll", _g_get_ConfigDll);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "BehaviorTreeDll", _g_get_BehaviorTreeDll);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "FairyGUIDll", _g_get_FairyGUIDll);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "HotfixDll", _g_get_HotfixDll);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "CorePdb", _g_get_CorePdb);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MessagePdb", _g_get_MessagePdb);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ConfigPdb", _g_get_ConfigPdb);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "BehaviorTreePdb", _g_get_BehaviorTreePdb);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "FairyGUIPdb", _g_get_FairyGUIPdb);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "HotfixPdb", _g_get_HotfixPdb);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "CoreDllAssetBytes", _g_get_CoreDllAssetBytes);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MessageDllAssetBytes", _g_get_MessageDllAssetBytes);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ConfigDllAssetBytes", _g_get_ConfigDllAssetBytes);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "BehaviorTreeDllAssetBytes", _g_get_BehaviorTreeDllAssetBytes);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "FairyGUIDllAssetBytes", _g_get_FairyGUIDllAssetBytes);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "HotfixDllAssetBytes", _g_get_HotfixDllAssetBytes);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "CoreDll", _s_set_CoreDll);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "MessageDll", _s_set_MessageDll);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ConfigDll", _s_set_ConfigDll);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "BehaviorTreeDll", _s_set_BehaviorTreeDll);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "FairyGUIDll", _s_set_FairyGUIDll);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "HotfixDll", _s_set_HotfixDll);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "CorePdb", _s_set_CorePdb);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "MessagePdb", _s_set_MessagePdb);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ConfigPdb", _s_set_ConfigPdb);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "BehaviorTreePdb", _s_set_BehaviorTreePdb);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "FairyGUIPdb", _s_set_FairyGUIPdb);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "HotfixPdb", _s_set_HotfixPdb);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "CoreDllAssetBytes", _s_set_CoreDllAssetBytes);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "MessageDllAssetBytes", _s_set_MessageDllAssetBytes);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ConfigDllAssetBytes", _s_set_ConfigDllAssetBytes);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "BehaviorTreeDllAssetBytes", _s_set_BehaviorTreeDllAssetBytes);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "FairyGUIDllAssetBytes", _s_set_FairyGUIDllAssetBytes);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "HotfixDllAssetBytes", _s_set_HotfixDllAssetBytes);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				
				if (LuaAPI.lua_gettop(L) == 1)
				{
				    translator.PushAny(L, default(DCET.Model.MonoHelper));
			        return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to DCET.Model.HotfixAssembly constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CoreDll(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.MonoHelper.CoreDll);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MessageDll(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.MonoHelper.MessageDll);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ConfigDll(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.MonoHelper.ConfigDll);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BehaviorTreeDll(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.MonoHelper.BehaviorTreeDll);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_FairyGUIDll(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.MonoHelper.FairyGUIDll);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HotfixDll(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.MonoHelper.HotfixDll);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CorePdb(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.MonoHelper.CorePdb);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MessagePdb(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.MonoHelper.MessagePdb);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ConfigPdb(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.MonoHelper.ConfigPdb);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BehaviorTreePdb(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.MonoHelper.BehaviorTreePdb);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_FairyGUIPdb(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.MonoHelper.FairyGUIPdb);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HotfixPdb(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.MonoHelper.HotfixPdb);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CoreDllAssetBytes(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.MonoHelper.CoreDllAssetBytes);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MessageDllAssetBytes(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.MonoHelper.MessageDllAssetBytes);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ConfigDllAssetBytes(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.MonoHelper.ConfigDllAssetBytes);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BehaviorTreeDllAssetBytes(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.MonoHelper.BehaviorTreeDllAssetBytes);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_FairyGUIDllAssetBytes(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.MonoHelper.FairyGUIDllAssetBytes);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HotfixDllAssetBytes(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.MonoHelper.HotfixDllAssetBytes);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CoreDll(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.MonoHelper.CoreDll = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MessageDll(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.MonoHelper.MessageDll = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ConfigDll(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.MonoHelper.ConfigDll = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_BehaviorTreeDll(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.MonoHelper.BehaviorTreeDll = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_FairyGUIDll(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.MonoHelper.FairyGUIDll = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_HotfixDll(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.MonoHelper.HotfixDll = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CorePdb(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.MonoHelper.CorePdb = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MessagePdb(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.MonoHelper.MessagePdb = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ConfigPdb(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.MonoHelper.ConfigPdb = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_BehaviorTreePdb(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.MonoHelper.BehaviorTreePdb = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_FairyGUIPdb(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.MonoHelper.FairyGUIPdb = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_HotfixPdb(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.MonoHelper.HotfixPdb = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CoreDllAssetBytes(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.MonoHelper.CoreDllAssetBytes = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MessageDllAssetBytes(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.MonoHelper.MessageDllAssetBytes = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ConfigDllAssetBytes(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.MonoHelper.ConfigDllAssetBytes = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_BehaviorTreeDllAssetBytes(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.MonoHelper.BehaviorTreeDllAssetBytes = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_FairyGUIDllAssetBytes(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.MonoHelper.FairyGUIDllAssetBytes = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_HotfixDllAssetBytes(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.MonoHelper.HotfixDllAssetBytes = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
