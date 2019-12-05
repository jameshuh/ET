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
    public class MongoDBBsonBsonDefaultsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.BsonDefaults);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 5, 5);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "DynamicArraySerializer", _g_get_DynamicArraySerializer);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "DynamicDocumentSerializer", _g_get_DynamicDocumentSerializer);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "GuidRepresentation", _g_get_GuidRepresentation);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MaxDocumentSize", _g_get_MaxDocumentSize);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MaxSerializationDepth", _g_get_MaxSerializationDepth);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "DynamicArraySerializer", _s_set_DynamicArraySerializer);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "DynamicDocumentSerializer", _s_set_DynamicDocumentSerializer);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "GuidRepresentation", _s_set_GuidRepresentation);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "MaxDocumentSize", _s_set_MaxDocumentSize);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "MaxSerializationDepth", _s_set_MaxSerializationDepth);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "MongoDB.Bson.BsonDefaults does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DynamicArraySerializer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushAny(L, MongoDB.Bson.BsonDefaults.DynamicArraySerializer);
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
			    translator.PushAny(L, MongoDB.Bson.BsonDefaults.DynamicDocumentSerializer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GuidRepresentation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushMongoDBBsonGuidRepresentation(L, MongoDB.Bson.BsonDefaults.GuidRepresentation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MaxDocumentSize(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, MongoDB.Bson.BsonDefaults.MaxDocumentSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MaxSerializationDepth(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, MongoDB.Bson.BsonDefaults.MaxSerializationDepth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DynamicArraySerializer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    MongoDB.Bson.BsonDefaults.DynamicArraySerializer = (MongoDB.Bson.Serialization.IBsonSerializer)translator.GetObject(L, 1, typeof(MongoDB.Bson.Serialization.IBsonSerializer));
            
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
			    MongoDB.Bson.BsonDefaults.DynamicDocumentSerializer = (MongoDB.Bson.Serialization.IBsonSerializer)translator.GetObject(L, 1, typeof(MongoDB.Bson.Serialization.IBsonSerializer));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_GuidRepresentation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			MongoDB.Bson.GuidRepresentation gen_value;translator.Get(L, 1, out gen_value);
				MongoDB.Bson.BsonDefaults.GuidRepresentation = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MaxDocumentSize(RealStatePtr L)
        {
		    try {
                
			    MongoDB.Bson.BsonDefaults.MaxDocumentSize = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MaxSerializationDepth(RealStatePtr L)
        {
		    try {
                
			    MongoDB.Bson.BsonDefaults.MaxSerializationDepth = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
