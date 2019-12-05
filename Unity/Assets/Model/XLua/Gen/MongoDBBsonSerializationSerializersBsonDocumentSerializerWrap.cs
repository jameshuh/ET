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
    public class MongoDBBsonSerializationSerializersBsonDocumentSerializerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.Serialization.Serializers.BsonDocumentSerializer);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDocumentId", _m_GetDocumentId);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetMemberSerializationInfo", _m_TryGetMemberSerializationInfo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDocumentId", _m_SetDocumentId);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 0);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Instance", _g_get_Instance);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					MongoDB.Bson.Serialization.Serializers.BsonDocumentSerializer gen_ret = new MongoDB.Bson.Serialization.Serializers.BsonDocumentSerializer();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.Serializers.BsonDocumentSerializer constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDocumentId(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Serializers.BsonDocumentSerializer gen_to_be_invoked = (MongoDB.Bson.Serialization.Serializers.BsonDocumentSerializer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _document = translator.GetObject(L, 2, typeof(object));
                    object _id;
                    System.Type _idNominalType;
                    MongoDB.Bson.Serialization.IIdGenerator _idGenerator;
                    
                        bool gen_ret = gen_to_be_invoked.GetDocumentId( _document, out _id, out _idNominalType, out _idGenerator );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.PushAny(L, _id);
                        
                    translator.Push(L, _idNominalType);
                        
                    translator.PushAny(L, _idGenerator);
                        
                    
                    
                    
                    return 4;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetMemberSerializationInfo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Serializers.BsonDocumentSerializer gen_to_be_invoked = (MongoDB.Bson.Serialization.Serializers.BsonDocumentSerializer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _memberName = LuaAPI.lua_tostring(L, 2);
                    MongoDB.Bson.Serialization.BsonSerializationInfo _serializationInfo;
                    
                        bool gen_ret = gen_to_be_invoked.TryGetMemberSerializationInfo( _memberName, out _serializationInfo );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _serializationInfo);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDocumentId(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Serializers.BsonDocumentSerializer gen_to_be_invoked = (MongoDB.Bson.Serialization.Serializers.BsonDocumentSerializer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _document = translator.GetObject(L, 2, typeof(object));
                    object _id = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.SetDocumentId( _document, _id );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, MongoDB.Bson.Serialization.Serializers.BsonDocumentSerializer.Instance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
