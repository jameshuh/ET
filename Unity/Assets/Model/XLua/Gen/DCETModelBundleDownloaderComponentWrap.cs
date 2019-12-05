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
    public class DCETModelBundleDownloaderComponentWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DCET.Model.BundleDownloaderComponent);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 6, 5);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StartAsync", _m_StartAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DownloadAsync", _m_DownloadAsync);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Progress", _g_get_Progress);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bundles", _g_get_bundles);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "TotalSize", _g_get_TotalSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "downloadedBundles", _g_get_downloadedBundles);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "downloadingBundle", _g_get_downloadingBundle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "webRequest", _g_get_webRequest);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "bundles", _s_set_bundles);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "TotalSize", _s_set_TotalSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "downloadedBundles", _s_set_downloadedBundles);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "downloadingBundle", _s_set_downloadingBundle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "webRequest", _s_set_webRequest);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetBundleMD5", _m_GetBundleMD5_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					DCET.Model.BundleDownloaderComponent gen_ret = new DCET.Model.BundleDownloaderComponent();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to DCET.Model.BundleDownloaderComponent constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.BundleDownloaderComponent gen_to_be_invoked = (DCET.Model.BundleDownloaderComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StartAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.BundleDownloaderComponent gen_to_be_invoked = (DCET.Model.BundleDownloaderComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        DCET.Model.ETTask gen_ret = gen_to_be_invoked.StartAsync(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBundleMD5_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    DCET.Model.VersionConfig _streamingVersionConfig = (DCET.Model.VersionConfig)translator.GetObject(L, 1, typeof(DCET.Model.VersionConfig));
                    string _bundleName = LuaAPI.lua_tostring(L, 2);
                    
                        string gen_ret = DCET.Model.BundleDownloaderComponent.GetBundleMD5( _streamingVersionConfig, _bundleName );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DownloadAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.BundleDownloaderComponent gen_to_be_invoked = (DCET.Model.BundleDownloaderComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        DCET.Model.ETTask gen_ret = gen_to_be_invoked.DownloadAsync(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Progress(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.BundleDownloaderComponent gen_to_be_invoked = (DCET.Model.BundleDownloaderComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Progress);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bundles(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.BundleDownloaderComponent gen_to_be_invoked = (DCET.Model.BundleDownloaderComponent)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.bundles);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_TotalSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.BundleDownloaderComponent gen_to_be_invoked = (DCET.Model.BundleDownloaderComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushint64(L, gen_to_be_invoked.TotalSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_downloadedBundles(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.BundleDownloaderComponent gen_to_be_invoked = (DCET.Model.BundleDownloaderComponent)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.downloadedBundles);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_downloadingBundle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.BundleDownloaderComponent gen_to_be_invoked = (DCET.Model.BundleDownloaderComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.downloadingBundle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_webRequest(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.BundleDownloaderComponent gen_to_be_invoked = (DCET.Model.BundleDownloaderComponent)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.webRequest);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bundles(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.BundleDownloaderComponent gen_to_be_invoked = (DCET.Model.BundleDownloaderComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.bundles = (System.Collections.Generic.Queue<string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Queue<string>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_TotalSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.BundleDownloaderComponent gen_to_be_invoked = (DCET.Model.BundleDownloaderComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.TotalSize = LuaAPI.lua_toint64(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_downloadedBundles(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.BundleDownloaderComponent gen_to_be_invoked = (DCET.Model.BundleDownloaderComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.downloadedBundles = (System.Collections.Generic.HashSet<string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.HashSet<string>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_downloadingBundle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.BundleDownloaderComponent gen_to_be_invoked = (DCET.Model.BundleDownloaderComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.downloadingBundle = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_webRequest(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.BundleDownloaderComponent gen_to_be_invoked = (DCET.Model.BundleDownloaderComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.webRequest = (DCET.Model.UnityWebRequestAsync)translator.GetObject(L, 2, typeof(DCET.Model.UnityWebRequestAsync));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
