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
    public class MongoDBBsonBsonTypeMapperOptionsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.BsonTypeMapperOptions);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 5, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clone", _m_Clone);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Freeze", _m_Freeze);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "DuplicateNameHandling", _g_get_DuplicateNameHandling);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsFrozen", _g_get_IsFrozen);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MapBsonArrayTo", _g_get_MapBsonArrayTo);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MapBsonDocumentTo", _g_get_MapBsonDocumentTo);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MapOldBinaryToByteArray", _g_get_MapOldBinaryToByteArray);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "DuplicateNameHandling", _s_set_DuplicateNameHandling);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "MapBsonArrayTo", _s_set_MapBsonArrayTo);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "MapBsonDocumentTo", _s_set_MapBsonDocumentTo);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "MapOldBinaryToByteArray", _s_set_MapOldBinaryToByteArray);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 1);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Defaults", _g_get_Defaults);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Defaults", _s_set_Defaults);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					MongoDB.Bson.BsonTypeMapperOptions gen_ret = new MongoDB.Bson.BsonTypeMapperOptions();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.BsonTypeMapperOptions constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clone(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonTypeMapperOptions gen_to_be_invoked = (MongoDB.Bson.BsonTypeMapperOptions)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        MongoDB.Bson.BsonTypeMapperOptions gen_ret = gen_to_be_invoked.Clone(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Freeze(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonTypeMapperOptions gen_to_be_invoked = (MongoDB.Bson.BsonTypeMapperOptions)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        MongoDB.Bson.BsonTypeMapperOptions gen_ret = gen_to_be_invoked.Freeze(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Defaults(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, MongoDB.Bson.BsonTypeMapperOptions.Defaults);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DuplicateNameHandling(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonTypeMapperOptions gen_to_be_invoked = (MongoDB.Bson.BsonTypeMapperOptions)translator.FastGetCSObj(L, 1);
                translator.PushMongoDBBsonDuplicateNameHandling(L, gen_to_be_invoked.DuplicateNameHandling);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsFrozen(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonTypeMapperOptions gen_to_be_invoked = (MongoDB.Bson.BsonTypeMapperOptions)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsFrozen);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MapBsonArrayTo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonTypeMapperOptions gen_to_be_invoked = (MongoDB.Bson.BsonTypeMapperOptions)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.MapBsonArrayTo);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MapBsonDocumentTo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonTypeMapperOptions gen_to_be_invoked = (MongoDB.Bson.BsonTypeMapperOptions)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.MapBsonDocumentTo);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MapOldBinaryToByteArray(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonTypeMapperOptions gen_to_be_invoked = (MongoDB.Bson.BsonTypeMapperOptions)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.MapOldBinaryToByteArray);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Defaults(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    MongoDB.Bson.BsonTypeMapperOptions.Defaults = (MongoDB.Bson.BsonTypeMapperOptions)translator.GetObject(L, 1, typeof(MongoDB.Bson.BsonTypeMapperOptions));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DuplicateNameHandling(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonTypeMapperOptions gen_to_be_invoked = (MongoDB.Bson.BsonTypeMapperOptions)translator.FastGetCSObj(L, 1);
                MongoDB.Bson.DuplicateNameHandling gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.DuplicateNameHandling = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MapBsonArrayTo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonTypeMapperOptions gen_to_be_invoked = (MongoDB.Bson.BsonTypeMapperOptions)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.MapBsonArrayTo = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MapBsonDocumentTo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonTypeMapperOptions gen_to_be_invoked = (MongoDB.Bson.BsonTypeMapperOptions)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.MapBsonDocumentTo = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MapOldBinaryToByteArray(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonTypeMapperOptions gen_to_be_invoked = (MongoDB.Bson.BsonTypeMapperOptions)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.MapOldBinaryToByteArray = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
