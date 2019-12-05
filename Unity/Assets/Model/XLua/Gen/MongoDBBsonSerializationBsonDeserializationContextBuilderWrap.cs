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
    public class MongoDBBsonSerializationBsonDeserializationContextBuilderWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.Serialization.BsonDeserializationContext.Builder);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 4, 3);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "AllowDuplicateElementNames", _g_get_AllowDuplicateElementNames);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DynamicArraySerializer", _g_get_DynamicArraySerializer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DynamicDocumentSerializer", _g_get_DynamicDocumentSerializer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Reader", _g_get_Reader);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "AllowDuplicateElementNames", _s_set_AllowDuplicateElementNames);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "DynamicArraySerializer", _s_set_DynamicArraySerializer);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "DynamicDocumentSerializer", _s_set_DynamicDocumentSerializer);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "MongoDB.Bson.Serialization.BsonDeserializationContext.Builder does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AllowDuplicateElementNames(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonDeserializationContext.Builder gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonDeserializationContext.Builder)translator.FastGetCSObj(L, 1);
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
			
                MongoDB.Bson.Serialization.BsonDeserializationContext.Builder gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonDeserializationContext.Builder)translator.FastGetCSObj(L, 1);
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
			
                MongoDB.Bson.Serialization.BsonDeserializationContext.Builder gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonDeserializationContext.Builder)translator.FastGetCSObj(L, 1);
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
			
                MongoDB.Bson.Serialization.BsonDeserializationContext.Builder gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonDeserializationContext.Builder)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.Reader);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AllowDuplicateElementNames(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonDeserializationContext.Builder gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonDeserializationContext.Builder)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.AllowDuplicateElementNames = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DynamicArraySerializer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonDeserializationContext.Builder gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonDeserializationContext.Builder)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.DynamicArraySerializer = (MongoDB.Bson.Serialization.IBsonSerializer)translator.GetObject(L, 2, typeof(MongoDB.Bson.Serialization.IBsonSerializer));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DynamicDocumentSerializer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonDeserializationContext.Builder gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonDeserializationContext.Builder)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.DynamicDocumentSerializer = (MongoDB.Bson.Serialization.IBsonSerializer)translator.GetObject(L, 2, typeof(MongoDB.Bson.Serialization.IBsonSerializer));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
