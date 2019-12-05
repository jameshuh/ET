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
    public class DCETModelAssetBundleHelperWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DCET.Model.AssetBundleHelper);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 7, 1, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetDependencies", _m_GetDependencies_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSortedDependencies", _m_GetSortedDependencies_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CollectDependencies", _m_CollectDependencies_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IntToStringDict", DCET.Model.AssetBundleHelper.IntToStringDict);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "StringToABDict", DCET.Model.AssetBundleHelper.StringToABDict);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BundleNameToLowerDict", DCET.Model.AssetBundleHelper.BundleNameToLowerDict);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "DependenciesCache", _g_get_DependenciesCache);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "DependenciesCache", _s_set_DependenciesCache);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "DCET.Model.AssetBundleHelper does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDependencies_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _assetBundleName = LuaAPI.lua_tostring(L, 1);
                    
                        string[] gen_ret = DCET.Model.AssetBundleHelper.GetDependencies( _assetBundleName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSortedDependencies_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _assetBundleName = LuaAPI.lua_tostring(L, 1);
                    
                        string[] gen_ret = DCET.Model.AssetBundleHelper.GetSortedDependencies( _assetBundleName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CollectDependencies_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Collections.Generic.List<string> _parents = (System.Collections.Generic.List<string>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<string>));
                    string _assetBundleName = LuaAPI.lua_tostring(L, 2);
                    System.Collections.Generic.Dictionary<string, int> _info = (System.Collections.Generic.Dictionary<string, int>)translator.GetObject(L, 3, typeof(System.Collections.Generic.Dictionary<string, int>));
                    
                    DCET.Model.AssetBundleHelper.CollectDependencies( _parents, _assetBundleName, _info );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DependenciesCache(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, DCET.Model.AssetBundleHelper.DependenciesCache);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DependenciesCache(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    DCET.Model.AssetBundleHelper.DependenciesCache = (System.Collections.Generic.Dictionary<string, string[]>)translator.GetObject(L, 1, typeof(System.Collections.Generic.Dictionary<string, string[]>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
