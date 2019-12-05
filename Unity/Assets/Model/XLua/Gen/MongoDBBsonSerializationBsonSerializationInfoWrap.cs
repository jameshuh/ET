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
    public class MongoDBBsonSerializationBsonSerializationInfoWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.Serialization.BsonSerializationInfo);
			Utils.BeginObjectRegister(type, L, translator, 0, 5, 3, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DeserializeValue", _m_DeserializeValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Merge", _m_Merge);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SerializeValue", _m_SerializeValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SerializeValues", _m_SerializeValues);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WithNewName", _m_WithNewName);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ElementName", _g_get_ElementName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Serializer", _g_get_Serializer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "NominalType", _g_get_NominalType);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 4 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<MongoDB.Bson.Serialization.IBsonSerializer>(L, 3) && translator.Assignable<System.Type>(L, 4))
				{
					string _elementName = LuaAPI.lua_tostring(L, 2);
					MongoDB.Bson.Serialization.IBsonSerializer _serializer = (MongoDB.Bson.Serialization.IBsonSerializer)translator.GetObject(L, 3, typeof(MongoDB.Bson.Serialization.IBsonSerializer));
					System.Type _nominalType = (System.Type)translator.GetObject(L, 4, typeof(System.Type));
					
					MongoDB.Bson.Serialization.BsonSerializationInfo gen_ret = new MongoDB.Bson.Serialization.BsonSerializationInfo(_elementName, _serializer, _nominalType);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.BsonSerializationInfo constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DeserializeValue(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonSerializationInfo gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonSerializationInfo)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.BsonValue _value = (MongoDB.Bson.BsonValue)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonValue));
                    
                        object gen_ret = gen_to_be_invoked.DeserializeValue( _value );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Merge(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonSerializationInfo gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonSerializationInfo)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.Serialization.BsonSerializationInfo _newSerializationInfo = (MongoDB.Bson.Serialization.BsonSerializationInfo)translator.GetObject(L, 2, typeof(MongoDB.Bson.Serialization.BsonSerializationInfo));
                    
                        MongoDB.Bson.Serialization.BsonSerializationInfo gen_ret = gen_to_be_invoked.Merge( _newSerializationInfo );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SerializeValue(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonSerializationInfo gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonSerializationInfo)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _value = translator.GetObject(L, 2, typeof(object));
                    
                        MongoDB.Bson.BsonValue gen_ret = gen_to_be_invoked.SerializeValue( _value );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SerializeValues(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonSerializationInfo gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonSerializationInfo)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.IEnumerable _values = (System.Collections.IEnumerable)translator.GetObject(L, 2, typeof(System.Collections.IEnumerable));
                    
                        MongoDB.Bson.BsonArray gen_ret = gen_to_be_invoked.SerializeValues( _values );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WithNewName(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonSerializationInfo gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonSerializationInfo)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _elementName = LuaAPI.lua_tostring(L, 2);
                    
                        MongoDB.Bson.Serialization.BsonSerializationInfo gen_ret = gen_to_be_invoked.WithNewName( _elementName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ElementName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonSerializationInfo gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonSerializationInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.ElementName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Serializer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonSerializationInfo gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonSerializationInfo)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.Serializer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_NominalType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonSerializationInfo gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonSerializationInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.NominalType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
