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
    public class MongoDBBsonSerializationSerializersDateTimeSerializerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.Serialization.Serializers.DateTimeSerializer);
			Utils.BeginObjectRegister(type, L, translator, 0, 5, 3, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Deserialize", _m_Deserialize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Serialize", _m_Serialize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WithDateOnly", _m_WithDateOnly);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WithKind", _m_WithKind);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WithRepresentation", _m_WithRepresentation);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "DateOnly", _g_get_DateOnly);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Kind", _g_get_Kind);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Representation", _g_get_Representation);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 3, 0);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "DateOnlyInstance", _g_get_DateOnlyInstance);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "LocalInstance", _g_get_LocalInstance);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "UtcInstance", _g_get_UtcInstance);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					MongoDB.Bson.Serialization.Serializers.DateTimeSerializer gen_ret = new MongoDB.Bson.Serialization.Serializers.DateTimeSerializer();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2))
				{
					bool _dateOnly = LuaAPI.lua_toboolean(L, 2);
					
					MongoDB.Bson.Serialization.Serializers.DateTimeSerializer gen_ret = new MongoDB.Bson.Serialization.Serializers.DateTimeSerializer(_dateOnly);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2) && translator.Assignable<MongoDB.Bson.BsonType>(L, 3))
				{
					bool _dateOnly = LuaAPI.lua_toboolean(L, 2);
					MongoDB.Bson.BsonType _representation;translator.Get(L, 3, out _representation);
					
					MongoDB.Bson.Serialization.Serializers.DateTimeSerializer gen_ret = new MongoDB.Bson.Serialization.Serializers.DateTimeSerializer(_dateOnly, _representation);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<MongoDB.Bson.BsonType>(L, 2))
				{
					MongoDB.Bson.BsonType _representation;translator.Get(L, 2, out _representation);
					
					MongoDB.Bson.Serialization.Serializers.DateTimeSerializer gen_ret = new MongoDB.Bson.Serialization.Serializers.DateTimeSerializer(_representation);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.DateTimeKind>(L, 2))
				{
					System.DateTimeKind _kind;translator.Get(L, 2, out _kind);
					
					MongoDB.Bson.Serialization.Serializers.DateTimeSerializer gen_ret = new MongoDB.Bson.Serialization.Serializers.DateTimeSerializer(_kind);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<System.DateTimeKind>(L, 2) && translator.Assignable<MongoDB.Bson.BsonType>(L, 3))
				{
					System.DateTimeKind _kind;translator.Get(L, 2, out _kind);
					MongoDB.Bson.BsonType _representation;translator.Get(L, 3, out _representation);
					
					MongoDB.Bson.Serialization.Serializers.DateTimeSerializer gen_ret = new MongoDB.Bson.Serialization.Serializers.DateTimeSerializer(_kind, _representation);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.Serializers.DateTimeSerializer constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Deserialize(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Serializers.DateTimeSerializer gen_to_be_invoked = (MongoDB.Bson.Serialization.Serializers.DateTimeSerializer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.Serialization.BsonDeserializationContext _context = (MongoDB.Bson.Serialization.BsonDeserializationContext)translator.GetObject(L, 2, typeof(MongoDB.Bson.Serialization.BsonDeserializationContext));
                    MongoDB.Bson.Serialization.BsonDeserializationArgs _args;translator.Get(L, 3, out _args);
                    
                        System.DateTime gen_ret = gen_to_be_invoked.Deserialize( _context, _args );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Serialize(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Serializers.DateTimeSerializer gen_to_be_invoked = (MongoDB.Bson.Serialization.Serializers.DateTimeSerializer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.Serialization.BsonSerializationContext _context = (MongoDB.Bson.Serialization.BsonSerializationContext)translator.GetObject(L, 2, typeof(MongoDB.Bson.Serialization.BsonSerializationContext));
                    MongoDB.Bson.Serialization.BsonSerializationArgs _args;translator.Get(L, 3, out _args);
                    System.DateTime _value;translator.Get(L, 4, out _value);
                    
                    gen_to_be_invoked.Serialize( _context, _args, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WithDateOnly(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Serializers.DateTimeSerializer gen_to_be_invoked = (MongoDB.Bson.Serialization.Serializers.DateTimeSerializer)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool _dateOnly = LuaAPI.lua_toboolean(L, 2);
                    
                        MongoDB.Bson.Serialization.Serializers.DateTimeSerializer gen_ret = gen_to_be_invoked.WithDateOnly( _dateOnly );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& translator.Assignable<MongoDB.Bson.BsonType>(L, 3)) 
                {
                    bool _dateOnly = LuaAPI.lua_toboolean(L, 2);
                    MongoDB.Bson.BsonType _representation;translator.Get(L, 3, out _representation);
                    
                        MongoDB.Bson.Serialization.Serializers.DateTimeSerializer gen_ret = gen_to_be_invoked.WithDateOnly( _dateOnly, _representation );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.Serializers.DateTimeSerializer.WithDateOnly!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WithKind(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Serializers.DateTimeSerializer gen_to_be_invoked = (MongoDB.Bson.Serialization.Serializers.DateTimeSerializer)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.DateTimeKind>(L, 2)) 
                {
                    System.DateTimeKind _kind;translator.Get(L, 2, out _kind);
                    
                        MongoDB.Bson.Serialization.Serializers.DateTimeSerializer gen_ret = gen_to_be_invoked.WithKind( _kind );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.DateTimeKind>(L, 2)&& translator.Assignable<MongoDB.Bson.BsonType>(L, 3)) 
                {
                    System.DateTimeKind _kind;translator.Get(L, 2, out _kind);
                    MongoDB.Bson.BsonType _representation;translator.Get(L, 3, out _representation);
                    
                        MongoDB.Bson.Serialization.Serializers.DateTimeSerializer gen_ret = gen_to_be_invoked.WithKind( _kind, _representation );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.Serializers.DateTimeSerializer.WithKind!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WithRepresentation(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Serializers.DateTimeSerializer gen_to_be_invoked = (MongoDB.Bson.Serialization.Serializers.DateTimeSerializer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.BsonType _representation;translator.Get(L, 2, out _representation);
                    
                        MongoDB.Bson.Serialization.Serializers.DateTimeSerializer gen_ret = gen_to_be_invoked.WithRepresentation( _representation );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DateOnlyInstance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, MongoDB.Bson.Serialization.Serializers.DateTimeSerializer.DateOnlyInstance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LocalInstance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, MongoDB.Bson.Serialization.Serializers.DateTimeSerializer.LocalInstance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UtcInstance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, MongoDB.Bson.Serialization.Serializers.DateTimeSerializer.UtcInstance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DateOnly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.Serializers.DateTimeSerializer gen_to_be_invoked = (MongoDB.Bson.Serialization.Serializers.DateTimeSerializer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.DateOnly);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Kind(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.Serializers.DateTimeSerializer gen_to_be_invoked = (MongoDB.Bson.Serialization.Serializers.DateTimeSerializer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Kind);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Representation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.Serializers.DateTimeSerializer gen_to_be_invoked = (MongoDB.Bson.Serialization.Serializers.DateTimeSerializer)translator.FastGetCSObj(L, 1);
                translator.PushMongoDBBsonBsonType(L, gen_to_be_invoked.Representation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
