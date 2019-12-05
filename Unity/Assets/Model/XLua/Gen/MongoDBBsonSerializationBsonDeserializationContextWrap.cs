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
    public class MongoDBBsonSerializationBsonDeserializationContextWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.Serialization.BsonDeserializationContext);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 4, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "With", _m_With);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "AllowDuplicateElementNames", _g_get_AllowDuplicateElementNames);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DynamicArraySerializer", _g_get_DynamicArraySerializer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DynamicDocumentSerializer", _g_get_DynamicDocumentSerializer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Reader", _g_get_Reader);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateRoot", _m_CreateRoot_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "MongoDB.Bson.Serialization.BsonDeserializationContext does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateRoot_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<MongoDB.Bson.IO.IBsonReader>(L, 1)&& translator.Assignable<System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder>>(L, 2)) 
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder> _configurator = translator.GetDelegate<System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder>>(L, 2);
                    
                        MongoDB.Bson.Serialization.BsonDeserializationContext gen_ret = MongoDB.Bson.Serialization.BsonDeserializationContext.CreateRoot( _reader, _configurator );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<MongoDB.Bson.IO.IBsonReader>(L, 1)) 
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    
                        MongoDB.Bson.Serialization.BsonDeserializationContext gen_ret = MongoDB.Bson.Serialization.BsonDeserializationContext.CreateRoot( _reader );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.BsonDeserializationContext.CreateRoot!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_With(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonDeserializationContext gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonDeserializationContext)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder>>(L, 2)) 
                {
                    System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder> _configurator = translator.GetDelegate<System.Action<MongoDB.Bson.Serialization.BsonDeserializationContext.Builder>>(L, 2);
                    
                        MongoDB.Bson.Serialization.BsonDeserializationContext gen_ret = gen_to_be_invoked.With( _configurator );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1) 
                {
                    
                        MongoDB.Bson.Serialization.BsonDeserializationContext gen_ret = gen_to_be_invoked.With(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.BsonDeserializationContext.With!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AllowDuplicateElementNames(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonDeserializationContext gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonDeserializationContext)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.AllowDuplicateElementNames);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DynamicArraySerializer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonDeserializationContext gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonDeserializationContext)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.DynamicArraySerializer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DynamicDocumentSerializer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonDeserializationContext gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonDeserializationContext)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.DynamicDocumentSerializer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Reader(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonDeserializationContext gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonDeserializationContext)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.Reader);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
