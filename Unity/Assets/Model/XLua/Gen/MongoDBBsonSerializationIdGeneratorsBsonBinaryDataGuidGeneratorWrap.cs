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
    public class MongoDBBsonSerializationIdGeneratorsBsonBinaryDataGuidGeneratorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.Serialization.IdGenerators.BsonBinaryDataGuidGenerator);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GenerateId", _m_GenerateId);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsEmpty", _m_IsEmpty);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 5, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetInstance", _m_GetInstance_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "CSharpLegacyInstance", _g_get_CSharpLegacyInstance);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "JavaLegacyInstance", _g_get_JavaLegacyInstance);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "PythonLegacyInstance", _g_get_PythonLegacyInstance);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "StandardInstance", _g_get_StandardInstance);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "UnspecifedInstance", _g_get_UnspecifedInstance);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<MongoDB.Bson.GuidRepresentation>(L, 2))
				{
					MongoDB.Bson.GuidRepresentation _guidRepresentation;translator.Get(L, 2, out _guidRepresentation);
					
					MongoDB.Bson.Serialization.IdGenerators.BsonBinaryDataGuidGenerator gen_ret = new MongoDB.Bson.Serialization.IdGenerators.BsonBinaryDataGuidGenerator(_guidRepresentation);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.IdGenerators.BsonBinaryDataGuidGenerator constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInstance_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.GuidRepresentation _guidRepresentation;translator.Get(L, 1, out _guidRepresentation);
                    
                        MongoDB.Bson.Serialization.IdGenerators.BsonBinaryDataGuidGenerator gen_ret = MongoDB.Bson.Serialization.IdGenerators.BsonBinaryDataGuidGenerator.GetInstance( _guidRepresentation );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GenerateId(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.IdGenerators.BsonBinaryDataGuidGenerator gen_to_be_invoked = (MongoDB.Bson.Serialization.IdGenerators.BsonBinaryDataGuidGenerator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _container = translator.GetObject(L, 2, typeof(object));
                    object _document = translator.GetObject(L, 3, typeof(object));
                    
                        object gen_ret = gen_to_be_invoked.GenerateId( _container, _document );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsEmpty(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.IdGenerators.BsonBinaryDataGuidGenerator gen_to_be_invoked = (MongoDB.Bson.Serialization.IdGenerators.BsonBinaryDataGuidGenerator)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _id = translator.GetObject(L, 2, typeof(object));
                    
                        bool gen_ret = gen_to_be_invoked.IsEmpty( _id );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CSharpLegacyInstance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, MongoDB.Bson.Serialization.IdGenerators.BsonBinaryDataGuidGenerator.CSharpLegacyInstance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_JavaLegacyInstance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, MongoDB.Bson.Serialization.IdGenerators.BsonBinaryDataGuidGenerator.JavaLegacyInstance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_PythonLegacyInstance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, MongoDB.Bson.Serialization.IdGenerators.BsonBinaryDataGuidGenerator.PythonLegacyInstance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_StandardInstance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, MongoDB.Bson.Serialization.IdGenerators.BsonBinaryDataGuidGenerator.StandardInstance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UnspecifedInstance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, MongoDB.Bson.Serialization.IdGenerators.BsonBinaryDataGuidGenerator.UnspecifedInstance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
