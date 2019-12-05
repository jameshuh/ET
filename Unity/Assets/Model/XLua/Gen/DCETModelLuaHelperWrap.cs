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
    public class DCETModelLuaHelperWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DCET.Model.LuaHelper);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 11, 8, 8);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "StartHotfix", _m_StartHotfix_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "XLua", DCET.Model.LuaHelper.XLua);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CSharpLua", DCET.Model.LuaHelper.CSharpLua);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Core", DCET.Model.LuaHelper.Core);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Message", DCET.Model.LuaHelper.Message);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Config", DCET.Model.LuaHelper.Config);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BehaviorTree", DCET.Model.LuaHelper.BehaviorTree);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FairyGUI", DCET.Model.LuaHelper.FairyGUI);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Hotfix", DCET.Model.LuaHelper.Hotfix);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "manifestFileName", DCET.Model.LuaHelper.manifestFileName);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "XLuaAssetName", _g_get_XLuaAssetName);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "CSharpLuaAssetName", _g_get_CSharpLuaAssetName);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "CoreAssetName", _g_get_CoreAssetName);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MessageAssetName", _g_get_MessageAssetName);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ConfigAssetName", _g_get_ConfigAssetName);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "BehaviorTreeAssetName", _g_get_BehaviorTreeAssetName);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "FairyGUIAssetName", _g_get_FairyGUIAssetName);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "HotfixAssetName", _g_get_HotfixAssetName);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "XLuaAssetName", _s_set_XLuaAssetName);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "CSharpLuaAssetName", _s_set_CSharpLuaAssetName);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "CoreAssetName", _s_set_CoreAssetName);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "MessageAssetName", _s_set_MessageAssetName);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ConfigAssetName", _s_set_ConfigAssetName);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "BehaviorTreeAssetName", _s_set_BehaviorTreeAssetName);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "FairyGUIAssetName", _s_set_FairyGUIAssetName);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "HotfixAssetName", _s_set_HotfixAssetName);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "DCET.Model.LuaHelper does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StartHotfix_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    DCET.Model.LuaHelper.StartHotfix(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_XLuaAssetName(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.LuaHelper.XLuaAssetName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CSharpLuaAssetName(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.LuaHelper.CSharpLuaAssetName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CoreAssetName(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.LuaHelper.CoreAssetName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MessageAssetName(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.LuaHelper.MessageAssetName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ConfigAssetName(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.LuaHelper.ConfigAssetName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BehaviorTreeAssetName(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.LuaHelper.BehaviorTreeAssetName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_FairyGUIAssetName(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.LuaHelper.FairyGUIAssetName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HotfixAssetName(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DCET.Model.LuaHelper.HotfixAssetName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_XLuaAssetName(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.LuaHelper.XLuaAssetName = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CSharpLuaAssetName(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.LuaHelper.CSharpLuaAssetName = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CoreAssetName(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.LuaHelper.CoreAssetName = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MessageAssetName(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.LuaHelper.MessageAssetName = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ConfigAssetName(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.LuaHelper.ConfigAssetName = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_BehaviorTreeAssetName(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.LuaHelper.BehaviorTreeAssetName = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_FairyGUIAssetName(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.LuaHelper.FairyGUIAssetName = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_HotfixAssetName(RealStatePtr L)
        {
		    try {
                
			    DCET.Model.LuaHelper.HotfixAssetName = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
