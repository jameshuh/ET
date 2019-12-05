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
    public class DCETModelEntityFactoryWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DCET.Model.EntityFactory);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 4, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateWithParent", _m_CreateWithParent_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Create", _m_Create_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateScene", _m_CreateScene_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "DCET.Model.EntityFactory does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateWithParent_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    DCET.Model.Entity _parent = (DCET.Model.Entity)translator.GetObject(L, 2, typeof(DCET.Model.Entity));
                    
                        DCET.Model.Entity gen_ret = DCET.Model.EntityFactory.CreateWithParent( _type, _parent );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Create_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    DCET.Model.Entity _domain = (DCET.Model.Entity)translator.GetObject(L, 1, typeof(DCET.Model.Entity));
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        DCET.Model.Entity gen_ret = DCET.Model.EntityFactory.Create( _domain, _type );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateScene_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<DCET.Model.SceneType>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<DCET.Model.Scene>(L, 3)&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) || LuaAPI.lua_isint64(L, 4))) 
                {
                    DCET.Model.SceneType _sceneType;translator.Get(L, 1, out _sceneType);
                    string _name = LuaAPI.lua_tostring(L, 2);
                    DCET.Model.Scene _parent = (DCET.Model.Scene)translator.GetObject(L, 3, typeof(DCET.Model.Scene));
                    long _id = LuaAPI.lua_toint64(L, 4);
                    
                        DCET.Model.Scene gen_ret = DCET.Model.EntityFactory.CreateScene( _sceneType, _name, _parent, _id );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<DCET.Model.SceneType>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<DCET.Model.Scene>(L, 3)) 
                {
                    DCET.Model.SceneType _sceneType;translator.Get(L, 1, out _sceneType);
                    string _name = LuaAPI.lua_tostring(L, 2);
                    DCET.Model.Scene _parent = (DCET.Model.Scene)translator.GetObject(L, 3, typeof(DCET.Model.Scene));
                    
                        DCET.Model.Scene gen_ret = DCET.Model.EntityFactory.CreateScene( _sceneType, _name, _parent );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<DCET.Model.SceneType>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    DCET.Model.SceneType _sceneType;translator.Get(L, 1, out _sceneType);
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        DCET.Model.Scene gen_ret = DCET.Model.EntityFactory.CreateScene( _sceneType, _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to DCET.Model.EntityFactory.CreateScene!");
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
