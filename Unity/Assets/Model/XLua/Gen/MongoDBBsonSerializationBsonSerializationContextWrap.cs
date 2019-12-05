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
    public class MongoDBBsonSerializationBsonSerializationContextWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.Serialization.BsonSerializationContext);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 2, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "With", _m_With);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsDynamicType", _g_get_IsDynamicType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Writer", _g_get_Writer);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateRoot", _m_CreateRoot_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "MongoDB.Bson.Serialization.BsonSerializationContext does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateRoot_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<MongoDB.Bson.IO.IBsonWriter>(L, 1)&& translator.Assignable<System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder>>(L, 2)) 
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder> _configurator = translator.GetDelegate<System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder>>(L, 2);
                    
                        MongoDB.Bson.Serialization.BsonSerializationContext gen_ret = MongoDB.Bson.Serialization.BsonSerializationContext.CreateRoot( _writer, _configurator );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<MongoDB.Bson.IO.IBsonWriter>(L, 1)) 
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    
                        MongoDB.Bson.Serialization.BsonSerializationContext gen_ret = MongoDB.Bson.Serialization.BsonSerializationContext.CreateRoot( _writer );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.BsonSerializationContext.CreateRoot!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_With(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonSerializationContext gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonSerializationContext)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder>>(L, 2)) 
                {
                    System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder> _configurator = translator.GetDelegate<System.Action<MongoDB.Bson.Serialization.BsonSerializationContext.Builder>>(L, 2);
                    
                        MongoDB.Bson.Serialization.BsonSerializationContext gen_ret = gen_to_be_invoked.With( _configurator );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1) 
                {
                    
                        MongoDB.Bson.Serialization.BsonSerializationContext gen_ret = gen_to_be_invoked.With(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.BsonSerializationContext.With!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsDynamicType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonSerializationContext gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonSerializationContext)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.IsDynamicType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Writer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonSerializationContext gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonSerializationContext)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.Writer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
