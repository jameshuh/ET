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
    public class MongoDBBsonBsonTypeMapperWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.BsonTypeMapper);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 5, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "MapToBsonValue", _m_MapToBsonValue_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MapToDotNetValue", _m_MapToDotNetValue_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RegisterCustomTypeMapper", _m_RegisterCustomTypeMapper_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TryMapToBsonValue", _m_TryMapToBsonValue_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "MongoDB.Bson.BsonTypeMapper does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MapToBsonValue_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<object>(L, 1)) 
                {
                    object _value = translator.GetObject(L, 1, typeof(object));
                    
                        MongoDB.Bson.BsonValue gen_ret = MongoDB.Bson.BsonTypeMapper.MapToBsonValue( _value );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<object>(L, 1)&& translator.Assignable<MongoDB.Bson.BsonType>(L, 2)) 
                {
                    object _value = translator.GetObject(L, 1, typeof(object));
                    MongoDB.Bson.BsonType _bsonType;translator.Get(L, 2, out _bsonType);
                    
                        MongoDB.Bson.BsonValue gen_ret = MongoDB.Bson.BsonTypeMapper.MapToBsonValue( _value, _bsonType );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.BsonTypeMapper.MapToBsonValue!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MapToDotNetValue_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<MongoDB.Bson.BsonValue>(L, 1)) 
                {
                    MongoDB.Bson.BsonValue _bsonValue = (MongoDB.Bson.BsonValue)translator.GetObject(L, 1, typeof(MongoDB.Bson.BsonValue));
                    
                        object gen_ret = MongoDB.Bson.BsonTypeMapper.MapToDotNetValue( _bsonValue );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<MongoDB.Bson.BsonValue>(L, 1)&& translator.Assignable<MongoDB.Bson.BsonTypeMapperOptions>(L, 2)) 
                {
                    MongoDB.Bson.BsonValue _bsonValue = (MongoDB.Bson.BsonValue)translator.GetObject(L, 1, typeof(MongoDB.Bson.BsonValue));
                    MongoDB.Bson.BsonTypeMapperOptions _options = (MongoDB.Bson.BsonTypeMapperOptions)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonTypeMapperOptions));
                    
                        object gen_ret = MongoDB.Bson.BsonTypeMapper.MapToDotNetValue( _bsonValue, _options );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.BsonTypeMapper.MapToDotNetValue!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterCustomTypeMapper_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    MongoDB.Bson.ICustomBsonTypeMapper _customTypeMapper = (MongoDB.Bson.ICustomBsonTypeMapper)translator.GetObject(L, 2, typeof(MongoDB.Bson.ICustomBsonTypeMapper));
                    
                    MongoDB.Bson.BsonTypeMapper.RegisterCustomTypeMapper( _type, _customTypeMapper );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryMapToBsonValue_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    object _value = translator.GetObject(L, 1, typeof(object));
                    MongoDB.Bson.BsonValue _bsonValue;
                    
                        bool gen_ret = MongoDB.Bson.BsonTypeMapper.TryMapToBsonValue( _value, out _bsonValue );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _bsonValue);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
