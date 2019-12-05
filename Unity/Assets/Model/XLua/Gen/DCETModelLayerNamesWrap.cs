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
    public class DCETModelLayerNamesWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DCET.Model.LayerNames);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 8, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetLayerInt", _m_GetLayerInt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetLayerStr", _m_GetLayerStr_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UI", DCET.Model.LayerNames.UI);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UNIT", DCET.Model.LayerNames.UNIT);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MAP", DCET.Model.LayerNames.MAP);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DEFAULT", DCET.Model.LayerNames.DEFAULT);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HIDDEN", DCET.Model.LayerNames.HIDDEN);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "DCET.Model.LayerNames does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLayerInt_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    
                        int gen_ret = DCET.Model.LayerNames.GetLayerInt( _name );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLayerStr_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _name = LuaAPI.xlua_tointeger(L, 1);
                    
                        string gen_ret = DCET.Model.LayerNames.GetLayerStr( _name );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
