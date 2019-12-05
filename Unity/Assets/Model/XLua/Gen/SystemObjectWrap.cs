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
using MongoDB.Bson;

namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class SystemObjectWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(object);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", _m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", _m_GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetType", _m_GetType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", _m_ToString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToBson", _m_ToBson);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToBsonDocument", _m_ToBsonDocument);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToJson", _m_ToJson);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 3, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Equals", _m_Equals_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReferenceEquals", _m_ReferenceEquals_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					object gen_ret = new object();
					translator.PushAny(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to object constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Equals(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                object gen_to_be_invoked = translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _obj = translator.GetObject(L, 2, typeof(object));
                    
                        bool gen_ret = gen_to_be_invoked.Equals( _obj );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Equals_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    object _objA = translator.GetObject(L, 1, typeof(object));
                    object _objB = translator.GetObject(L, 2, typeof(object));
                    
                        bool gen_ret = object.Equals( _objA, _objB );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHashCode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                object gen_to_be_invoked = translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int gen_ret = gen_to_be_invoked.GetHashCode(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                object gen_to_be_invoked = translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Type gen_ret = gen_to_be_invoked.GetType(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToString(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                object gen_to_be_invoked = translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string gen_ret = gen_to_be_invoked.ToString(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReferenceEquals_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    object _objA = translator.GetObject(L, 1, typeof(object));
                    object _objB = translator.GetObject(L, 2, typeof(object));
                    
                        bool gen_ret = object.ReferenceEquals( _objA, _objB );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToBson(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                object gen_to_be_invoked = translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 6&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<MongoDB.Bson.IO.BsonBinaryWriterSettings>(L, 3)&& translator.Assignable<MongoDB.Bson.Serialization.IBsonSerializer>(L, 4)&& translator.Assignable<System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder>>(L, 5)&& translator.Assignable<MongoDB.Bson.Serialization.BsonSerializationArgs>(L, 6)) 
                {
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    MongoDB.Bson.IO.BsonBinaryWriterSettings _writerSettings = (MongoDB.Bson.IO.BsonBinaryWriterSettings)translator.GetObject(L, 3, typeof(MongoDB.Bson.IO.BsonBinaryWriterSettings));
                    MongoDB.Bson.Serialization.IBsonSerializer _serializer = (MongoDB.Bson.Serialization.IBsonSerializer)translator.GetObject(L, 4, typeof(MongoDB.Bson.Serialization.IBsonSerializer));
                    System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder> _configurator = translator.GetDelegate<System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder>>(L, 5);
                    MongoDB.Bson.Serialization.BsonSerializationArgs _args;translator.Get(L, 6, out _args);
                    
                        byte[] gen_ret = gen_to_be_invoked.ToBson( _nominalType, _writerSettings, _serializer, _configurator, _args );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<MongoDB.Bson.IO.BsonBinaryWriterSettings>(L, 3)&& translator.Assignable<MongoDB.Bson.Serialization.IBsonSerializer>(L, 4)&& translator.Assignable<System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder>>(L, 5)) 
                {
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    MongoDB.Bson.IO.BsonBinaryWriterSettings _writerSettings = (MongoDB.Bson.IO.BsonBinaryWriterSettings)translator.GetObject(L, 3, typeof(MongoDB.Bson.IO.BsonBinaryWriterSettings));
                    MongoDB.Bson.Serialization.IBsonSerializer _serializer = (MongoDB.Bson.Serialization.IBsonSerializer)translator.GetObject(L, 4, typeof(MongoDB.Bson.Serialization.IBsonSerializer));
                    System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder> _configurator = translator.GetDelegate<System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder>>(L, 5);
                    
                        byte[] gen_ret = gen_to_be_invoked.ToBson( _nominalType, _writerSettings, _serializer, _configurator );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<MongoDB.Bson.IO.BsonBinaryWriterSettings>(L, 3)&& translator.Assignable<MongoDB.Bson.Serialization.IBsonSerializer>(L, 4)) 
                {
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    MongoDB.Bson.IO.BsonBinaryWriterSettings _writerSettings = (MongoDB.Bson.IO.BsonBinaryWriterSettings)translator.GetObject(L, 3, typeof(MongoDB.Bson.IO.BsonBinaryWriterSettings));
                    MongoDB.Bson.Serialization.IBsonSerializer _serializer = (MongoDB.Bson.Serialization.IBsonSerializer)translator.GetObject(L, 4, typeof(MongoDB.Bson.Serialization.IBsonSerializer));
                    
                        byte[] gen_ret = gen_to_be_invoked.ToBson( _nominalType, _writerSettings, _serializer );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<MongoDB.Bson.IO.BsonBinaryWriterSettings>(L, 3)) 
                {
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    MongoDB.Bson.IO.BsonBinaryWriterSettings _writerSettings = (MongoDB.Bson.IO.BsonBinaryWriterSettings)translator.GetObject(L, 3, typeof(MongoDB.Bson.IO.BsonBinaryWriterSettings));
                    
                        byte[] gen_ret = gen_to_be_invoked.ToBson( _nominalType, _writerSettings );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        byte[] gen_ret = gen_to_be_invoked.ToBson( _nominalType );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to object.ToBson!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToBsonDocument(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                object gen_to_be_invoked = translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<MongoDB.Bson.Serialization.IBsonSerializer>(L, 3)&& translator.Assignable<System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder>>(L, 4)&& translator.Assignable<MongoDB.Bson.Serialization.BsonSerializationArgs>(L, 5)) 
                {
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    MongoDB.Bson.Serialization.IBsonSerializer _serializer = (MongoDB.Bson.Serialization.IBsonSerializer)translator.GetObject(L, 3, typeof(MongoDB.Bson.Serialization.IBsonSerializer));
                    System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder> _configurator = translator.GetDelegate<System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder>>(L, 4);
                    MongoDB.Bson.Serialization.BsonSerializationArgs _args;translator.Get(L, 5, out _args);
                    
                        MongoDB.Bson.BsonDocument gen_ret = gen_to_be_invoked.ToBsonDocument( _nominalType, _serializer, _configurator, _args );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<MongoDB.Bson.Serialization.IBsonSerializer>(L, 3)&& translator.Assignable<System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder>>(L, 4)) 
                {
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    MongoDB.Bson.Serialization.IBsonSerializer _serializer = (MongoDB.Bson.Serialization.IBsonSerializer)translator.GetObject(L, 3, typeof(MongoDB.Bson.Serialization.IBsonSerializer));
                    System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder> _configurator = translator.GetDelegate<System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder>>(L, 4);
                    
                        MongoDB.Bson.BsonDocument gen_ret = gen_to_be_invoked.ToBsonDocument( _nominalType, _serializer, _configurator );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<MongoDB.Bson.Serialization.IBsonSerializer>(L, 3)) 
                {
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    MongoDB.Bson.Serialization.IBsonSerializer _serializer = (MongoDB.Bson.Serialization.IBsonSerializer)translator.GetObject(L, 3, typeof(MongoDB.Bson.Serialization.IBsonSerializer));
                    
                        MongoDB.Bson.BsonDocument gen_ret = gen_to_be_invoked.ToBsonDocument( _nominalType, _serializer );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        MongoDB.Bson.BsonDocument gen_ret = gen_to_be_invoked.ToBsonDocument( _nominalType );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to object.ToBsonDocument!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToJson(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                object gen_to_be_invoked = translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 6&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<MongoDB.Bson.IO.JsonWriterSettings>(L, 3)&& translator.Assignable<MongoDB.Bson.Serialization.IBsonSerializer>(L, 4)&& translator.Assignable<System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder>>(L, 5)&& translator.Assignable<MongoDB.Bson.Serialization.BsonSerializationArgs>(L, 6)) 
                {
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    MongoDB.Bson.IO.JsonWriterSettings _writerSettings = (MongoDB.Bson.IO.JsonWriterSettings)translator.GetObject(L, 3, typeof(MongoDB.Bson.IO.JsonWriterSettings));
                    MongoDB.Bson.Serialization.IBsonSerializer _serializer = (MongoDB.Bson.Serialization.IBsonSerializer)translator.GetObject(L, 4, typeof(MongoDB.Bson.Serialization.IBsonSerializer));
                    System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder> _configurator = translator.GetDelegate<System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder>>(L, 5);
                    MongoDB.Bson.Serialization.BsonSerializationArgs _args;translator.Get(L, 6, out _args);
                    
                        string gen_ret = gen_to_be_invoked.ToJson( _nominalType, _writerSettings, _serializer, _configurator, _args );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<MongoDB.Bson.IO.JsonWriterSettings>(L, 3)&& translator.Assignable<MongoDB.Bson.Serialization.IBsonSerializer>(L, 4)&& translator.Assignable<System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder>>(L, 5)) 
                {
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    MongoDB.Bson.IO.JsonWriterSettings _writerSettings = (MongoDB.Bson.IO.JsonWriterSettings)translator.GetObject(L, 3, typeof(MongoDB.Bson.IO.JsonWriterSettings));
                    MongoDB.Bson.Serialization.IBsonSerializer _serializer = (MongoDB.Bson.Serialization.IBsonSerializer)translator.GetObject(L, 4, typeof(MongoDB.Bson.Serialization.IBsonSerializer));
                    System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder> _configurator = translator.GetDelegate<System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder>>(L, 5);
                    
                        string gen_ret = gen_to_be_invoked.ToJson( _nominalType, _writerSettings, _serializer, _configurator );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<MongoDB.Bson.IO.JsonWriterSettings>(L, 3)&& translator.Assignable<MongoDB.Bson.Serialization.IBsonSerializer>(L, 4)) 
                {
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    MongoDB.Bson.IO.JsonWriterSettings _writerSettings = (MongoDB.Bson.IO.JsonWriterSettings)translator.GetObject(L, 3, typeof(MongoDB.Bson.IO.JsonWriterSettings));
                    MongoDB.Bson.Serialization.IBsonSerializer _serializer = (MongoDB.Bson.Serialization.IBsonSerializer)translator.GetObject(L, 4, typeof(MongoDB.Bson.Serialization.IBsonSerializer));
                    
                        string gen_ret = gen_to_be_invoked.ToJson( _nominalType, _writerSettings, _serializer );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<MongoDB.Bson.IO.JsonWriterSettings>(L, 3)) 
                {
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    MongoDB.Bson.IO.JsonWriterSettings _writerSettings = (MongoDB.Bson.IO.JsonWriterSettings)translator.GetObject(L, 3, typeof(MongoDB.Bson.IO.JsonWriterSettings));
                    
                        string gen_ret = gen_to_be_invoked.ToJson( _nominalType, _writerSettings );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        string gen_ret = gen_to_be_invoked.ToJson( _nominalType );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to object.ToJson!");
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
