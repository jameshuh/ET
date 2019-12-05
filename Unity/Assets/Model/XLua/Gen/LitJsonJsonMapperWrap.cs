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
    public class LitJsonJsonMapperWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(LitJson.JsonMapper);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 6, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "ToJson", _m_ToJson_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToObject", _m_ToObject_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToWrapper", _m_ToWrapper_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UnregisterExporters", _m_UnregisterExporters_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UnregisterImporters", _m_UnregisterImporters_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					LitJson.JsonMapper gen_ret = new LitJson.JsonMapper();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to LitJson.JsonMapper constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToJson_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<object>(L, 1)) 
                {
                    object _obj = translator.GetObject(L, 1, typeof(object));
                    
                        string gen_ret = LitJson.JsonMapper.ToJson( _obj );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<object>(L, 1)&& translator.Assignable<LitJson.JsonWriter>(L, 2)) 
                {
                    object _obj = translator.GetObject(L, 1, typeof(object));
                    LitJson.JsonWriter _writer = (LitJson.JsonWriter)translator.GetObject(L, 2, typeof(LitJson.JsonWriter));
                    
                    LitJson.JsonMapper.ToJson( _obj, _writer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LitJson.JsonMapper.ToJson!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToObject_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<LitJson.JsonReader>(L, 1)) 
                {
                    LitJson.JsonReader _reader = (LitJson.JsonReader)translator.GetObject(L, 1, typeof(LitJson.JsonReader));
                    
                        LitJson.JsonData gen_ret = LitJson.JsonMapper.ToObject( _reader );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<System.IO.TextReader>(L, 1)) 
                {
                    System.IO.TextReader _reader = (System.IO.TextReader)translator.GetObject(L, 1, typeof(System.IO.TextReader));
                    
                        LitJson.JsonData gen_ret = LitJson.JsonMapper.ToObject( _reader );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _json = LuaAPI.lua_tostring(L, 1);
                    
                        LitJson.JsonData gen_ret = LitJson.JsonMapper.ToObject( _json );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Type>(L, 2)) 
                {
                    string _json = LuaAPI.lua_tostring(L, 1);
                    System.Type _ConvertType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        object gen_ret = LitJson.JsonMapper.ToObject( _json, _ConvertType );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LitJson.JsonMapper.ToObject!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToWrapper_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<LitJson.WrapperFactory>(L, 1)&& translator.Assignable<LitJson.JsonReader>(L, 2)) 
                {
                    LitJson.WrapperFactory _factory = translator.GetDelegate<LitJson.WrapperFactory>(L, 1);
                    LitJson.JsonReader _reader = (LitJson.JsonReader)translator.GetObject(L, 2, typeof(LitJson.JsonReader));
                    
                        LitJson.IJsonWrapper gen_ret = LitJson.JsonMapper.ToWrapper( _factory, _reader );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<LitJson.WrapperFactory>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    LitJson.WrapperFactory _factory = translator.GetDelegate<LitJson.WrapperFactory>(L, 1);
                    string _json = LuaAPI.lua_tostring(L, 2);
                    
                        LitJson.IJsonWrapper gen_ret = LitJson.JsonMapper.ToWrapper( _factory, _json );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LitJson.JsonMapper.ToWrapper!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnregisterExporters_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    LitJson.JsonMapper.UnregisterExporters(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnregisterImporters_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    LitJson.JsonMapper.UnregisterImporters(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
