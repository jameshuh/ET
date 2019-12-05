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
    
    public class MongoDBBsonBsonBinarySubTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(MongoDB.Bson.BsonBinarySubType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(MongoDB.Bson.BsonBinarySubType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(MongoDB.Bson.BsonBinarySubType), L, null, 8, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Binary", MongoDB.Bson.BsonBinarySubType.Binary);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Function", MongoDB.Bson.BsonBinarySubType.Function);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UuidLegacy", MongoDB.Bson.BsonBinarySubType.UuidLegacy);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UuidStandard", MongoDB.Bson.BsonBinarySubType.UuidStandard);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MD5", MongoDB.Bson.BsonBinarySubType.MD5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UserDefined", MongoDB.Bson.BsonBinarySubType.UserDefined);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(MongoDB.Bson.BsonBinarySubType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushMongoDBBsonBsonBinarySubType(L, (MongoDB.Bson.BsonBinarySubType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Binary"))
                {
                    translator.PushMongoDBBsonBsonBinarySubType(L, MongoDB.Bson.BsonBinarySubType.Binary);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Function"))
                {
                    translator.PushMongoDBBsonBsonBinarySubType(L, MongoDB.Bson.BsonBinarySubType.Function);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UuidLegacy"))
                {
                    translator.PushMongoDBBsonBsonBinarySubType(L, MongoDB.Bson.BsonBinarySubType.UuidLegacy);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UuidStandard"))
                {
                    translator.PushMongoDBBsonBsonBinarySubType(L, MongoDB.Bson.BsonBinarySubType.UuidStandard);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MD5"))
                {
                    translator.PushMongoDBBsonBsonBinarySubType(L, MongoDB.Bson.BsonBinarySubType.MD5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UserDefined"))
                {
                    translator.PushMongoDBBsonBsonBinarySubType(L, MongoDB.Bson.BsonBinarySubType.UserDefined);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for MongoDB.Bson.BsonBinarySubType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for MongoDB.Bson.BsonBinarySubType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class MongoDBBsonBsonTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(MongoDB.Bson.BsonType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(MongoDB.Bson.BsonType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(MongoDB.Bson.BsonType), L, null, 22, 0, 0);

            Utils.RegisterEnumType(L, typeof(MongoDB.Bson.BsonType));

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(MongoDB.Bson.BsonType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushMongoDBBsonBsonType(L, (MongoDB.Bson.BsonType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

                try
				{
                    translator.TranslateToEnumToTop(L, typeof(MongoDB.Bson.BsonType), 1);
				}
				catch (System.Exception e)
				{
					return LuaAPI.luaL_error(L, "cast to " + typeof(MongoDB.Bson.BsonType) + " exception:" + e);
				}

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for MongoDB.Bson.BsonType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class MongoDBBsonDuplicateNameHandlingWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(MongoDB.Bson.DuplicateNameHandling), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(MongoDB.Bson.DuplicateNameHandling), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(MongoDB.Bson.DuplicateNameHandling), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Overwrite", MongoDB.Bson.DuplicateNameHandling.Overwrite);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ignore", MongoDB.Bson.DuplicateNameHandling.Ignore);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ThrowException", MongoDB.Bson.DuplicateNameHandling.ThrowException);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(MongoDB.Bson.DuplicateNameHandling), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushMongoDBBsonDuplicateNameHandling(L, (MongoDB.Bson.DuplicateNameHandling)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Overwrite"))
                {
                    translator.PushMongoDBBsonDuplicateNameHandling(L, MongoDB.Bson.DuplicateNameHandling.Overwrite);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Ignore"))
                {
                    translator.PushMongoDBBsonDuplicateNameHandling(L, MongoDB.Bson.DuplicateNameHandling.Ignore);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ThrowException"))
                {
                    translator.PushMongoDBBsonDuplicateNameHandling(L, MongoDB.Bson.DuplicateNameHandling.ThrowException);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for MongoDB.Bson.DuplicateNameHandling!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for MongoDB.Bson.DuplicateNameHandling! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class MongoDBBsonGuidRepresentationWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(MongoDB.Bson.GuidRepresentation), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(MongoDB.Bson.GuidRepresentation), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(MongoDB.Bson.GuidRepresentation), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unspecified", MongoDB.Bson.GuidRepresentation.Unspecified);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Standard", MongoDB.Bson.GuidRepresentation.Standard);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CSharpLegacy", MongoDB.Bson.GuidRepresentation.CSharpLegacy);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JavaLegacy", MongoDB.Bson.GuidRepresentation.JavaLegacy);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PythonLegacy", MongoDB.Bson.GuidRepresentation.PythonLegacy);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(MongoDB.Bson.GuidRepresentation), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushMongoDBBsonGuidRepresentation(L, (MongoDB.Bson.GuidRepresentation)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Unspecified"))
                {
                    translator.PushMongoDBBsonGuidRepresentation(L, MongoDB.Bson.GuidRepresentation.Unspecified);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Standard"))
                {
                    translator.PushMongoDBBsonGuidRepresentation(L, MongoDB.Bson.GuidRepresentation.Standard);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CSharpLegacy"))
                {
                    translator.PushMongoDBBsonGuidRepresentation(L, MongoDB.Bson.GuidRepresentation.CSharpLegacy);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JavaLegacy"))
                {
                    translator.PushMongoDBBsonGuidRepresentation(L, MongoDB.Bson.GuidRepresentation.JavaLegacy);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PythonLegacy"))
                {
                    translator.PushMongoDBBsonGuidRepresentation(L, MongoDB.Bson.GuidRepresentation.PythonLegacy);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for MongoDB.Bson.GuidRepresentation!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for MongoDB.Bson.GuidRepresentation! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class MongoDBBsonSerializationOptionsDictionaryRepresentationWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(MongoDB.Bson.Serialization.Options.DictionaryRepresentation), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(MongoDB.Bson.Serialization.Options.DictionaryRepresentation), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(MongoDB.Bson.Serialization.Options.DictionaryRepresentation), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Document", MongoDB.Bson.Serialization.Options.DictionaryRepresentation.Document);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ArrayOfArrays", MongoDB.Bson.Serialization.Options.DictionaryRepresentation.ArrayOfArrays);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ArrayOfDocuments", MongoDB.Bson.Serialization.Options.DictionaryRepresentation.ArrayOfDocuments);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(MongoDB.Bson.Serialization.Options.DictionaryRepresentation), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushMongoDBBsonSerializationOptionsDictionaryRepresentation(L, (MongoDB.Bson.Serialization.Options.DictionaryRepresentation)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Document"))
                {
                    translator.PushMongoDBBsonSerializationOptionsDictionaryRepresentation(L, MongoDB.Bson.Serialization.Options.DictionaryRepresentation.Document);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ArrayOfArrays"))
                {
                    translator.PushMongoDBBsonSerializationOptionsDictionaryRepresentation(L, MongoDB.Bson.Serialization.Options.DictionaryRepresentation.ArrayOfArrays);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ArrayOfDocuments"))
                {
                    translator.PushMongoDBBsonSerializationOptionsDictionaryRepresentation(L, MongoDB.Bson.Serialization.Options.DictionaryRepresentation.ArrayOfDocuments);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for MongoDB.Bson.Serialization.Options.DictionaryRepresentation!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for MongoDB.Bson.Serialization.Options.DictionaryRepresentation! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class MongoDBBsonSerializationOptionsTimeSpanUnitsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(MongoDB.Bson.Serialization.Options.TimeSpanUnits), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(MongoDB.Bson.Serialization.Options.TimeSpanUnits), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(MongoDB.Bson.Serialization.Options.TimeSpanUnits), L, null, 9, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ticks", MongoDB.Bson.Serialization.Options.TimeSpanUnits.Ticks);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Days", MongoDB.Bson.Serialization.Options.TimeSpanUnits.Days);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Hours", MongoDB.Bson.Serialization.Options.TimeSpanUnits.Hours);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Minutes", MongoDB.Bson.Serialization.Options.TimeSpanUnits.Minutes);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Seconds", MongoDB.Bson.Serialization.Options.TimeSpanUnits.Seconds);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Milliseconds", MongoDB.Bson.Serialization.Options.TimeSpanUnits.Milliseconds);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Microseconds", MongoDB.Bson.Serialization.Options.TimeSpanUnits.Microseconds);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Nanoseconds", MongoDB.Bson.Serialization.Options.TimeSpanUnits.Nanoseconds);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(MongoDB.Bson.Serialization.Options.TimeSpanUnits), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushMongoDBBsonSerializationOptionsTimeSpanUnits(L, (MongoDB.Bson.Serialization.Options.TimeSpanUnits)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Ticks"))
                {
                    translator.PushMongoDBBsonSerializationOptionsTimeSpanUnits(L, MongoDB.Bson.Serialization.Options.TimeSpanUnits.Ticks);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Days"))
                {
                    translator.PushMongoDBBsonSerializationOptionsTimeSpanUnits(L, MongoDB.Bson.Serialization.Options.TimeSpanUnits.Days);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Hours"))
                {
                    translator.PushMongoDBBsonSerializationOptionsTimeSpanUnits(L, MongoDB.Bson.Serialization.Options.TimeSpanUnits.Hours);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Minutes"))
                {
                    translator.PushMongoDBBsonSerializationOptionsTimeSpanUnits(L, MongoDB.Bson.Serialization.Options.TimeSpanUnits.Minutes);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Seconds"))
                {
                    translator.PushMongoDBBsonSerializationOptionsTimeSpanUnits(L, MongoDB.Bson.Serialization.Options.TimeSpanUnits.Seconds);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Milliseconds"))
                {
                    translator.PushMongoDBBsonSerializationOptionsTimeSpanUnits(L, MongoDB.Bson.Serialization.Options.TimeSpanUnits.Milliseconds);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Microseconds"))
                {
                    translator.PushMongoDBBsonSerializationOptionsTimeSpanUnits(L, MongoDB.Bson.Serialization.Options.TimeSpanUnits.Microseconds);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Nanoseconds"))
                {
                    translator.PushMongoDBBsonSerializationOptionsTimeSpanUnits(L, MongoDB.Bson.Serialization.Options.TimeSpanUnits.Nanoseconds);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for MongoDB.Bson.Serialization.Options.TimeSpanUnits!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for MongoDB.Bson.Serialization.Options.TimeSpanUnits! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class MongoDBBsonIOBsonReaderStateWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(MongoDB.Bson.IO.BsonReaderState), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(MongoDB.Bson.IO.BsonReaderState), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(MongoDB.Bson.IO.BsonReaderState), L, null, 10, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Initial", MongoDB.Bson.IO.BsonReaderState.Initial);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Type", MongoDB.Bson.IO.BsonReaderState.Type);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Name", MongoDB.Bson.IO.BsonReaderState.Name);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Value", MongoDB.Bson.IO.BsonReaderState.Value);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScopeDocument", MongoDB.Bson.IO.BsonReaderState.ScopeDocument);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EndOfDocument", MongoDB.Bson.IO.BsonReaderState.EndOfDocument);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EndOfArray", MongoDB.Bson.IO.BsonReaderState.EndOfArray);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Done", MongoDB.Bson.IO.BsonReaderState.Done);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Closed", MongoDB.Bson.IO.BsonReaderState.Closed);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(MongoDB.Bson.IO.BsonReaderState), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushMongoDBBsonIOBsonReaderState(L, (MongoDB.Bson.IO.BsonReaderState)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Initial"))
                {
                    translator.PushMongoDBBsonIOBsonReaderState(L, MongoDB.Bson.IO.BsonReaderState.Initial);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Type"))
                {
                    translator.PushMongoDBBsonIOBsonReaderState(L, MongoDB.Bson.IO.BsonReaderState.Type);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Name"))
                {
                    translator.PushMongoDBBsonIOBsonReaderState(L, MongoDB.Bson.IO.BsonReaderState.Name);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Value"))
                {
                    translator.PushMongoDBBsonIOBsonReaderState(L, MongoDB.Bson.IO.BsonReaderState.Value);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScopeDocument"))
                {
                    translator.PushMongoDBBsonIOBsonReaderState(L, MongoDB.Bson.IO.BsonReaderState.ScopeDocument);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EndOfDocument"))
                {
                    translator.PushMongoDBBsonIOBsonReaderState(L, MongoDB.Bson.IO.BsonReaderState.EndOfDocument);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EndOfArray"))
                {
                    translator.PushMongoDBBsonIOBsonReaderState(L, MongoDB.Bson.IO.BsonReaderState.EndOfArray);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Done"))
                {
                    translator.PushMongoDBBsonIOBsonReaderState(L, MongoDB.Bson.IO.BsonReaderState.Done);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Closed"))
                {
                    translator.PushMongoDBBsonIOBsonReaderState(L, MongoDB.Bson.IO.BsonReaderState.Closed);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for MongoDB.Bson.IO.BsonReaderState!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for MongoDB.Bson.IO.BsonReaderState! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class MongoDBBsonIOBsonWriterStateWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(MongoDB.Bson.IO.BsonWriterState), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(MongoDB.Bson.IO.BsonWriterState), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(MongoDB.Bson.IO.BsonWriterState), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Initial", MongoDB.Bson.IO.BsonWriterState.Initial);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Name", MongoDB.Bson.IO.BsonWriterState.Name);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Value", MongoDB.Bson.IO.BsonWriterState.Value);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScopeDocument", MongoDB.Bson.IO.BsonWriterState.ScopeDocument);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Done", MongoDB.Bson.IO.BsonWriterState.Done);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Closed", MongoDB.Bson.IO.BsonWriterState.Closed);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(MongoDB.Bson.IO.BsonWriterState), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushMongoDBBsonIOBsonWriterState(L, (MongoDB.Bson.IO.BsonWriterState)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Initial"))
                {
                    translator.PushMongoDBBsonIOBsonWriterState(L, MongoDB.Bson.IO.BsonWriterState.Initial);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Name"))
                {
                    translator.PushMongoDBBsonIOBsonWriterState(L, MongoDB.Bson.IO.BsonWriterState.Name);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Value"))
                {
                    translator.PushMongoDBBsonIOBsonWriterState(L, MongoDB.Bson.IO.BsonWriterState.Value);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScopeDocument"))
                {
                    translator.PushMongoDBBsonIOBsonWriterState(L, MongoDB.Bson.IO.BsonWriterState.ScopeDocument);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Done"))
                {
                    translator.PushMongoDBBsonIOBsonWriterState(L, MongoDB.Bson.IO.BsonWriterState.Done);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Closed"))
                {
                    translator.PushMongoDBBsonIOBsonWriterState(L, MongoDB.Bson.IO.BsonWriterState.Closed);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for MongoDB.Bson.IO.BsonWriterState!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for MongoDB.Bson.IO.BsonWriterState! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class MongoDBBsonIOContextTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(MongoDB.Bson.IO.ContextType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(MongoDB.Bson.IO.ContextType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(MongoDB.Bson.IO.ContextType), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopLevel", MongoDB.Bson.IO.ContextType.TopLevel);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Document", MongoDB.Bson.IO.ContextType.Document);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Array", MongoDB.Bson.IO.ContextType.Array);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JavaScriptWithScope", MongoDB.Bson.IO.ContextType.JavaScriptWithScope);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScopeDocument", MongoDB.Bson.IO.ContextType.ScopeDocument);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(MongoDB.Bson.IO.ContextType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushMongoDBBsonIOContextType(L, (MongoDB.Bson.IO.ContextType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "TopLevel"))
                {
                    translator.PushMongoDBBsonIOContextType(L, MongoDB.Bson.IO.ContextType.TopLevel);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Document"))
                {
                    translator.PushMongoDBBsonIOContextType(L, MongoDB.Bson.IO.ContextType.Document);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Array"))
                {
                    translator.PushMongoDBBsonIOContextType(L, MongoDB.Bson.IO.ContextType.Array);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JavaScriptWithScope"))
                {
                    translator.PushMongoDBBsonIOContextType(L, MongoDB.Bson.IO.ContextType.JavaScriptWithScope);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScopeDocument"))
                {
                    translator.PushMongoDBBsonIOContextType(L, MongoDB.Bson.IO.ContextType.ScopeDocument);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for MongoDB.Bson.IO.ContextType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for MongoDB.Bson.IO.ContextType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class MongoDBBsonIOJsonOutputModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(MongoDB.Bson.IO.JsonOutputMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(MongoDB.Bson.IO.JsonOutputMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(MongoDB.Bson.IO.JsonOutputMode), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Strict", MongoDB.Bson.IO.JsonOutputMode.Strict);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Shell", MongoDB.Bson.IO.JsonOutputMode.Shell);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(MongoDB.Bson.IO.JsonOutputMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushMongoDBBsonIOJsonOutputMode(L, (MongoDB.Bson.IO.JsonOutputMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Strict"))
                {
                    translator.PushMongoDBBsonIOJsonOutputMode(L, MongoDB.Bson.IO.JsonOutputMode.Strict);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Shell"))
                {
                    translator.PushMongoDBBsonIOJsonOutputMode(L, MongoDB.Bson.IO.JsonOutputMode.Shell);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for MongoDB.Bson.IO.JsonOutputMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for MongoDB.Bson.IO.JsonOutputMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class MongoDBBsonIOJsonTokenTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(MongoDB.Bson.IO.JsonTokenType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(MongoDB.Bson.IO.JsonTokenType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(MongoDB.Bson.IO.JsonTokenType), L, null, 19, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Invalid", MongoDB.Bson.IO.JsonTokenType.Invalid);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BeginArray", MongoDB.Bson.IO.JsonTokenType.BeginArray);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BeginObject", MongoDB.Bson.IO.JsonTokenType.BeginObject);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EndArray", MongoDB.Bson.IO.JsonTokenType.EndArray);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftParen", MongoDB.Bson.IO.JsonTokenType.LeftParen);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightParen", MongoDB.Bson.IO.JsonTokenType.RightParen);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EndObject", MongoDB.Bson.IO.JsonTokenType.EndObject);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Colon", MongoDB.Bson.IO.JsonTokenType.Colon);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Comma", MongoDB.Bson.IO.JsonTokenType.Comma);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DateTime", MongoDB.Bson.IO.JsonTokenType.DateTime);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Double", MongoDB.Bson.IO.JsonTokenType.Double);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Int32", MongoDB.Bson.IO.JsonTokenType.Int32);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Int64", MongoDB.Bson.IO.JsonTokenType.Int64);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ObjectId", MongoDB.Bson.IO.JsonTokenType.ObjectId);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RegularExpression", MongoDB.Bson.IO.JsonTokenType.RegularExpression);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "String", MongoDB.Bson.IO.JsonTokenType.String);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnquotedString", MongoDB.Bson.IO.JsonTokenType.UnquotedString);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EndOfFile", MongoDB.Bson.IO.JsonTokenType.EndOfFile);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(MongoDB.Bson.IO.JsonTokenType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushMongoDBBsonIOJsonTokenType(L, (MongoDB.Bson.IO.JsonTokenType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Invalid"))
                {
                    translator.PushMongoDBBsonIOJsonTokenType(L, MongoDB.Bson.IO.JsonTokenType.Invalid);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BeginArray"))
                {
                    translator.PushMongoDBBsonIOJsonTokenType(L, MongoDB.Bson.IO.JsonTokenType.BeginArray);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BeginObject"))
                {
                    translator.PushMongoDBBsonIOJsonTokenType(L, MongoDB.Bson.IO.JsonTokenType.BeginObject);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EndArray"))
                {
                    translator.PushMongoDBBsonIOJsonTokenType(L, MongoDB.Bson.IO.JsonTokenType.EndArray);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftParen"))
                {
                    translator.PushMongoDBBsonIOJsonTokenType(L, MongoDB.Bson.IO.JsonTokenType.LeftParen);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightParen"))
                {
                    translator.PushMongoDBBsonIOJsonTokenType(L, MongoDB.Bson.IO.JsonTokenType.RightParen);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EndObject"))
                {
                    translator.PushMongoDBBsonIOJsonTokenType(L, MongoDB.Bson.IO.JsonTokenType.EndObject);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Colon"))
                {
                    translator.PushMongoDBBsonIOJsonTokenType(L, MongoDB.Bson.IO.JsonTokenType.Colon);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Comma"))
                {
                    translator.PushMongoDBBsonIOJsonTokenType(L, MongoDB.Bson.IO.JsonTokenType.Comma);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DateTime"))
                {
                    translator.PushMongoDBBsonIOJsonTokenType(L, MongoDB.Bson.IO.JsonTokenType.DateTime);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Double"))
                {
                    translator.PushMongoDBBsonIOJsonTokenType(L, MongoDB.Bson.IO.JsonTokenType.Double);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Int32"))
                {
                    translator.PushMongoDBBsonIOJsonTokenType(L, MongoDB.Bson.IO.JsonTokenType.Int32);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Int64"))
                {
                    translator.PushMongoDBBsonIOJsonTokenType(L, MongoDB.Bson.IO.JsonTokenType.Int64);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ObjectId"))
                {
                    translator.PushMongoDBBsonIOJsonTokenType(L, MongoDB.Bson.IO.JsonTokenType.ObjectId);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RegularExpression"))
                {
                    translator.PushMongoDBBsonIOJsonTokenType(L, MongoDB.Bson.IO.JsonTokenType.RegularExpression);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "String"))
                {
                    translator.PushMongoDBBsonIOJsonTokenType(L, MongoDB.Bson.IO.JsonTokenType.String);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UnquotedString"))
                {
                    translator.PushMongoDBBsonIOJsonTokenType(L, MongoDB.Bson.IO.JsonTokenType.UnquotedString);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EndOfFile"))
                {
                    translator.PushMongoDBBsonIOJsonTokenType(L, MongoDB.Bson.IO.JsonTokenType.EndOfFile);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for MongoDB.Bson.IO.JsonTokenType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for MongoDB.Bson.IO.JsonTokenType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DCETModelChannelTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DCET.Model.ChannelType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DCET.Model.ChannelType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DCET.Model.ChannelType), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Connect", DCET.Model.ChannelType.Connect);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Accept", DCET.Model.ChannelType.Accept);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DCET.Model.ChannelType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDCETModelChannelType(L, (DCET.Model.ChannelType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Connect"))
                {
                    translator.PushDCETModelChannelType(L, DCET.Model.ChannelType.Connect);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Accept"))
                {
                    translator.PushDCETModelChannelType(L, DCET.Model.ChannelType.Accept);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DCET.Model.ChannelType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DCET.Model.ChannelType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DCETModelNetworkProtocolWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DCET.Model.NetworkProtocol), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DCET.Model.NetworkProtocol), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DCET.Model.NetworkProtocol), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "KCP", DCET.Model.NetworkProtocol.KCP);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TCP", DCET.Model.NetworkProtocol.TCP);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "WebSocket", DCET.Model.NetworkProtocol.WebSocket);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DCET.Model.NetworkProtocol), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDCETModelNetworkProtocol(L, (DCET.Model.NetworkProtocol)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "KCP"))
                {
                    translator.PushDCETModelNetworkProtocol(L, DCET.Model.NetworkProtocol.KCP);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TCP"))
                {
                    translator.PushDCETModelNetworkProtocol(L, DCET.Model.NetworkProtocol.TCP);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "WebSocket"))
                {
                    translator.PushDCETModelNetworkProtocol(L, DCET.Model.NetworkProtocol.WebSocket);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DCET.Model.NetworkProtocol!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DCET.Model.NetworkProtocol! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DCETModelParserStateWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DCET.Model.ParserState), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DCET.Model.ParserState), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DCET.Model.ParserState), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PacketSize", DCET.Model.ParserState.PacketSize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PacketBody", DCET.Model.ParserState.PacketBody);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DCET.Model.ParserState), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDCETModelParserState(L, (DCET.Model.ParserState)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "PacketSize"))
                {
                    translator.PushDCETModelParserState(L, DCET.Model.ParserState.PacketSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PacketBody"))
                {
                    translator.PushDCETModelParserState(L, DCET.Model.ParserState.PacketBody);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DCET.Model.ParserState!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DCET.Model.ParserState! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class LitJsonJsonTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(LitJson.JsonType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(LitJson.JsonType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(LitJson.JsonType), L, null, 9, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", LitJson.JsonType.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Object", LitJson.JsonType.Object);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Array", LitJson.JsonType.Array);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "String", LitJson.JsonType.String);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Int", LitJson.JsonType.Int);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Long", LitJson.JsonType.Long);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Double", LitJson.JsonType.Double);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Boolean", LitJson.JsonType.Boolean);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(LitJson.JsonType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushLitJsonJsonType(L, (LitJson.JsonType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushLitJsonJsonType(L, LitJson.JsonType.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Object"))
                {
                    translator.PushLitJsonJsonType(L, LitJson.JsonType.Object);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Array"))
                {
                    translator.PushLitJsonJsonType(L, LitJson.JsonType.Array);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "String"))
                {
                    translator.PushLitJsonJsonType(L, LitJson.JsonType.String);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Int"))
                {
                    translator.PushLitJsonJsonType(L, LitJson.JsonType.Int);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Long"))
                {
                    translator.PushLitJsonJsonType(L, LitJson.JsonType.Long);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Double"))
                {
                    translator.PushLitJsonJsonType(L, LitJson.JsonType.Double);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Boolean"))
                {
                    translator.PushLitJsonJsonType(L, LitJson.JsonType.Boolean);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for LitJson.JsonType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for LitJson.JsonType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class LitJsonJsonTokenWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(LitJson.JsonToken), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(LitJson.JsonToken), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(LitJson.JsonToken), L, null, 13, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", LitJson.JsonToken.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ObjectStart", LitJson.JsonToken.ObjectStart);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PropertyName", LitJson.JsonToken.PropertyName);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ObjectEnd", LitJson.JsonToken.ObjectEnd);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ArrayStart", LitJson.JsonToken.ArrayStart);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ArrayEnd", LitJson.JsonToken.ArrayEnd);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Int", LitJson.JsonToken.Int);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Long", LitJson.JsonToken.Long);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Double", LitJson.JsonToken.Double);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "String", LitJson.JsonToken.String);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Boolean", LitJson.JsonToken.Boolean);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Null", LitJson.JsonToken.Null);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(LitJson.JsonToken), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushLitJsonJsonToken(L, (LitJson.JsonToken)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushLitJsonJsonToken(L, LitJson.JsonToken.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ObjectStart"))
                {
                    translator.PushLitJsonJsonToken(L, LitJson.JsonToken.ObjectStart);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PropertyName"))
                {
                    translator.PushLitJsonJsonToken(L, LitJson.JsonToken.PropertyName);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ObjectEnd"))
                {
                    translator.PushLitJsonJsonToken(L, LitJson.JsonToken.ObjectEnd);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ArrayStart"))
                {
                    translator.PushLitJsonJsonToken(L, LitJson.JsonToken.ArrayStart);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ArrayEnd"))
                {
                    translator.PushLitJsonJsonToken(L, LitJson.JsonToken.ArrayEnd);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Int"))
                {
                    translator.PushLitJsonJsonToken(L, LitJson.JsonToken.Int);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Long"))
                {
                    translator.PushLitJsonJsonToken(L, LitJson.JsonToken.Long);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Double"))
                {
                    translator.PushLitJsonJsonToken(L, LitJson.JsonToken.Double);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "String"))
                {
                    translator.PushLitJsonJsonToken(L, LitJson.JsonToken.String);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Boolean"))
                {
                    translator.PushLitJsonJsonToken(L, LitJson.JsonToken.Boolean);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Null"))
                {
                    translator.PushLitJsonJsonToken(L, LitJson.JsonToken.Null);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for LitJson.JsonToken!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for LitJson.JsonToken! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DCETModelNumericTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DCET.Model.NumericType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DCET.Model.NumericType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DCET.Model.NumericType), L, null, 16, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Max", DCET.Model.NumericType.Max);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Speed", DCET.Model.NumericType.Speed);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SpeedBase", DCET.Model.NumericType.SpeedBase);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SpeedAdd", DCET.Model.NumericType.SpeedAdd);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SpeedPct", DCET.Model.NumericType.SpeedPct);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SpeedFinalAdd", DCET.Model.NumericType.SpeedFinalAdd);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SpeedFinalPct", DCET.Model.NumericType.SpeedFinalPct);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Hp", DCET.Model.NumericType.Hp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HpBase", DCET.Model.NumericType.HpBase);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MaxHp", DCET.Model.NumericType.MaxHp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MaxHpBase", DCET.Model.NumericType.MaxHpBase);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MaxHpAdd", DCET.Model.NumericType.MaxHpAdd);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MaxHpPct", DCET.Model.NumericType.MaxHpPct);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MaxHpFinalAdd", DCET.Model.NumericType.MaxHpFinalAdd);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MaxHpFinalPct", DCET.Model.NumericType.MaxHpFinalPct);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DCET.Model.NumericType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDCETModelNumericType(L, (DCET.Model.NumericType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Max"))
                {
                    translator.PushDCETModelNumericType(L, DCET.Model.NumericType.Max);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Speed"))
                {
                    translator.PushDCETModelNumericType(L, DCET.Model.NumericType.Speed);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SpeedBase"))
                {
                    translator.PushDCETModelNumericType(L, DCET.Model.NumericType.SpeedBase);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SpeedAdd"))
                {
                    translator.PushDCETModelNumericType(L, DCET.Model.NumericType.SpeedAdd);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SpeedPct"))
                {
                    translator.PushDCETModelNumericType(L, DCET.Model.NumericType.SpeedPct);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SpeedFinalAdd"))
                {
                    translator.PushDCETModelNumericType(L, DCET.Model.NumericType.SpeedFinalAdd);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SpeedFinalPct"))
                {
                    translator.PushDCETModelNumericType(L, DCET.Model.NumericType.SpeedFinalPct);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Hp"))
                {
                    translator.PushDCETModelNumericType(L, DCET.Model.NumericType.Hp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "HpBase"))
                {
                    translator.PushDCETModelNumericType(L, DCET.Model.NumericType.HpBase);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MaxHp"))
                {
                    translator.PushDCETModelNumericType(L, DCET.Model.NumericType.MaxHp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MaxHpBase"))
                {
                    translator.PushDCETModelNumericType(L, DCET.Model.NumericType.MaxHpBase);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MaxHpAdd"))
                {
                    translator.PushDCETModelNumericType(L, DCET.Model.NumericType.MaxHpAdd);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MaxHpPct"))
                {
                    translator.PushDCETModelNumericType(L, DCET.Model.NumericType.MaxHpPct);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MaxHpFinalAdd"))
                {
                    translator.PushDCETModelNumericType(L, DCET.Model.NumericType.MaxHpFinalAdd);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MaxHpFinalPct"))
                {
                    translator.PushDCETModelNumericType(L, DCET.Model.NumericType.MaxHpFinalPct);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DCET.Model.NumericType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DCET.Model.NumericType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DCETModelCoroutineLockTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DCET.Model.CoroutineLockType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DCET.Model.CoroutineLockType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DCET.Model.CoroutineLockType), L, null, 15, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", DCET.Model.CoroutineLockType.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Location", DCET.Model.CoroutineLockType.Location);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ActorLocationSender", DCET.Model.CoroutineLockType.ActorLocationSender);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mailbox", DCET.Model.CoroutineLockType.Mailbox);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AccountName", DCET.Model.CoroutineLockType.AccountName);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AccountId", DCET.Model.CoroutineLockType.AccountId);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnitId", DCET.Model.CoroutineLockType.UnitId);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SendMail", DCET.Model.CoroutineLockType.SendMail);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DB", DCET.Model.CoroutineLockType.DB);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LevelSeal", DCET.Model.CoroutineLockType.LevelSeal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ClientChangeScene", DCET.Model.CoroutineLockType.ClientChangeScene);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Resources", DCET.Model.CoroutineLockType.Resources);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ResourcesLoader", DCET.Model.CoroutineLockType.ResourcesLoader);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Max", DCET.Model.CoroutineLockType.Max);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DCET.Model.CoroutineLockType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDCETModelCoroutineLockType(L, (DCET.Model.CoroutineLockType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushDCETModelCoroutineLockType(L, DCET.Model.CoroutineLockType.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Location"))
                {
                    translator.PushDCETModelCoroutineLockType(L, DCET.Model.CoroutineLockType.Location);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ActorLocationSender"))
                {
                    translator.PushDCETModelCoroutineLockType(L, DCET.Model.CoroutineLockType.ActorLocationSender);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mailbox"))
                {
                    translator.PushDCETModelCoroutineLockType(L, DCET.Model.CoroutineLockType.Mailbox);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AccountName"))
                {
                    translator.PushDCETModelCoroutineLockType(L, DCET.Model.CoroutineLockType.AccountName);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AccountId"))
                {
                    translator.PushDCETModelCoroutineLockType(L, DCET.Model.CoroutineLockType.AccountId);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UnitId"))
                {
                    translator.PushDCETModelCoroutineLockType(L, DCET.Model.CoroutineLockType.UnitId);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SendMail"))
                {
                    translator.PushDCETModelCoroutineLockType(L, DCET.Model.CoroutineLockType.SendMail);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DB"))
                {
                    translator.PushDCETModelCoroutineLockType(L, DCET.Model.CoroutineLockType.DB);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LevelSeal"))
                {
                    translator.PushDCETModelCoroutineLockType(L, DCET.Model.CoroutineLockType.LevelSeal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ClientChangeScene"))
                {
                    translator.PushDCETModelCoroutineLockType(L, DCET.Model.CoroutineLockType.ClientChangeScene);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Resources"))
                {
                    translator.PushDCETModelCoroutineLockType(L, DCET.Model.CoroutineLockType.Resources);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ResourcesLoader"))
                {
                    translator.PushDCETModelCoroutineLockType(L, DCET.Model.CoroutineLockType.ResourcesLoader);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Max"))
                {
                    translator.PushDCETModelCoroutineLockType(L, DCET.Model.CoroutineLockType.Max);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DCET.Model.CoroutineLockType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DCET.Model.CoroutineLockType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PFHeuristicOptimizationModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(PF.HeuristicOptimizationMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(PF.HeuristicOptimizationMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(PF.HeuristicOptimizationMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", PF.HeuristicOptimizationMode.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Random", PF.HeuristicOptimizationMode.Random);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RandomSpreadOut", PF.HeuristicOptimizationMode.RandomSpreadOut);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(PF.HeuristicOptimizationMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPFHeuristicOptimizationMode(L, (PF.HeuristicOptimizationMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushPFHeuristicOptimizationMode(L, PF.HeuristicOptimizationMode.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Random"))
                {
                    translator.PushPFHeuristicOptimizationMode(L, PF.HeuristicOptimizationMode.Random);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RandomSpreadOut"))
                {
                    translator.PushPFHeuristicOptimizationMode(L, PF.HeuristicOptimizationMode.RandomSpreadOut);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for PF.HeuristicOptimizationMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for PF.HeuristicOptimizationMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PFGraphUpdateThreadingWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(PF.GraphUpdateThreading), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(PF.GraphUpdateThreading), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(PF.GraphUpdateThreading), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnityThread", PF.GraphUpdateThreading.UnityThread);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SeparateThread", PF.GraphUpdateThreading.SeparateThread);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnityInit", PF.GraphUpdateThreading.UnityInit);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnityPost", PF.GraphUpdateThreading.UnityPost);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SeparateAndUnityInit", PF.GraphUpdateThreading.SeparateAndUnityInit);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(PF.GraphUpdateThreading), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPFGraphUpdateThreading(L, (PF.GraphUpdateThreading)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "UnityThread"))
                {
                    translator.PushPFGraphUpdateThreading(L, PF.GraphUpdateThreading.UnityThread);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SeparateThread"))
                {
                    translator.PushPFGraphUpdateThreading(L, PF.GraphUpdateThreading.SeparateThread);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UnityInit"))
                {
                    translator.PushPFGraphUpdateThreading(L, PF.GraphUpdateThreading.UnityInit);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UnityPost"))
                {
                    translator.PushPFGraphUpdateThreading(L, PF.GraphUpdateThreading.UnityPost);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SeparateAndUnityInit"))
                {
                    translator.PushPFGraphUpdateThreading(L, PF.GraphUpdateThreading.SeparateAndUnityInit);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for PF.GraphUpdateThreading!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for PF.GraphUpdateThreading! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PFThreadCountWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(PF.ThreadCount), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(PF.ThreadCount), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(PF.ThreadCount), L, null, 12, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AutomaticLowLoad", PF.ThreadCount.AutomaticLowLoad);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AutomaticHighLoad", PF.ThreadCount.AutomaticHighLoad);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", PF.ThreadCount.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "One", PF.ThreadCount.One);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Two", PF.ThreadCount.Two);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Three", PF.ThreadCount.Three);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Four", PF.ThreadCount.Four);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Five", PF.ThreadCount.Five);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Six", PF.ThreadCount.Six);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Seven", PF.ThreadCount.Seven);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Eight", PF.ThreadCount.Eight);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(PF.ThreadCount), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPFThreadCount(L, (PF.ThreadCount)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "AutomaticLowLoad"))
                {
                    translator.PushPFThreadCount(L, PF.ThreadCount.AutomaticLowLoad);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AutomaticHighLoad"))
                {
                    translator.PushPFThreadCount(L, PF.ThreadCount.AutomaticHighLoad);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushPFThreadCount(L, PF.ThreadCount.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "One"))
                {
                    translator.PushPFThreadCount(L, PF.ThreadCount.One);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Two"))
                {
                    translator.PushPFThreadCount(L, PF.ThreadCount.Two);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Three"))
                {
                    translator.PushPFThreadCount(L, PF.ThreadCount.Three);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Four"))
                {
                    translator.PushPFThreadCount(L, PF.ThreadCount.Four);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Five"))
                {
                    translator.PushPFThreadCount(L, PF.ThreadCount.Five);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Six"))
                {
                    translator.PushPFThreadCount(L, PF.ThreadCount.Six);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Seven"))
                {
                    translator.PushPFThreadCount(L, PF.ThreadCount.Seven);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Eight"))
                {
                    translator.PushPFThreadCount(L, PF.ThreadCount.Eight);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for PF.ThreadCount!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for PF.ThreadCount! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PFPathStateWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(PF.PathState), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(PF.PathState), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(PF.PathState), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Created", PF.PathState.Created);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PathQueue", PF.PathState.PathQueue);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Processing", PF.PathState.Processing);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ReturnQueue", PF.PathState.ReturnQueue);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Returned", PF.PathState.Returned);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(PF.PathState), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPFPathState(L, (PF.PathState)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Created"))
                {
                    translator.PushPFPathState(L, PF.PathState.Created);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PathQueue"))
                {
                    translator.PushPFPathState(L, PF.PathState.PathQueue);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Processing"))
                {
                    translator.PushPFPathState(L, PF.PathState.Processing);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ReturnQueue"))
                {
                    translator.PushPFPathState(L, PF.PathState.ReturnQueue);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Returned"))
                {
                    translator.PushPFPathState(L, PF.PathState.Returned);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for PF.PathState!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for PF.PathState! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PFPathCompleteStateWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(PF.PathCompleteState), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(PF.PathCompleteState), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(PF.PathCompleteState), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NotCalculated", PF.PathCompleteState.NotCalculated);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Error", PF.PathCompleteState.Error);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Complete", PF.PathCompleteState.Complete);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Partial", PF.PathCompleteState.Partial);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(PF.PathCompleteState), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPFPathCompleteState(L, (PF.PathCompleteState)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "NotCalculated"))
                {
                    translator.PushPFPathCompleteState(L, PF.PathCompleteState.NotCalculated);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Error"))
                {
                    translator.PushPFPathCompleteState(L, PF.PathCompleteState.Error);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Complete"))
                {
                    translator.PushPFPathCompleteState(L, PF.PathCompleteState.Complete);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Partial"))
                {
                    translator.PushPFPathCompleteState(L, PF.PathCompleteState.Partial);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for PF.PathCompleteState!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for PF.PathCompleteState! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PFCloseToDestinationModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(PF.CloseToDestinationMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(PF.CloseToDestinationMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(PF.CloseToDestinationMode), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Stop", PF.CloseToDestinationMode.Stop);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ContinueToExactDestination", PF.CloseToDestinationMode.ContinueToExactDestination);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(PF.CloseToDestinationMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPFCloseToDestinationMode(L, (PF.CloseToDestinationMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Stop"))
                {
                    translator.PushPFCloseToDestinationMode(L, PF.CloseToDestinationMode.Stop);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ContinueToExactDestination"))
                {
                    translator.PushPFCloseToDestinationMode(L, PF.CloseToDestinationMode.ContinueToExactDestination);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for PF.CloseToDestinationMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for PF.CloseToDestinationMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PFSideWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(PF.Side), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(PF.Side), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(PF.Side), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Colinear", PF.Side.Colinear);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", PF.Side.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", PF.Side.Right);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(PF.Side), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPFSide(L, (PF.Side)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Colinear"))
                {
                    translator.PushPFSide(L, PF.Side.Colinear);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushPFSide(L, PF.Side.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushPFSide(L, PF.Side.Right);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for PF.Side!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for PF.Side! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PFInspectorGridModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(PF.InspectorGridMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(PF.InspectorGridMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(PF.InspectorGridMode), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Grid", PF.InspectorGridMode.Grid);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IsometricGrid", PF.InspectorGridMode.IsometricGrid);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Hexagonal", PF.InspectorGridMode.Hexagonal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Advanced", PF.InspectorGridMode.Advanced);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(PF.InspectorGridMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPFInspectorGridMode(L, (PF.InspectorGridMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Grid"))
                {
                    translator.PushPFInspectorGridMode(L, PF.InspectorGridMode.Grid);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IsometricGrid"))
                {
                    translator.PushPFInspectorGridMode(L, PF.InspectorGridMode.IsometricGrid);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Hexagonal"))
                {
                    translator.PushPFInspectorGridMode(L, PF.InspectorGridMode.Hexagonal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Advanced"))
                {
                    translator.PushPFInspectorGridMode(L, PF.InspectorGridMode.Advanced);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for PF.InspectorGridMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for PF.InspectorGridMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PFGraphDebugModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(PF.GraphDebugMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(PF.GraphDebugMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(PF.GraphDebugMode), L, null, 8, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Areas", PF.GraphDebugMode.Areas);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "G", PF.GraphDebugMode.G);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "H", PF.GraphDebugMode.H);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F", PF.GraphDebugMode.F);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Penalty", PF.GraphDebugMode.Penalty);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Connections", PF.GraphDebugMode.Connections);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Tags", PF.GraphDebugMode.Tags);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(PF.GraphDebugMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPFGraphDebugMode(L, (PF.GraphDebugMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Areas"))
                {
                    translator.PushPFGraphDebugMode(L, PF.GraphDebugMode.Areas);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "G"))
                {
                    translator.PushPFGraphDebugMode(L, PF.GraphDebugMode.G);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "H"))
                {
                    translator.PushPFGraphDebugMode(L, PF.GraphDebugMode.H);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F"))
                {
                    translator.PushPFGraphDebugMode(L, PF.GraphDebugMode.F);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Penalty"))
                {
                    translator.PushPFGraphDebugMode(L, PF.GraphDebugMode.Penalty);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Connections"))
                {
                    translator.PushPFGraphDebugMode(L, PF.GraphDebugMode.Connections);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Tags"))
                {
                    translator.PushPFGraphDebugMode(L, PF.GraphDebugMode.Tags);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for PF.GraphDebugMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for PF.GraphDebugMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PFPathLogWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(PF.PathLog), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(PF.PathLog), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(PF.PathLog), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", PF.PathLog.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Normal", PF.PathLog.Normal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Heavy", PF.PathLog.Heavy);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InGame", PF.PathLog.InGame);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OnlyErrors", PF.PathLog.OnlyErrors);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(PF.PathLog), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPFPathLog(L, (PF.PathLog)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushPFPathLog(L, PF.PathLog.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Normal"))
                {
                    translator.PushPFPathLog(L, PF.PathLog.Normal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Heavy"))
                {
                    translator.PushPFPathLog(L, PF.PathLog.Heavy);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InGame"))
                {
                    translator.PushPFPathLog(L, PF.PathLog.InGame);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OnlyErrors"))
                {
                    translator.PushPFPathLog(L, PF.PathLog.OnlyErrors);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for PF.PathLog!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for PF.PathLog! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PFHeuristicWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(PF.Heuristic), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(PF.Heuristic), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(PF.Heuristic), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Manhattan", PF.Heuristic.Manhattan);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DiagonalManhattan", PF.Heuristic.DiagonalManhattan);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Euclidean", PF.Heuristic.Euclidean);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", PF.Heuristic.None);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(PF.Heuristic), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPFHeuristic(L, (PF.Heuristic)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Manhattan"))
                {
                    translator.PushPFHeuristic(L, PF.Heuristic.Manhattan);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DiagonalManhattan"))
                {
                    translator.PushPFHeuristic(L, PF.Heuristic.DiagonalManhattan);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Euclidean"))
                {
                    translator.PushPFHeuristic(L, PF.Heuristic.Euclidean);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushPFHeuristic(L, PF.Heuristic.None);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for PF.Heuristic!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for PF.Heuristic! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PathfindingRVOMovementPlaneWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Pathfinding.RVO.MovementPlane), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Pathfinding.RVO.MovementPlane), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Pathfinding.RVO.MovementPlane), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "XZ", Pathfinding.RVO.MovementPlane.XZ);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "XY", Pathfinding.RVO.MovementPlane.XY);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Pathfinding.RVO.MovementPlane), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPathfindingRVOMovementPlane(L, (Pathfinding.RVO.MovementPlane)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "XZ"))
                {
                    translator.PushPathfindingRVOMovementPlane(L, Pathfinding.RVO.MovementPlane.XZ);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "XY"))
                {
                    translator.PushPathfindingRVOMovementPlane(L, Pathfinding.RVO.MovementPlane.XY);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Pathfinding.RVO.MovementPlane!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Pathfinding.RVO.MovementPlane! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PathfindingRVORVOLayerWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Pathfinding.RVO.RVOLayer), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Pathfinding.RVO.RVOLayer), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Pathfinding.RVO.RVOLayer), L, null, 32, 0, 0);

            Utils.RegisterEnumType(L, typeof(Pathfinding.RVO.RVOLayer));

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Pathfinding.RVO.RVOLayer), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPathfindingRVORVOLayer(L, (Pathfinding.RVO.RVOLayer)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

                try
				{
                    translator.TranslateToEnumToTop(L, typeof(Pathfinding.RVO.RVOLayer), 1);
				}
				catch (System.Exception e)
				{
					return LuaAPI.luaL_error(L, "cast to " + typeof(Pathfinding.RVO.RVOLayer) + " exception:" + e);
				}

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Pathfinding.RVO.RVOLayer! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class AstarPathAstarDistributionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(AstarPath.AstarDistribution), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(AstarPath.AstarDistribution), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(AstarPath.AstarDistribution), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "WebsiteDownload", AstarPath.AstarDistribution.WebsiteDownload);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AssetStore", AstarPath.AstarDistribution.AssetStore);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(AstarPath.AstarDistribution), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushAstarPathAstarDistribution(L, (AstarPath.AstarDistribution)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "WebsiteDownload"))
                {
                    translator.PushAstarPathAstarDistribution(L, AstarPath.AstarDistribution.WebsiteDownload);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AssetStore"))
                {
                    translator.PushAstarPathAstarDistribution(L, AstarPath.AstarDistribution.AssetStore);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for AstarPath.AstarDistribution!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for AstarPath.AstarDistribution! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PFMultiTargetPathHeuristicModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(PF.MultiTargetPath.HeuristicMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(PF.MultiTargetPath.HeuristicMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(PF.MultiTargetPath.HeuristicMode), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", PF.MultiTargetPath.HeuristicMode.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Average", PF.MultiTargetPath.HeuristicMode.Average);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MovingAverage", PF.MultiTargetPath.HeuristicMode.MovingAverage);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Midpoint", PF.MultiTargetPath.HeuristicMode.Midpoint);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MovingMidpoint", PF.MultiTargetPath.HeuristicMode.MovingMidpoint);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Sequential", PF.MultiTargetPath.HeuristicMode.Sequential);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(PF.MultiTargetPath.HeuristicMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPFMultiTargetPathHeuristicMode(L, (PF.MultiTargetPath.HeuristicMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushPFMultiTargetPathHeuristicMode(L, PF.MultiTargetPath.HeuristicMode.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Average"))
                {
                    translator.PushPFMultiTargetPathHeuristicMode(L, PF.MultiTargetPath.HeuristicMode.Average);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MovingAverage"))
                {
                    translator.PushPFMultiTargetPathHeuristicMode(L, PF.MultiTargetPath.HeuristicMode.MovingAverage);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Midpoint"))
                {
                    translator.PushPFMultiTargetPathHeuristicMode(L, PF.MultiTargetPath.HeuristicMode.Midpoint);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MovingMidpoint"))
                {
                    translator.PushPFMultiTargetPathHeuristicMode(L, PF.MultiTargetPath.HeuristicMode.MovingMidpoint);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Sequential"))
                {
                    translator.PushPFMultiTargetPathHeuristicMode(L, PF.MultiTargetPath.HeuristicMode.Sequential);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for PF.MultiTargetPath.HeuristicMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for PF.MultiTargetPath.HeuristicMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PFRecastGraphRelevantGraphSurfaceModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(PF.RecastGraph.RelevantGraphSurfaceMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(PF.RecastGraph.RelevantGraphSurfaceMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(PF.RecastGraph.RelevantGraphSurfaceMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DoNotRequire", PF.RecastGraph.RelevantGraphSurfaceMode.DoNotRequire);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OnlyForCompletelyInsideTile", PF.RecastGraph.RelevantGraphSurfaceMode.OnlyForCompletelyInsideTile);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RequireForAll", PF.RecastGraph.RelevantGraphSurfaceMode.RequireForAll);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(PF.RecastGraph.RelevantGraphSurfaceMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPFRecastGraphRelevantGraphSurfaceMode(L, (PF.RecastGraph.RelevantGraphSurfaceMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "DoNotRequire"))
                {
                    translator.PushPFRecastGraphRelevantGraphSurfaceMode(L, PF.RecastGraph.RelevantGraphSurfaceMode.DoNotRequire);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OnlyForCompletelyInsideTile"))
                {
                    translator.PushPFRecastGraphRelevantGraphSurfaceMode(L, PF.RecastGraph.RelevantGraphSurfaceMode.OnlyForCompletelyInsideTile);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RequireForAll"))
                {
                    translator.PushPFRecastGraphRelevantGraphSurfaceMode(L, PF.RecastGraph.RelevantGraphSurfaceMode.RequireForAll);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for PF.RecastGraph.RelevantGraphSurfaceMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for PF.RecastGraph.RelevantGraphSurfaceMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PathfindingSeekerModifierPassWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Pathfinding.Seeker.ModifierPass), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Pathfinding.Seeker.ModifierPass), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Pathfinding.Seeker.ModifierPass), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PreProcess", Pathfinding.Seeker.ModifierPass.PreProcess);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PostProcess", Pathfinding.Seeker.ModifierPass.PostProcess);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Pathfinding.Seeker.ModifierPass), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPathfindingSeekerModifierPass(L, (Pathfinding.Seeker.ModifierPass)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "PreProcess"))
                {
                    translator.PushPathfindingSeekerModifierPass(L, Pathfinding.Seeker.ModifierPass.PreProcess);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PostProcess"))
                {
                    translator.PushPathfindingSeekerModifierPass(L, Pathfinding.Seeker.ModifierPass.PostProcess);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Pathfinding.Seeker.ModifierPass!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Pathfinding.Seeker.ModifierPass! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PathfindingGraphModifierEventTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Pathfinding.GraphModifier.EventType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Pathfinding.GraphModifier.EventType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Pathfinding.GraphModifier.EventType), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PostScan", Pathfinding.GraphModifier.EventType.PostScan);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PreScan", Pathfinding.GraphModifier.EventType.PreScan);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LatePostScan", Pathfinding.GraphModifier.EventType.LatePostScan);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PreUpdate", Pathfinding.GraphModifier.EventType.PreUpdate);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PostUpdate", Pathfinding.GraphModifier.EventType.PostUpdate);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PostCacheLoad", Pathfinding.GraphModifier.EventType.PostCacheLoad);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Pathfinding.GraphModifier.EventType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPathfindingGraphModifierEventType(L, (Pathfinding.GraphModifier.EventType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "PostScan"))
                {
                    translator.PushPathfindingGraphModifierEventType(L, Pathfinding.GraphModifier.EventType.PostScan);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PreScan"))
                {
                    translator.PushPathfindingGraphModifierEventType(L, Pathfinding.GraphModifier.EventType.PreScan);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LatePostScan"))
                {
                    translator.PushPathfindingGraphModifierEventType(L, Pathfinding.GraphModifier.EventType.LatePostScan);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PreUpdate"))
                {
                    translator.PushPathfindingGraphModifierEventType(L, Pathfinding.GraphModifier.EventType.PreUpdate);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PostUpdate"))
                {
                    translator.PushPathfindingGraphModifierEventType(L, Pathfinding.GraphModifier.EventType.PostUpdate);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PostCacheLoad"))
                {
                    translator.PushPathfindingGraphModifierEventType(L, Pathfinding.GraphModifier.EventType.PostCacheLoad);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Pathfinding.GraphModifier.EventType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Pathfinding.GraphModifier.EventType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PathfindingRaycastModifierQualityWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Pathfinding.RaycastModifier.Quality), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Pathfinding.RaycastModifier.Quality), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Pathfinding.RaycastModifier.Quality), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Low", Pathfinding.RaycastModifier.Quality.Low);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Medium", Pathfinding.RaycastModifier.Quality.Medium);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "High", Pathfinding.RaycastModifier.Quality.High);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Highest", Pathfinding.RaycastModifier.Quality.Highest);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Pathfinding.RaycastModifier.Quality), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPathfindingRaycastModifierQuality(L, (Pathfinding.RaycastModifier.Quality)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Low"))
                {
                    translator.PushPathfindingRaycastModifierQuality(L, Pathfinding.RaycastModifier.Quality.Low);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Medium"))
                {
                    translator.PushPathfindingRaycastModifierQuality(L, Pathfinding.RaycastModifier.Quality.Medium);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "High"))
                {
                    translator.PushPathfindingRaycastModifierQuality(L, Pathfinding.RaycastModifier.Quality.High);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Highest"))
                {
                    translator.PushPathfindingRaycastModifierQuality(L, Pathfinding.RaycastModifier.Quality.Highest);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Pathfinding.RaycastModifier.Quality!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Pathfinding.RaycastModifier.Quality! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PathfindingSimpleSmoothModifierSmoothTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Pathfinding.SimpleSmoothModifier.SmoothType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Pathfinding.SimpleSmoothModifier.SmoothType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Pathfinding.SimpleSmoothModifier.SmoothType), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Simple", Pathfinding.SimpleSmoothModifier.SmoothType.Simple);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bezier", Pathfinding.SimpleSmoothModifier.SmoothType.Bezier);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OffsetSimple", Pathfinding.SimpleSmoothModifier.SmoothType.OffsetSimple);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CurvedNonuniform", Pathfinding.SimpleSmoothModifier.SmoothType.CurvedNonuniform);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Pathfinding.SimpleSmoothModifier.SmoothType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPathfindingSimpleSmoothModifierSmoothType(L, (Pathfinding.SimpleSmoothModifier.SmoothType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Simple"))
                {
                    translator.PushPathfindingSimpleSmoothModifierSmoothType(L, Pathfinding.SimpleSmoothModifier.SmoothType.Simple);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bezier"))
                {
                    translator.PushPathfindingSimpleSmoothModifierSmoothType(L, Pathfinding.SimpleSmoothModifier.SmoothType.Bezier);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OffsetSimple"))
                {
                    translator.PushPathfindingSimpleSmoothModifierSmoothType(L, Pathfinding.SimpleSmoothModifier.SmoothType.OffsetSimple);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CurvedNonuniform"))
                {
                    translator.PushPathfindingSimpleSmoothModifierSmoothType(L, Pathfinding.SimpleSmoothModifier.SmoothType.CurvedNonuniform);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Pathfinding.SimpleSmoothModifier.SmoothType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Pathfinding.SimpleSmoothModifier.SmoothType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PathfindingStartEndModifierExactnessWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Pathfinding.StartEndModifier.Exactness), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Pathfinding.StartEndModifier.Exactness), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Pathfinding.StartEndModifier.Exactness), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SnapToNode", Pathfinding.StartEndModifier.Exactness.SnapToNode);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Original", Pathfinding.StartEndModifier.Exactness.Original);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Interpolate", Pathfinding.StartEndModifier.Exactness.Interpolate);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ClosestOnNode", Pathfinding.StartEndModifier.Exactness.ClosestOnNode);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NodeConnection", Pathfinding.StartEndModifier.Exactness.NodeConnection);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Pathfinding.StartEndModifier.Exactness), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPathfindingStartEndModifierExactness(L, (Pathfinding.StartEndModifier.Exactness)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "SnapToNode"))
                {
                    translator.PushPathfindingStartEndModifierExactness(L, Pathfinding.StartEndModifier.Exactness.SnapToNode);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Original"))
                {
                    translator.PushPathfindingStartEndModifierExactness(L, Pathfinding.StartEndModifier.Exactness.Original);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Interpolate"))
                {
                    translator.PushPathfindingStartEndModifierExactness(L, Pathfinding.StartEndModifier.Exactness.Interpolate);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ClosestOnNode"))
                {
                    translator.PushPathfindingStartEndModifierExactness(L, Pathfinding.StartEndModifier.Exactness.ClosestOnNode);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NodeConnection"))
                {
                    translator.PushPathfindingStartEndModifierExactness(L, Pathfinding.StartEndModifier.Exactness.NodeConnection);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Pathfinding.StartEndModifier.Exactness!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Pathfinding.StartEndModifier.Exactness! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PathfindingBlockManagerBlockModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Pathfinding.BlockManager.BlockMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Pathfinding.BlockManager.BlockMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Pathfinding.BlockManager.BlockMode), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AllExceptSelector", Pathfinding.BlockManager.BlockMode.AllExceptSelector);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OnlySelector", Pathfinding.BlockManager.BlockMode.OnlySelector);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Pathfinding.BlockManager.BlockMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPathfindingBlockManagerBlockMode(L, (Pathfinding.BlockManager.BlockMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "AllExceptSelector"))
                {
                    translator.PushPathfindingBlockManagerBlockMode(L, Pathfinding.BlockManager.BlockMode.AllExceptSelector);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OnlySelector"))
                {
                    translator.PushPathfindingBlockManagerBlockMode(L, Pathfinding.BlockManager.BlockMode.OnlySelector);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Pathfinding.BlockManager.BlockMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Pathfinding.BlockManager.BlockMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class PathfindingRVORVOObstacleObstacleVertexWindingWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "KeepOut", Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding.KeepOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "KeepIn", Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding.KeepIn);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushPathfindingRVORVOObstacleObstacleVertexWinding(L, (Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "KeepOut"))
                {
                    translator.PushPathfindingRVORVOObstacleObstacleVertexWinding(L, Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding.KeepOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "KeepIn"))
                {
                    translator.PushPathfindingRVORVOObstacleObstacleVertexWinding(L, Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding.KeepIn);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class GoogleProtobufWireFormatWireTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Google.Protobuf.WireFormat.WireType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Google.Protobuf.WireFormat.WireType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Google.Protobuf.WireFormat.WireType), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Varint", Google.Protobuf.WireFormat.WireType.Varint);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fixed64", Google.Protobuf.WireFormat.WireType.Fixed64);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LengthDelimited", Google.Protobuf.WireFormat.WireType.LengthDelimited);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "StartGroup", Google.Protobuf.WireFormat.WireType.StartGroup);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EndGroup", Google.Protobuf.WireFormat.WireType.EndGroup);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fixed32", Google.Protobuf.WireFormat.WireType.Fixed32);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Google.Protobuf.WireFormat.WireType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushGoogleProtobufWireFormatWireType(L, (Google.Protobuf.WireFormat.WireType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Varint"))
                {
                    translator.PushGoogleProtobufWireFormatWireType(L, Google.Protobuf.WireFormat.WireType.Varint);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Fixed64"))
                {
                    translator.PushGoogleProtobufWireFormatWireType(L, Google.Protobuf.WireFormat.WireType.Fixed64);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LengthDelimited"))
                {
                    translator.PushGoogleProtobufWireFormatWireType(L, Google.Protobuf.WireFormat.WireType.LengthDelimited);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "StartGroup"))
                {
                    translator.PushGoogleProtobufWireFormatWireType(L, Google.Protobuf.WireFormat.WireType.StartGroup);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EndGroup"))
                {
                    translator.PushGoogleProtobufWireFormatWireType(L, Google.Protobuf.WireFormat.WireType.EndGroup);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Fixed32"))
                {
                    translator.PushGoogleProtobufWireFormatWireType(L, Google.Protobuf.WireFormat.WireType.Fixed32);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Google.Protobuf.WireFormat.WireType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Google.Protobuf.WireFormat.WireType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIBlendModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.BlendMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.BlendMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.BlendMode), L, null, 13, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Normal", FairyGUI.BlendMode.Normal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", FairyGUI.BlendMode.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Add", FairyGUI.BlendMode.Add);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Multiply", FairyGUI.BlendMode.Multiply);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Screen", FairyGUI.BlendMode.Screen);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Erase", FairyGUI.BlendMode.Erase);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mask", FairyGUI.BlendMode.Mask);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Below", FairyGUI.BlendMode.Below);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Off", FairyGUI.BlendMode.Off);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Custom1", FairyGUI.BlendMode.Custom1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Custom2", FairyGUI.BlendMode.Custom2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Custom3", FairyGUI.BlendMode.Custom3);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.BlendMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIBlendMode(L, (FairyGUI.BlendMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Normal"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.Normal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Add"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.Add);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Multiply"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.Multiply);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Screen"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.Screen);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Erase"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.Erase);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mask"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.Mask);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Below"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.Below);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Off"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.Off);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Custom1"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.Custom1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Custom2"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.Custom2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Custom3"))
                {
                    translator.PushFairyGUIBlendMode(L, FairyGUI.BlendMode.Custom3);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.BlendMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.BlendMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIHitTestModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.HitTestMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.HitTestMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.HitTestMode), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Default", FairyGUI.HitTestMode.Default);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Raycast", FairyGUI.HitTestMode.Raycast);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.HitTestMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIHitTestMode(L, (FairyGUI.HitTestMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Default"))
                {
                    translator.PushFairyGUIHitTestMode(L, FairyGUI.HitTestMode.Default);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Raycast"))
                {
                    translator.PushFairyGUIHitTestMode(L, FairyGUI.HitTestMode.Raycast);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.HitTestMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.HitTestMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIDestroyMethodWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.DestroyMethod), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.DestroyMethod), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.DestroyMethod), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Destroy", FairyGUI.DestroyMethod.Destroy);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unload", FairyGUI.DestroyMethod.Unload);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", FairyGUI.DestroyMethod.None);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.DestroyMethod), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIDestroyMethod(L, (FairyGUI.DestroyMethod)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Destroy"))
                {
                    translator.PushFairyGUIDestroyMethod(L, FairyGUI.DestroyMethod.Destroy);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Unload"))
                {
                    translator.PushFairyGUIDestroyMethod(L, FairyGUI.DestroyMethod.Unload);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushFairyGUIDestroyMethod(L, FairyGUI.DestroyMethod.None);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.DestroyMethod!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.DestroyMethod! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIEaseTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.EaseType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.EaseType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.EaseType), L, null, 33, 0, 0);

            Utils.RegisterEnumType(L, typeof(FairyGUI.EaseType));

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.EaseType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIEaseType(L, (FairyGUI.EaseType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

                try
				{
                    translator.TranslateToEnumToTop(L, typeof(FairyGUI.EaseType), 1);
				}
				catch (System.Exception e)
				{
					return LuaAPI.luaL_error(L, "cast to " + typeof(FairyGUI.EaseType) + " exception:" + e);
				}

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.EaseType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUITweenPropTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.TweenPropType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.TweenPropType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.TweenPropType), L, null, 18, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", FairyGUI.TweenPropType.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "X", FairyGUI.TweenPropType.X);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Y", FairyGUI.TweenPropType.Y);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Z", FairyGUI.TweenPropType.Z);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "XY", FairyGUI.TweenPropType.XY);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Position", FairyGUI.TweenPropType.Position);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Width", FairyGUI.TweenPropType.Width);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Height", FairyGUI.TweenPropType.Height);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Size", FairyGUI.TweenPropType.Size);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScaleX", FairyGUI.TweenPropType.ScaleX);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScaleY", FairyGUI.TweenPropType.ScaleY);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Scale", FairyGUI.TweenPropType.Scale);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Rotation", FairyGUI.TweenPropType.Rotation);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RotationX", FairyGUI.TweenPropType.RotationX);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RotationY", FairyGUI.TweenPropType.RotationY);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha", FairyGUI.TweenPropType.Alpha);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Progress", FairyGUI.TweenPropType.Progress);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.TweenPropType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUITweenPropType(L, (FairyGUI.TweenPropType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "X"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.X);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Y"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.Y);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Z"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.Z);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "XY"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.XY);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Position"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.Position);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Width"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.Width);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Height"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.Height);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Size"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.Size);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScaleX"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.ScaleX);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScaleY"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.ScaleY);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Scale"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.Scale);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Rotation"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.Rotation);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RotationX"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.RotationX);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RotationY"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.RotationY);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.Alpha);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Progress"))
                {
                    translator.PushFairyGUITweenPropType(L, FairyGUI.TweenPropType.Progress);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.TweenPropType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.TweenPropType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIPackageItemTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.PackageItemType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.PackageItemType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.PackageItemType), L, null, 10, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Image", FairyGUI.PackageItemType.Image);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MovieClip", FairyGUI.PackageItemType.MovieClip);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Sound", FairyGUI.PackageItemType.Sound);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Component", FairyGUI.PackageItemType.Component);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Atlas", FairyGUI.PackageItemType.Atlas);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Font", FairyGUI.PackageItemType.Font);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Swf", FairyGUI.PackageItemType.Swf);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Misc", FairyGUI.PackageItemType.Misc);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unknown", FairyGUI.PackageItemType.Unknown);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.PackageItemType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIPackageItemType(L, (FairyGUI.PackageItemType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Image"))
                {
                    translator.PushFairyGUIPackageItemType(L, FairyGUI.PackageItemType.Image);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MovieClip"))
                {
                    translator.PushFairyGUIPackageItemType(L, FairyGUI.PackageItemType.MovieClip);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Sound"))
                {
                    translator.PushFairyGUIPackageItemType(L, FairyGUI.PackageItemType.Sound);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Component"))
                {
                    translator.PushFairyGUIPackageItemType(L, FairyGUI.PackageItemType.Component);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Atlas"))
                {
                    translator.PushFairyGUIPackageItemType(L, FairyGUI.PackageItemType.Atlas);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Font"))
                {
                    translator.PushFairyGUIPackageItemType(L, FairyGUI.PackageItemType.Font);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Swf"))
                {
                    translator.PushFairyGUIPackageItemType(L, FairyGUI.PackageItemType.Swf);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Misc"))
                {
                    translator.PushFairyGUIPackageItemType(L, FairyGUI.PackageItemType.Misc);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Unknown"))
                {
                    translator.PushFairyGUIPackageItemType(L, FairyGUI.PackageItemType.Unknown);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.PackageItemType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.PackageItemType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIObjectTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.ObjectType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.ObjectType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.ObjectType), L, null, 18, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Image", FairyGUI.ObjectType.Image);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MovieClip", FairyGUI.ObjectType.MovieClip);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Swf", FairyGUI.ObjectType.Swf);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Graph", FairyGUI.ObjectType.Graph);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Loader", FairyGUI.ObjectType.Loader);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Group", FairyGUI.ObjectType.Group);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Text", FairyGUI.ObjectType.Text);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RichText", FairyGUI.ObjectType.RichText);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InputText", FairyGUI.ObjectType.InputText);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Component", FairyGUI.ObjectType.Component);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "List", FairyGUI.ObjectType.List);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Label", FairyGUI.ObjectType.Label);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Button", FairyGUI.ObjectType.Button);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ComboBox", FairyGUI.ObjectType.ComboBox);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ProgressBar", FairyGUI.ObjectType.ProgressBar);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Slider", FairyGUI.ObjectType.Slider);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScrollBar", FairyGUI.ObjectType.ScrollBar);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.ObjectType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIObjectType(L, (FairyGUI.ObjectType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Image"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.Image);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MovieClip"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.MovieClip);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Swf"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.Swf);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Graph"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.Graph);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Loader"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.Loader);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Group"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.Group);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Text"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.Text);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RichText"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.RichText);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InputText"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.InputText);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Component"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.Component);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "List"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.List);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Label"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.Label);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Button"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.Button);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ComboBox"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.ComboBox);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ProgressBar"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.ProgressBar);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Slider"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.Slider);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScrollBar"))
                {
                    translator.PushFairyGUIObjectType(L, FairyGUI.ObjectType.ScrollBar);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.ObjectType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.ObjectType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIAlignTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.AlignType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.AlignType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.AlignType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", FairyGUI.AlignType.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Center", FairyGUI.AlignType.Center);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", FairyGUI.AlignType.Right);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.AlignType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIAlignType(L, (FairyGUI.AlignType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushFairyGUIAlignType(L, FairyGUI.AlignType.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Center"))
                {
                    translator.PushFairyGUIAlignType(L, FairyGUI.AlignType.Center);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushFairyGUIAlignType(L, FairyGUI.AlignType.Right);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.AlignType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.AlignType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIVertAlignTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.VertAlignType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.VertAlignType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.VertAlignType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", FairyGUI.VertAlignType.Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Middle", FairyGUI.VertAlignType.Middle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom", FairyGUI.VertAlignType.Bottom);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.VertAlignType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIVertAlignType(L, (FairyGUI.VertAlignType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushFairyGUIVertAlignType(L, FairyGUI.VertAlignType.Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Middle"))
                {
                    translator.PushFairyGUIVertAlignType(L, FairyGUI.VertAlignType.Middle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom"))
                {
                    translator.PushFairyGUIVertAlignType(L, FairyGUI.VertAlignType.Bottom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.VertAlignType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.VertAlignType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIOverflowTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.OverflowType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.OverflowType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.OverflowType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Visible", FairyGUI.OverflowType.Visible);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Hidden", FairyGUI.OverflowType.Hidden);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Scroll", FairyGUI.OverflowType.Scroll);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.OverflowType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIOverflowType(L, (FairyGUI.OverflowType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Visible"))
                {
                    translator.PushFairyGUIOverflowType(L, FairyGUI.OverflowType.Visible);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Hidden"))
                {
                    translator.PushFairyGUIOverflowType(L, FairyGUI.OverflowType.Hidden);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Scroll"))
                {
                    translator.PushFairyGUIOverflowType(L, FairyGUI.OverflowType.Scroll);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.OverflowType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.OverflowType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIFillTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.FillType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.FillType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.FillType), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", FairyGUI.FillType.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Scale", FairyGUI.FillType.Scale);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScaleMatchHeight", FairyGUI.FillType.ScaleMatchHeight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScaleMatchWidth", FairyGUI.FillType.ScaleMatchWidth);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScaleFree", FairyGUI.FillType.ScaleFree);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScaleNoBorder", FairyGUI.FillType.ScaleNoBorder);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.FillType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIFillType(L, (FairyGUI.FillType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushFairyGUIFillType(L, FairyGUI.FillType.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Scale"))
                {
                    translator.PushFairyGUIFillType(L, FairyGUI.FillType.Scale);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScaleMatchHeight"))
                {
                    translator.PushFairyGUIFillType(L, FairyGUI.FillType.ScaleMatchHeight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScaleMatchWidth"))
                {
                    translator.PushFairyGUIFillType(L, FairyGUI.FillType.ScaleMatchWidth);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScaleFree"))
                {
                    translator.PushFairyGUIFillType(L, FairyGUI.FillType.ScaleFree);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScaleNoBorder"))
                {
                    translator.PushFairyGUIFillType(L, FairyGUI.FillType.ScaleNoBorder);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.FillType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.FillType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIAutoSizeTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.AutoSizeType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.AutoSizeType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.AutoSizeType), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", FairyGUI.AutoSizeType.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Both", FairyGUI.AutoSizeType.Both);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Height", FairyGUI.AutoSizeType.Height);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Shrink", FairyGUI.AutoSizeType.Shrink);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.AutoSizeType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIAutoSizeType(L, (FairyGUI.AutoSizeType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushFairyGUIAutoSizeType(L, FairyGUI.AutoSizeType.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Both"))
                {
                    translator.PushFairyGUIAutoSizeType(L, FairyGUI.AutoSizeType.Both);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Height"))
                {
                    translator.PushFairyGUIAutoSizeType(L, FairyGUI.AutoSizeType.Height);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Shrink"))
                {
                    translator.PushFairyGUIAutoSizeType(L, FairyGUI.AutoSizeType.Shrink);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.AutoSizeType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.AutoSizeType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIScrollTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.ScrollType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.ScrollType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.ScrollType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", FairyGUI.ScrollType.Horizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", FairyGUI.ScrollType.Vertical);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Both", FairyGUI.ScrollType.Both);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.ScrollType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIScrollType(L, (FairyGUI.ScrollType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushFairyGUIScrollType(L, FairyGUI.ScrollType.Horizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushFairyGUIScrollType(L, FairyGUI.ScrollType.Vertical);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Both"))
                {
                    translator.PushFairyGUIScrollType(L, FairyGUI.ScrollType.Both);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.ScrollType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.ScrollType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIScrollBarDisplayTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.ScrollBarDisplayType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.ScrollBarDisplayType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.ScrollBarDisplayType), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Default", FairyGUI.ScrollBarDisplayType.Default);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Visible", FairyGUI.ScrollBarDisplayType.Visible);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Auto", FairyGUI.ScrollBarDisplayType.Auto);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Hidden", FairyGUI.ScrollBarDisplayType.Hidden);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.ScrollBarDisplayType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIScrollBarDisplayType(L, (FairyGUI.ScrollBarDisplayType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Default"))
                {
                    translator.PushFairyGUIScrollBarDisplayType(L, FairyGUI.ScrollBarDisplayType.Default);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Visible"))
                {
                    translator.PushFairyGUIScrollBarDisplayType(L, FairyGUI.ScrollBarDisplayType.Visible);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Auto"))
                {
                    translator.PushFairyGUIScrollBarDisplayType(L, FairyGUI.ScrollBarDisplayType.Auto);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Hidden"))
                {
                    translator.PushFairyGUIScrollBarDisplayType(L, FairyGUI.ScrollBarDisplayType.Hidden);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.ScrollBarDisplayType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.ScrollBarDisplayType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIRelationTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.RelationType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.RelationType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.RelationType), L, null, 26, 0, 0);

            Utils.RegisterEnumType(L, typeof(FairyGUI.RelationType));

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.RelationType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIRelationType(L, (FairyGUI.RelationType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

                try
				{
                    translator.TranslateToEnumToTop(L, typeof(FairyGUI.RelationType), 1);
				}
				catch (System.Exception e)
				{
					return LuaAPI.luaL_error(L, "cast to " + typeof(FairyGUI.RelationType) + " exception:" + e);
				}

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.RelationType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIListLayoutTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.ListLayoutType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.ListLayoutType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.ListLayoutType), L, null, 6, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SingleColumn", FairyGUI.ListLayoutType.SingleColumn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SingleRow", FairyGUI.ListLayoutType.SingleRow);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FlowHorizontal", FairyGUI.ListLayoutType.FlowHorizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FlowVertical", FairyGUI.ListLayoutType.FlowVertical);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pagination", FairyGUI.ListLayoutType.Pagination);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.ListLayoutType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIListLayoutType(L, (FairyGUI.ListLayoutType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "SingleColumn"))
                {
                    translator.PushFairyGUIListLayoutType(L, FairyGUI.ListLayoutType.SingleColumn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SingleRow"))
                {
                    translator.PushFairyGUIListLayoutType(L, FairyGUI.ListLayoutType.SingleRow);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FlowHorizontal"))
                {
                    translator.PushFairyGUIListLayoutType(L, FairyGUI.ListLayoutType.FlowHorizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FlowVertical"))
                {
                    translator.PushFairyGUIListLayoutType(L, FairyGUI.ListLayoutType.FlowVertical);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Pagination"))
                {
                    translator.PushFairyGUIListLayoutType(L, FairyGUI.ListLayoutType.Pagination);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.ListLayoutType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.ListLayoutType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIListSelectionModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.ListSelectionMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.ListSelectionMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.ListSelectionMode), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Single", FairyGUI.ListSelectionMode.Single);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Multiple", FairyGUI.ListSelectionMode.Multiple);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Multiple_SingleClick", FairyGUI.ListSelectionMode.Multiple_SingleClick);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", FairyGUI.ListSelectionMode.None);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.ListSelectionMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIListSelectionMode(L, (FairyGUI.ListSelectionMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Single"))
                {
                    translator.PushFairyGUIListSelectionMode(L, FairyGUI.ListSelectionMode.Single);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Multiple"))
                {
                    translator.PushFairyGUIListSelectionMode(L, FairyGUI.ListSelectionMode.Multiple);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Multiple_SingleClick"))
                {
                    translator.PushFairyGUIListSelectionMode(L, FairyGUI.ListSelectionMode.Multiple_SingleClick);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushFairyGUIListSelectionMode(L, FairyGUI.ListSelectionMode.None);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.ListSelectionMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.ListSelectionMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIProgressTitleTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.ProgressTitleType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.ProgressTitleType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.ProgressTitleType), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Percent", FairyGUI.ProgressTitleType.Percent);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ValueAndMax", FairyGUI.ProgressTitleType.ValueAndMax);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Value", FairyGUI.ProgressTitleType.Value);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Max", FairyGUI.ProgressTitleType.Max);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.ProgressTitleType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIProgressTitleType(L, (FairyGUI.ProgressTitleType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Percent"))
                {
                    translator.PushFairyGUIProgressTitleType(L, FairyGUI.ProgressTitleType.Percent);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ValueAndMax"))
                {
                    translator.PushFairyGUIProgressTitleType(L, FairyGUI.ProgressTitleType.ValueAndMax);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Value"))
                {
                    translator.PushFairyGUIProgressTitleType(L, FairyGUI.ProgressTitleType.Value);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Max"))
                {
                    translator.PushFairyGUIProgressTitleType(L, FairyGUI.ProgressTitleType.Max);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.ProgressTitleType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.ProgressTitleType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIButtonModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.ButtonMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.ButtonMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.ButtonMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Common", FairyGUI.ButtonMode.Common);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Check", FairyGUI.ButtonMode.Check);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Radio", FairyGUI.ButtonMode.Radio);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.ButtonMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIButtonMode(L, (FairyGUI.ButtonMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Common"))
                {
                    translator.PushFairyGUIButtonMode(L, FairyGUI.ButtonMode.Common);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Check"))
                {
                    translator.PushFairyGUIButtonMode(L, FairyGUI.ButtonMode.Check);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Radio"))
                {
                    translator.PushFairyGUIButtonMode(L, FairyGUI.ButtonMode.Radio);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.ButtonMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.ButtonMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUITransitionActionTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.TransitionActionType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.TransitionActionType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.TransitionActionType), L, null, 18, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "XY", FairyGUI.TransitionActionType.XY);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Size", FairyGUI.TransitionActionType.Size);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Scale", FairyGUI.TransitionActionType.Scale);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pivot", FairyGUI.TransitionActionType.Pivot);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha", FairyGUI.TransitionActionType.Alpha);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Rotation", FairyGUI.TransitionActionType.Rotation);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Color", FairyGUI.TransitionActionType.Color);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Animation", FairyGUI.TransitionActionType.Animation);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Visible", FairyGUI.TransitionActionType.Visible);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Sound", FairyGUI.TransitionActionType.Sound);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Transition", FairyGUI.TransitionActionType.Transition);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Shake", FairyGUI.TransitionActionType.Shake);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ColorFilter", FairyGUI.TransitionActionType.ColorFilter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Skew", FairyGUI.TransitionActionType.Skew);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Text", FairyGUI.TransitionActionType.Text);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Icon", FairyGUI.TransitionActionType.Icon);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unknown", FairyGUI.TransitionActionType.Unknown);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.TransitionActionType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUITransitionActionType(L, (FairyGUI.TransitionActionType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "XY"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.XY);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Size"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Size);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Scale"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Scale);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Pivot"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Pivot);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Alpha);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Rotation"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Rotation);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Color"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Color);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Animation"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Animation);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Visible"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Visible);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Sound"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Sound);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Transition"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Transition);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Shake"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Shake);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ColorFilter"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.ColorFilter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Skew"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Skew);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Text"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Text);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Icon"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Icon);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Unknown"))
                {
                    translator.PushFairyGUITransitionActionType(L, FairyGUI.TransitionActionType.Unknown);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.TransitionActionType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.TransitionActionType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIGroupLayoutTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.GroupLayoutType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.GroupLayoutType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.GroupLayoutType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", FairyGUI.GroupLayoutType.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", FairyGUI.GroupLayoutType.Horizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", FairyGUI.GroupLayoutType.Vertical);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.GroupLayoutType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIGroupLayoutType(L, (FairyGUI.GroupLayoutType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushFairyGUIGroupLayoutType(L, FairyGUI.GroupLayoutType.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushFairyGUIGroupLayoutType(L, FairyGUI.GroupLayoutType.Horizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushFairyGUIGroupLayoutType(L, FairyGUI.GroupLayoutType.Vertical);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.GroupLayoutType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.GroupLayoutType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIChildrenRenderOrderWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.ChildrenRenderOrder), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.ChildrenRenderOrder), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.ChildrenRenderOrder), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ascent", FairyGUI.ChildrenRenderOrder.Ascent);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Descent", FairyGUI.ChildrenRenderOrder.Descent);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Arch", FairyGUI.ChildrenRenderOrder.Arch);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.ChildrenRenderOrder), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIChildrenRenderOrder(L, (FairyGUI.ChildrenRenderOrder)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Ascent"))
                {
                    translator.PushFairyGUIChildrenRenderOrder(L, FairyGUI.ChildrenRenderOrder.Ascent);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Descent"))
                {
                    translator.PushFairyGUIChildrenRenderOrder(L, FairyGUI.ChildrenRenderOrder.Descent);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Arch"))
                {
                    translator.PushFairyGUIChildrenRenderOrder(L, FairyGUI.ChildrenRenderOrder.Arch);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.ChildrenRenderOrder!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.ChildrenRenderOrder! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIPopupDirectionWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.PopupDirection), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.PopupDirection), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.PopupDirection), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Auto", FairyGUI.PopupDirection.Auto);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Up", FairyGUI.PopupDirection.Up);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Down", FairyGUI.PopupDirection.Down);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.PopupDirection), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIPopupDirection(L, (FairyGUI.PopupDirection)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Auto"))
                {
                    translator.PushFairyGUIPopupDirection(L, FairyGUI.PopupDirection.Auto);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Up"))
                {
                    translator.PushFairyGUIPopupDirection(L, FairyGUI.PopupDirection.Up);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Down"))
                {
                    translator.PushFairyGUIPopupDirection(L, FairyGUI.PopupDirection.Down);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.PopupDirection!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.PopupDirection! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIFlipTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.FlipType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.FlipType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.FlipType), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", FairyGUI.FlipType.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", FairyGUI.FlipType.Horizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", FairyGUI.FlipType.Vertical);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Both", FairyGUI.FlipType.Both);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.FlipType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIFlipType(L, (FairyGUI.FlipType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushFairyGUIFlipType(L, FairyGUI.FlipType.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushFairyGUIFlipType(L, FairyGUI.FlipType.Horizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushFairyGUIFlipType(L, FairyGUI.FlipType.Vertical);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Both"))
                {
                    translator.PushFairyGUIFlipType(L, FairyGUI.FlipType.Both);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.FlipType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.FlipType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIFillMethodWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.FillMethod), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.FillMethod), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.FillMethod), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", FairyGUI.FillMethod.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", FairyGUI.FillMethod.Horizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", FairyGUI.FillMethod.Vertical);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Radial90", FairyGUI.FillMethod.Radial90);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Radial180", FairyGUI.FillMethod.Radial180);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Radial360", FairyGUI.FillMethod.Radial360);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.FillMethod), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIFillMethod(L, (FairyGUI.FillMethod)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushFairyGUIFillMethod(L, FairyGUI.FillMethod.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushFairyGUIFillMethod(L, FairyGUI.FillMethod.Horizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushFairyGUIFillMethod(L, FairyGUI.FillMethod.Vertical);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Radial90"))
                {
                    translator.PushFairyGUIFillMethod(L, FairyGUI.FillMethod.Radial90);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Radial180"))
                {
                    translator.PushFairyGUIFillMethod(L, FairyGUI.FillMethod.Radial180);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Radial360"))
                {
                    translator.PushFairyGUIFillMethod(L, FairyGUI.FillMethod.Radial360);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.FillMethod!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.FillMethod! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIOriginHorizontalWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.OriginHorizontal), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.OriginHorizontal), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.OriginHorizontal), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", FairyGUI.OriginHorizontal.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", FairyGUI.OriginHorizontal.Right);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.OriginHorizontal), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIOriginHorizontal(L, (FairyGUI.OriginHorizontal)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushFairyGUIOriginHorizontal(L, FairyGUI.OriginHorizontal.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushFairyGUIOriginHorizontal(L, FairyGUI.OriginHorizontal.Right);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.OriginHorizontal!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.OriginHorizontal! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIOriginVerticalWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.OriginVertical), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.OriginVertical), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.OriginVertical), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", FairyGUI.OriginVertical.Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom", FairyGUI.OriginVertical.Bottom);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.OriginVertical), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIOriginVertical(L, (FairyGUI.OriginVertical)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushFairyGUIOriginVertical(L, FairyGUI.OriginVertical.Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom"))
                {
                    translator.PushFairyGUIOriginVertical(L, FairyGUI.OriginVertical.Bottom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.OriginVertical!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.OriginVertical! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIOrigin90Wrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.Origin90), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.Origin90), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.Origin90), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopLeft", FairyGUI.Origin90.TopLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopRight", FairyGUI.Origin90.TopRight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomLeft", FairyGUI.Origin90.BottomLeft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomRight", FairyGUI.Origin90.BottomRight);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.Origin90), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIOrigin90(L, (FairyGUI.Origin90)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "TopLeft"))
                {
                    translator.PushFairyGUIOrigin90(L, FairyGUI.Origin90.TopLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopRight"))
                {
                    translator.PushFairyGUIOrigin90(L, FairyGUI.Origin90.TopRight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomLeft"))
                {
                    translator.PushFairyGUIOrigin90(L, FairyGUI.Origin90.BottomLeft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomRight"))
                {
                    translator.PushFairyGUIOrigin90(L, FairyGUI.Origin90.BottomRight);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.Origin90!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.Origin90! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIOrigin180Wrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.Origin180), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.Origin180), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.Origin180), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", FairyGUI.Origin180.Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom", FairyGUI.Origin180.Bottom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", FairyGUI.Origin180.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", FairyGUI.Origin180.Right);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.Origin180), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIOrigin180(L, (FairyGUI.Origin180)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushFairyGUIOrigin180(L, FairyGUI.Origin180.Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom"))
                {
                    translator.PushFairyGUIOrigin180(L, FairyGUI.Origin180.Bottom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushFairyGUIOrigin180(L, FairyGUI.Origin180.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushFairyGUIOrigin180(L, FairyGUI.Origin180.Right);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.Origin180!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.Origin180! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIOrigin360Wrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.Origin360), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.Origin360), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.Origin360), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", FairyGUI.Origin360.Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom", FairyGUI.Origin360.Bottom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left", FairyGUI.Origin360.Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right", FairyGUI.Origin360.Right);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.Origin360), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIOrigin360(L, (FairyGUI.Origin360)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushFairyGUIOrigin360(L, FairyGUI.Origin360.Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom"))
                {
                    translator.PushFairyGUIOrigin360(L, FairyGUI.Origin360.Bottom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Left"))
                {
                    translator.PushFairyGUIOrigin360(L, FairyGUI.Origin360.Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right"))
                {
                    translator.PushFairyGUIOrigin360(L, FairyGUI.Origin360.Right);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.Origin360!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.Origin360! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIFitScreenWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.FitScreen), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.FitScreen), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.FitScreen), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", FairyGUI.FitScreen.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FitSize", FairyGUI.FitScreen.FitSize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FitWidthAndSetMiddle", FairyGUI.FitScreen.FitWidthAndSetMiddle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FitHeightAndSetCenter", FairyGUI.FitScreen.FitHeightAndSetCenter);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.FitScreen), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIFitScreen(L, (FairyGUI.FitScreen)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushFairyGUIFitScreen(L, FairyGUI.FitScreen.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FitSize"))
                {
                    translator.PushFairyGUIFitScreen(L, FairyGUI.FitScreen.FitSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FitWidthAndSetMiddle"))
                {
                    translator.PushFairyGUIFitScreen(L, FairyGUI.FitScreen.FitWidthAndSetMiddle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FitHeightAndSetCenter"))
                {
                    translator.PushFairyGUIFitScreen(L, FairyGUI.FitScreen.FitHeightAndSetCenter);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.FitScreen!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.FitScreen! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIUtilsHtmlElementTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.Utils.HtmlElementType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.Utils.HtmlElementType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.Utils.HtmlElementType), L, null, 8, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Text", FairyGUI.Utils.HtmlElementType.Text);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Link", FairyGUI.Utils.HtmlElementType.Link);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Image", FairyGUI.Utils.HtmlElementType.Image);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Input", FairyGUI.Utils.HtmlElementType.Input);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Select", FairyGUI.Utils.HtmlElementType.Select);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Object", FairyGUI.Utils.HtmlElementType.Object);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LinkEnd", FairyGUI.Utils.HtmlElementType.LinkEnd);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.Utils.HtmlElementType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIUtilsHtmlElementType(L, (FairyGUI.Utils.HtmlElementType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Text"))
                {
                    translator.PushFairyGUIUtilsHtmlElementType(L, FairyGUI.Utils.HtmlElementType.Text);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Link"))
                {
                    translator.PushFairyGUIUtilsHtmlElementType(L, FairyGUI.Utils.HtmlElementType.Link);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Image"))
                {
                    translator.PushFairyGUIUtilsHtmlElementType(L, FairyGUI.Utils.HtmlElementType.Image);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Input"))
                {
                    translator.PushFairyGUIUtilsHtmlElementType(L, FairyGUI.Utils.HtmlElementType.Input);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Select"))
                {
                    translator.PushFairyGUIUtilsHtmlElementType(L, FairyGUI.Utils.HtmlElementType.Select);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Object"))
                {
                    translator.PushFairyGUIUtilsHtmlElementType(L, FairyGUI.Utils.HtmlElementType.Object);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LinkEnd"))
                {
                    translator.PushFairyGUIUtilsHtmlElementType(L, FairyGUI.Utils.HtmlElementType.LinkEnd);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.Utils.HtmlElementType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.Utils.HtmlElementType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIUtilsXMLTagTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.Utils.XMLTagType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.Utils.XMLTagType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.Utils.XMLTagType), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Start", FairyGUI.Utils.XMLTagType.Start);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "End", FairyGUI.Utils.XMLTagType.End);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Void", FairyGUI.Utils.XMLTagType.Void);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CDATA", FairyGUI.Utils.XMLTagType.CDATA);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Comment", FairyGUI.Utils.XMLTagType.Comment);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Instruction", FairyGUI.Utils.XMLTagType.Instruction);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.Utils.XMLTagType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIUtilsXMLTagType(L, (FairyGUI.Utils.XMLTagType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Start"))
                {
                    translator.PushFairyGUIUtilsXMLTagType(L, FairyGUI.Utils.XMLTagType.Start);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "End"))
                {
                    translator.PushFairyGUIUtilsXMLTagType(L, FairyGUI.Utils.XMLTagType.End);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Void"))
                {
                    translator.PushFairyGUIUtilsXMLTagType(L, FairyGUI.Utils.XMLTagType.Void);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CDATA"))
                {
                    translator.PushFairyGUIUtilsXMLTagType(L, FairyGUI.Utils.XMLTagType.CDATA);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Comment"))
                {
                    translator.PushFairyGUIUtilsXMLTagType(L, FairyGUI.Utils.XMLTagType.Comment);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Instruction"))
                {
                    translator.PushFairyGUIUtilsXMLTagType(L, FairyGUI.Utils.XMLTagType.Instruction);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.Utils.XMLTagType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.Utils.XMLTagType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIRTLSupportDirectionTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.RTLSupport.DirectionType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.RTLSupport.DirectionType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.RTLSupport.DirectionType), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UNKNOW", FairyGUI.RTLSupport.DirectionType.UNKNOW);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LTR", FairyGUI.RTLSupport.DirectionType.LTR);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RTL", FairyGUI.RTLSupport.DirectionType.RTL);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NEUTRAL", FairyGUI.RTLSupport.DirectionType.NEUTRAL);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.RTLSupport.DirectionType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIRTLSupportDirectionType(L, (FairyGUI.RTLSupport.DirectionType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "UNKNOW"))
                {
                    translator.PushFairyGUIRTLSupportDirectionType(L, FairyGUI.RTLSupport.DirectionType.UNKNOW);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LTR"))
                {
                    translator.PushFairyGUIRTLSupportDirectionType(L, FairyGUI.RTLSupport.DirectionType.LTR);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RTL"))
                {
                    translator.PushFairyGUIRTLSupportDirectionType(L, FairyGUI.RTLSupport.DirectionType.RTL);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NEUTRAL"))
                {
                    translator.PushFairyGUIRTLSupportDirectionType(L, FairyGUI.RTLSupport.DirectionType.NEUTRAL);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.RTLSupport.DirectionType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.RTLSupport.DirectionType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUITextFormatSpecialStyleWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.TextFormat.SpecialStyle), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.TextFormat.SpecialStyle), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.TextFormat.SpecialStyle), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", FairyGUI.TextFormat.SpecialStyle.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Superscript", FairyGUI.TextFormat.SpecialStyle.Superscript);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Subscript", FairyGUI.TextFormat.SpecialStyle.Subscript);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.TextFormat.SpecialStyle), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUITextFormatSpecialStyle(L, (FairyGUI.TextFormat.SpecialStyle)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushFairyGUITextFormatSpecialStyle(L, FairyGUI.TextFormat.SpecialStyle.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Superscript"))
                {
                    translator.PushFairyGUITextFormatSpecialStyle(L, FairyGUI.TextFormat.SpecialStyle.Superscript);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Subscript"))
                {
                    translator.PushFairyGUITextFormatSpecialStyle(L, FairyGUI.TextFormat.SpecialStyle.Subscript);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.TextFormat.SpecialStyle!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.TextFormat.SpecialStyle! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIGPathPointCurveTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.GPathPoint.CurveType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.GPathPoint.CurveType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.GPathPoint.CurveType), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CRSpline", FairyGUI.GPathPoint.CurveType.CRSpline);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bezier", FairyGUI.GPathPoint.CurveType.Bezier);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CubicBezier", FairyGUI.GPathPoint.CurveType.CubicBezier);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Straight", FairyGUI.GPathPoint.CurveType.Straight);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.GPathPoint.CurveType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIGPathPointCurveType(L, (FairyGUI.GPathPoint.CurveType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "CRSpline"))
                {
                    translator.PushFairyGUIGPathPointCurveType(L, FairyGUI.GPathPoint.CurveType.CRSpline);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bezier"))
                {
                    translator.PushFairyGUIGPathPointCurveType(L, FairyGUI.GPathPoint.CurveType.Bezier);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CubicBezier"))
                {
                    translator.PushFairyGUIGPathPointCurveType(L, FairyGUI.GPathPoint.CurveType.CubicBezier);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Straight"))
                {
                    translator.PushFairyGUIGPathPointCurveType(L, FairyGUI.GPathPoint.CurveType.Straight);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.GPathPoint.CurveType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.GPathPoint.CurveType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIControllerActionActionTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.ControllerAction.ActionType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.ControllerAction.ActionType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.ControllerAction.ActionType), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PlayTransition", FairyGUI.ControllerAction.ActionType.PlayTransition);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ChangePage", FairyGUI.ControllerAction.ActionType.ChangePage);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.ControllerAction.ActionType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIControllerActionActionType(L, (FairyGUI.ControllerAction.ActionType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "PlayTransition"))
                {
                    translator.PushFairyGUIControllerActionActionType(L, FairyGUI.ControllerAction.ActionType.PlayTransition);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ChangePage"))
                {
                    translator.PushFairyGUIControllerActionActionType(L, FairyGUI.ControllerAction.ActionType.ChangePage);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.ControllerAction.ActionType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.ControllerAction.ActionType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIUIConfigConfigKeyWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.UIConfig.ConfigKey), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.UIConfig.ConfigKey), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.UIConfig.ConfigKey), L, null, 28, 0, 0);

            Utils.RegisterEnumType(L, typeof(FairyGUI.UIConfig.ConfigKey));

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.UIConfig.ConfigKey), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIUIConfigConfigKey(L, (FairyGUI.UIConfig.ConfigKey)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

                try
				{
                    translator.TranslateToEnumToTop(L, typeof(FairyGUI.UIConfig.ConfigKey), 1);
				}
				catch (System.Exception e)
				{
					return LuaAPI.luaL_error(L, "cast to " + typeof(FairyGUI.UIConfig.ConfigKey) + " exception:" + e);
				}

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.UIConfig.ConfigKey! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIUIContentScalerScaleModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.UIContentScaler.ScaleMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.UIContentScaler.ScaleMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.UIContentScaler.ScaleMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ConstantPixelSize", FairyGUI.UIContentScaler.ScaleMode.ConstantPixelSize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScaleWithScreenSize", FairyGUI.UIContentScaler.ScaleMode.ScaleWithScreenSize);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ConstantPhysicalSize", FairyGUI.UIContentScaler.ScaleMode.ConstantPhysicalSize);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.UIContentScaler.ScaleMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIUIContentScalerScaleMode(L, (FairyGUI.UIContentScaler.ScaleMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "ConstantPixelSize"))
                {
                    translator.PushFairyGUIUIContentScalerScaleMode(L, FairyGUI.UIContentScaler.ScaleMode.ConstantPixelSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScaleWithScreenSize"))
                {
                    translator.PushFairyGUIUIContentScalerScaleMode(L, FairyGUI.UIContentScaler.ScaleMode.ScaleWithScreenSize);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ConstantPhysicalSize"))
                {
                    translator.PushFairyGUIUIContentScalerScaleMode(L, FairyGUI.UIContentScaler.ScaleMode.ConstantPhysicalSize);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.UIContentScaler.ScaleMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.UIContentScaler.ScaleMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIUIContentScalerScreenMatchModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.UIContentScaler.ScreenMatchMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.UIContentScaler.ScreenMatchMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.UIContentScaler.ScreenMatchMode), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MatchWidthOrHeight", FairyGUI.UIContentScaler.ScreenMatchMode.MatchWidthOrHeight);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MatchWidth", FairyGUI.UIContentScaler.ScreenMatchMode.MatchWidth);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MatchHeight", FairyGUI.UIContentScaler.ScreenMatchMode.MatchHeight);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.UIContentScaler.ScreenMatchMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIUIContentScalerScreenMatchMode(L, (FairyGUI.UIContentScaler.ScreenMatchMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "MatchWidthOrHeight"))
                {
                    translator.PushFairyGUIUIContentScalerScreenMatchMode(L, FairyGUI.UIContentScaler.ScreenMatchMode.MatchWidthOrHeight);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MatchWidth"))
                {
                    translator.PushFairyGUIUIContentScalerScreenMatchMode(L, FairyGUI.UIContentScaler.ScreenMatchMode.MatchWidth);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MatchHeight"))
                {
                    translator.PushFairyGUIUIContentScalerScreenMatchMode(L, FairyGUI.UIContentScaler.ScreenMatchMode.MatchHeight);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.UIContentScaler.ScreenMatchMode!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.UIContentScaler.ScreenMatchMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class XLuaGenFlagWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(XLua.GenFlag), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(XLua.GenFlag), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(XLua.GenFlag), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "No", XLua.GenFlag.No);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(XLua.GenFlag), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushXLuaGenFlag(L, (XLua.GenFlag)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "No"))
                {
                    translator.PushXLuaGenFlag(L, XLua.GenFlag.No);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for XLua.GenFlag!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for XLua.GenFlag! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class XLuaOptimizeFlagWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(XLua.OptimizeFlag), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(XLua.OptimizeFlag), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(XLua.OptimizeFlag), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Default", XLua.OptimizeFlag.Default);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PackAsTable", XLua.OptimizeFlag.PackAsTable);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(XLua.OptimizeFlag), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushXLuaOptimizeFlag(L, (XLua.OptimizeFlag)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Default"))
                {
                    translator.PushXLuaOptimizeFlag(L, XLua.OptimizeFlag.Default);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PackAsTable"))
                {
                    translator.PushXLuaOptimizeFlag(L, XLua.OptimizeFlag.PackAsTable);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for XLua.OptimizeFlag!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for XLua.OptimizeFlag! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class XLuaHotfixFlagWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(XLua.HotfixFlag), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(XLua.HotfixFlag), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(XLua.HotfixFlag), L, null, 11, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Stateless", XLua.HotfixFlag.Stateless);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ValueTypeBoxing", XLua.HotfixFlag.ValueTypeBoxing);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IgnoreProperty", XLua.HotfixFlag.IgnoreProperty);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IgnoreNotPublic", XLua.HotfixFlag.IgnoreNotPublic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Inline", XLua.HotfixFlag.Inline);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IntKey", XLua.HotfixFlag.IntKey);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AdaptByDelegate", XLua.HotfixFlag.AdaptByDelegate);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IgnoreCompilerGenerated", XLua.HotfixFlag.IgnoreCompilerGenerated);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NoBaseProxy", XLua.HotfixFlag.NoBaseProxy);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(XLua.HotfixFlag), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushXLuaHotfixFlag(L, (XLua.HotfixFlag)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Stateless"))
                {
                    translator.PushXLuaHotfixFlag(L, XLua.HotfixFlag.Stateless);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ValueTypeBoxing"))
                {
                    translator.PushXLuaHotfixFlag(L, XLua.HotfixFlag.ValueTypeBoxing);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IgnoreProperty"))
                {
                    translator.PushXLuaHotfixFlag(L, XLua.HotfixFlag.IgnoreProperty);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IgnoreNotPublic"))
                {
                    translator.PushXLuaHotfixFlag(L, XLua.HotfixFlag.IgnoreNotPublic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Inline"))
                {
                    translator.PushXLuaHotfixFlag(L, XLua.HotfixFlag.Inline);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IntKey"))
                {
                    translator.PushXLuaHotfixFlag(L, XLua.HotfixFlag.IntKey);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AdaptByDelegate"))
                {
                    translator.PushXLuaHotfixFlag(L, XLua.HotfixFlag.AdaptByDelegate);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IgnoreCompilerGenerated"))
                {
                    translator.PushXLuaHotfixFlag(L, XLua.HotfixFlag.IgnoreCompilerGenerated);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NoBaseProxy"))
                {
                    translator.PushXLuaHotfixFlag(L, XLua.HotfixFlag.NoBaseProxy);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for XLua.HotfixFlag!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for XLua.HotfixFlag! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class XLuaLuaTypesWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(XLua.LuaTypes), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(XLua.LuaTypes), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(XLua.LuaTypes), L, null, 11, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_TNONE", XLua.LuaTypes.LUA_TNONE);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_TNIL", XLua.LuaTypes.LUA_TNIL);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_TNUMBER", XLua.LuaTypes.LUA_TNUMBER);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_TSTRING", XLua.LuaTypes.LUA_TSTRING);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_TBOOLEAN", XLua.LuaTypes.LUA_TBOOLEAN);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_TTABLE", XLua.LuaTypes.LUA_TTABLE);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_TFUNCTION", XLua.LuaTypes.LUA_TFUNCTION);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_TUSERDATA", XLua.LuaTypes.LUA_TUSERDATA);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_TTHREAD", XLua.LuaTypes.LUA_TTHREAD);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_TLIGHTUSERDATA", XLua.LuaTypes.LUA_TLIGHTUSERDATA);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(XLua.LuaTypes), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushXLuaLuaTypes(L, (XLua.LuaTypes)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_TNONE"))
                {
                    translator.PushXLuaLuaTypes(L, XLua.LuaTypes.LUA_TNONE);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_TNIL"))
                {
                    translator.PushXLuaLuaTypes(L, XLua.LuaTypes.LUA_TNIL);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_TNUMBER"))
                {
                    translator.PushXLuaLuaTypes(L, XLua.LuaTypes.LUA_TNUMBER);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_TSTRING"))
                {
                    translator.PushXLuaLuaTypes(L, XLua.LuaTypes.LUA_TSTRING);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_TBOOLEAN"))
                {
                    translator.PushXLuaLuaTypes(L, XLua.LuaTypes.LUA_TBOOLEAN);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_TTABLE"))
                {
                    translator.PushXLuaLuaTypes(L, XLua.LuaTypes.LUA_TTABLE);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_TFUNCTION"))
                {
                    translator.PushXLuaLuaTypes(L, XLua.LuaTypes.LUA_TFUNCTION);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_TUSERDATA"))
                {
                    translator.PushXLuaLuaTypes(L, XLua.LuaTypes.LUA_TUSERDATA);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_TTHREAD"))
                {
                    translator.PushXLuaLuaTypes(L, XLua.LuaTypes.LUA_TTHREAD);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_TLIGHTUSERDATA"))
                {
                    translator.PushXLuaLuaTypes(L, XLua.LuaTypes.LUA_TLIGHTUSERDATA);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for XLua.LuaTypes!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for XLua.LuaTypes! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class XLuaLuaGCOptionsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(XLua.LuaGCOptions), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(XLua.LuaGCOptions), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(XLua.LuaGCOptions), L, null, 9, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_GCSTOP", XLua.LuaGCOptions.LUA_GCSTOP);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_GCRESTART", XLua.LuaGCOptions.LUA_GCRESTART);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_GCCOLLECT", XLua.LuaGCOptions.LUA_GCCOLLECT);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_GCCOUNT", XLua.LuaGCOptions.LUA_GCCOUNT);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_GCCOUNTB", XLua.LuaGCOptions.LUA_GCCOUNTB);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_GCSTEP", XLua.LuaGCOptions.LUA_GCSTEP);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_GCSETPAUSE", XLua.LuaGCOptions.LUA_GCSETPAUSE);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_GCSETSTEPMUL", XLua.LuaGCOptions.LUA_GCSETSTEPMUL);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(XLua.LuaGCOptions), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushXLuaLuaGCOptions(L, (XLua.LuaGCOptions)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_GCSTOP"))
                {
                    translator.PushXLuaLuaGCOptions(L, XLua.LuaGCOptions.LUA_GCSTOP);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_GCRESTART"))
                {
                    translator.PushXLuaLuaGCOptions(L, XLua.LuaGCOptions.LUA_GCRESTART);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_GCCOLLECT"))
                {
                    translator.PushXLuaLuaGCOptions(L, XLua.LuaGCOptions.LUA_GCCOLLECT);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_GCCOUNT"))
                {
                    translator.PushXLuaLuaGCOptions(L, XLua.LuaGCOptions.LUA_GCCOUNT);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_GCCOUNTB"))
                {
                    translator.PushXLuaLuaGCOptions(L, XLua.LuaGCOptions.LUA_GCCOUNTB);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_GCSTEP"))
                {
                    translator.PushXLuaLuaGCOptions(L, XLua.LuaGCOptions.LUA_GCSTEP);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_GCSETPAUSE"))
                {
                    translator.PushXLuaLuaGCOptions(L, XLua.LuaGCOptions.LUA_GCSETPAUSE);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_GCSETSTEPMUL"))
                {
                    translator.PushXLuaLuaGCOptions(L, XLua.LuaGCOptions.LUA_GCSETSTEPMUL);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for XLua.LuaGCOptions!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for XLua.LuaGCOptions! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class XLuaLuaThreadStatusWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(XLua.LuaThreadStatus), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(XLua.LuaThreadStatus), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(XLua.LuaThreadStatus), L, null, 8, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_RESUME_ERROR", XLua.LuaThreadStatus.LUA_RESUME_ERROR);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_OK", XLua.LuaThreadStatus.LUA_OK);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_YIELD", XLua.LuaThreadStatus.LUA_YIELD);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_ERRRUN", XLua.LuaThreadStatus.LUA_ERRRUN);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_ERRSYNTAX", XLua.LuaThreadStatus.LUA_ERRSYNTAX);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_ERRMEM", XLua.LuaThreadStatus.LUA_ERRMEM);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_ERRERR", XLua.LuaThreadStatus.LUA_ERRERR);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(XLua.LuaThreadStatus), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushXLuaLuaThreadStatus(L, (XLua.LuaThreadStatus)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_RESUME_ERROR"))
                {
                    translator.PushXLuaLuaThreadStatus(L, XLua.LuaThreadStatus.LUA_RESUME_ERROR);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_OK"))
                {
                    translator.PushXLuaLuaThreadStatus(L, XLua.LuaThreadStatus.LUA_OK);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_YIELD"))
                {
                    translator.PushXLuaLuaThreadStatus(L, XLua.LuaThreadStatus.LUA_YIELD);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_ERRRUN"))
                {
                    translator.PushXLuaLuaThreadStatus(L, XLua.LuaThreadStatus.LUA_ERRRUN);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_ERRSYNTAX"))
                {
                    translator.PushXLuaLuaThreadStatus(L, XLua.LuaThreadStatus.LUA_ERRSYNTAX);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_ERRMEM"))
                {
                    translator.PushXLuaLuaThreadStatus(L, XLua.LuaThreadStatus.LUA_ERRMEM);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_ERRERR"))
                {
                    translator.PushXLuaLuaThreadStatus(L, XLua.LuaThreadStatus.LUA_ERRERR);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for XLua.LuaThreadStatus!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for XLua.LuaThreadStatus! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class XLuaLazyMemberTypesWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(XLua.LazyMemberTypes), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(XLua.LazyMemberTypes), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(XLua.LazyMemberTypes), L, null, 7, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Method", XLua.LazyMemberTypes.Method);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FieldGet", XLua.LazyMemberTypes.FieldGet);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FieldSet", XLua.LazyMemberTypes.FieldSet);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PropertyGet", XLua.LazyMemberTypes.PropertyGet);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PropertySet", XLua.LazyMemberTypes.PropertySet);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Event", XLua.LazyMemberTypes.Event);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(XLua.LazyMemberTypes), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushXLuaLazyMemberTypes(L, (XLua.LazyMemberTypes)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Method"))
                {
                    translator.PushXLuaLazyMemberTypes(L, XLua.LazyMemberTypes.Method);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FieldGet"))
                {
                    translator.PushXLuaLazyMemberTypes(L, XLua.LazyMemberTypes.FieldGet);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FieldSet"))
                {
                    translator.PushXLuaLazyMemberTypes(L, XLua.LazyMemberTypes.FieldSet);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PropertyGet"))
                {
                    translator.PushXLuaLazyMemberTypes(L, XLua.LazyMemberTypes.PropertyGet);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PropertySet"))
                {
                    translator.PushXLuaLazyMemberTypes(L, XLua.LazyMemberTypes.PropertySet);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Event"))
                {
                    translator.PushXLuaLazyMemberTypes(L, XLua.LazyMemberTypes.Event);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for XLua.LazyMemberTypes!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for XLua.LazyMemberTypes! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class XLuaTemplateEngineTokenTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(XLua.TemplateEngine.TokenType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(XLua.TemplateEngine.TokenType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(XLua.TemplateEngine.TokenType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Code", XLua.TemplateEngine.TokenType.Code);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Eval", XLua.TemplateEngine.TokenType.Eval);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Text", XLua.TemplateEngine.TokenType.Text);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(XLua.TemplateEngine.TokenType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushXLuaTemplateEngineTokenType(L, (XLua.TemplateEngine.TokenType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Code"))
                {
                    translator.PushXLuaTemplateEngineTokenType(L, XLua.TemplateEngine.TokenType.Code);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Eval"))
                {
                    translator.PushXLuaTemplateEngineTokenType(L, XLua.TemplateEngine.TokenType.Eval);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Text"))
                {
                    translator.PushXLuaTemplateEngineTokenType(L, XLua.TemplateEngine.TokenType.Text);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for XLua.TemplateEngine.TokenType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for XLua.TemplateEngine.TokenType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class MikuLuaProfilerLuaTypesWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(MikuLuaProfiler.LuaTypes), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(MikuLuaProfiler.LuaTypes), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(MikuLuaProfiler.LuaTypes), L, null, 11, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_TNONE", MikuLuaProfiler.LuaTypes.LUA_TNONE);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_TNIL", MikuLuaProfiler.LuaTypes.LUA_TNIL);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_TBOOLEAN", MikuLuaProfiler.LuaTypes.LUA_TBOOLEAN);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_TLIGHTUSERDATA", MikuLuaProfiler.LuaTypes.LUA_TLIGHTUSERDATA);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_TNUMBER", MikuLuaProfiler.LuaTypes.LUA_TNUMBER);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_TSTRING", MikuLuaProfiler.LuaTypes.LUA_TSTRING);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_TTABLE", MikuLuaProfiler.LuaTypes.LUA_TTABLE);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_TFUNCTION", MikuLuaProfiler.LuaTypes.LUA_TFUNCTION);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_TUSERDATA", MikuLuaProfiler.LuaTypes.LUA_TUSERDATA);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_TTHREAD", MikuLuaProfiler.LuaTypes.LUA_TTHREAD);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(MikuLuaProfiler.LuaTypes), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushMikuLuaProfilerLuaTypes(L, (MikuLuaProfiler.LuaTypes)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_TNONE"))
                {
                    translator.PushMikuLuaProfilerLuaTypes(L, MikuLuaProfiler.LuaTypes.LUA_TNONE);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_TNIL"))
                {
                    translator.PushMikuLuaProfilerLuaTypes(L, MikuLuaProfiler.LuaTypes.LUA_TNIL);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_TBOOLEAN"))
                {
                    translator.PushMikuLuaProfilerLuaTypes(L, MikuLuaProfiler.LuaTypes.LUA_TBOOLEAN);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_TLIGHTUSERDATA"))
                {
                    translator.PushMikuLuaProfilerLuaTypes(L, MikuLuaProfiler.LuaTypes.LUA_TLIGHTUSERDATA);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_TNUMBER"))
                {
                    translator.PushMikuLuaProfilerLuaTypes(L, MikuLuaProfiler.LuaTypes.LUA_TNUMBER);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_TSTRING"))
                {
                    translator.PushMikuLuaProfilerLuaTypes(L, MikuLuaProfiler.LuaTypes.LUA_TSTRING);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_TTABLE"))
                {
                    translator.PushMikuLuaProfilerLuaTypes(L, MikuLuaProfiler.LuaTypes.LUA_TTABLE);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_TFUNCTION"))
                {
                    translator.PushMikuLuaProfilerLuaTypes(L, MikuLuaProfiler.LuaTypes.LUA_TFUNCTION);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_TUSERDATA"))
                {
                    translator.PushMikuLuaProfilerLuaTypes(L, MikuLuaProfiler.LuaTypes.LUA_TUSERDATA);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_TTHREAD"))
                {
                    translator.PushMikuLuaProfilerLuaTypes(L, MikuLuaProfiler.LuaTypes.LUA_TTHREAD);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for MikuLuaProfiler.LuaTypes!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for MikuLuaProfiler.LuaTypes! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class MikuLuaProfilerLuaGCOptionsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(MikuLuaProfiler.LuaGCOptions), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(MikuLuaProfiler.LuaGCOptions), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(MikuLuaProfiler.LuaGCOptions), L, null, 9, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_GCSTOP", MikuLuaProfiler.LuaGCOptions.LUA_GCSTOP);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_GCRESTART", MikuLuaProfiler.LuaGCOptions.LUA_GCRESTART);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_GCCOLLECT", MikuLuaProfiler.LuaGCOptions.LUA_GCCOLLECT);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_GCCOUNT", MikuLuaProfiler.LuaGCOptions.LUA_GCCOUNT);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_GCCOUNTB", MikuLuaProfiler.LuaGCOptions.LUA_GCCOUNTB);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_GCSTEP", MikuLuaProfiler.LuaGCOptions.LUA_GCSTEP);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_GCSETPAUSE", MikuLuaProfiler.LuaGCOptions.LUA_GCSETPAUSE);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LUA_GCSETSTEPMUL", MikuLuaProfiler.LuaGCOptions.LUA_GCSETSTEPMUL);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(MikuLuaProfiler.LuaGCOptions), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushMikuLuaProfilerLuaGCOptions(L, (MikuLuaProfiler.LuaGCOptions)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_GCSTOP"))
                {
                    translator.PushMikuLuaProfilerLuaGCOptions(L, MikuLuaProfiler.LuaGCOptions.LUA_GCSTOP);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_GCRESTART"))
                {
                    translator.PushMikuLuaProfilerLuaGCOptions(L, MikuLuaProfiler.LuaGCOptions.LUA_GCRESTART);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_GCCOLLECT"))
                {
                    translator.PushMikuLuaProfilerLuaGCOptions(L, MikuLuaProfiler.LuaGCOptions.LUA_GCCOLLECT);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_GCCOUNT"))
                {
                    translator.PushMikuLuaProfilerLuaGCOptions(L, MikuLuaProfiler.LuaGCOptions.LUA_GCCOUNT);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_GCCOUNTB"))
                {
                    translator.PushMikuLuaProfilerLuaGCOptions(L, MikuLuaProfiler.LuaGCOptions.LUA_GCCOUNTB);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_GCSTEP"))
                {
                    translator.PushMikuLuaProfilerLuaGCOptions(L, MikuLuaProfiler.LuaGCOptions.LUA_GCSTEP);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_GCSETPAUSE"))
                {
                    translator.PushMikuLuaProfilerLuaGCOptions(L, MikuLuaProfiler.LuaGCOptions.LUA_GCSETPAUSE);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LUA_GCSETSTEPMUL"))
                {
                    translator.PushMikuLuaProfilerLuaGCOptions(L, MikuLuaProfiler.LuaGCOptions.LUA_GCSETSTEPMUL);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for MikuLuaProfiler.LuaGCOptions!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for MikuLuaProfiler.LuaGCOptions! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class MikuLuaProfilerTKWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(MikuLuaProfiler.TK), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(MikuLuaProfiler.TK), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(MikuLuaProfiler.TK), L, null, 35, 0, 0);

            Utils.RegisterEnumType(L, typeof(MikuLuaProfiler.TK));

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(MikuLuaProfiler.TK), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushMikuLuaProfilerTK(L, (MikuLuaProfiler.TK)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

                try
				{
                    translator.TranslateToEnumToTop(L, typeof(MikuLuaProfiler.TK), 1);
				}
				catch (System.Exception e)
				{
					return LuaAPI.luaL_error(L, "cast to " + typeof(MikuLuaProfiler.TK) + " exception:" + e);
				}

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for MikuLuaProfiler.TK! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DCETModelAwaiterStatusWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DCET.Model.AwaiterStatus), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DCET.Model.AwaiterStatus), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DCET.Model.AwaiterStatus), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pending", DCET.Model.AwaiterStatus.Pending);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Succeeded", DCET.Model.AwaiterStatus.Succeeded);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Faulted", DCET.Model.AwaiterStatus.Faulted);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Canceled", DCET.Model.AwaiterStatus.Canceled);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DCET.Model.AwaiterStatus), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDCETModelAwaiterStatus(L, (DCET.Model.AwaiterStatus)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Pending"))
                {
                    translator.PushDCETModelAwaiterStatus(L, DCET.Model.AwaiterStatus.Pending);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Succeeded"))
                {
                    translator.PushDCETModelAwaiterStatus(L, DCET.Model.AwaiterStatus.Succeeded);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Faulted"))
                {
                    translator.PushDCETModelAwaiterStatus(L, DCET.Model.AwaiterStatus.Faulted);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Canceled"))
                {
                    translator.PushDCETModelAwaiterStatus(L, DCET.Model.AwaiterStatus.Canceled);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DCET.Model.AwaiterStatus!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DCET.Model.AwaiterStatus! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DCETModelEnvKeyWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DCET.Model.EnvKey), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DCET.Model.EnvKey), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DCET.Model.EnvKey), L, null, 2, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ChannelError", DCET.Model.EnvKey.ChannelError);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DCET.Model.EnvKey), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDCETModelEnvKey(L, (DCET.Model.EnvKey)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "ChannelError"))
                {
                    translator.PushDCETModelEnvKey(L, DCET.Model.EnvKey.ChannelError);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DCET.Model.EnvKey!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DCET.Model.EnvKey! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DCETModelLogTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DCET.Model.LogType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DCET.Model.LogType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DCET.Model.LogType), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Warning", DCET.Model.LogType.Warning);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Info", DCET.Model.LogType.Info);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Debug", DCET.Model.LogType.Debug);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Error", DCET.Model.LogType.Error);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DCET.Model.LogType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDCETModelLogType(L, (DCET.Model.LogType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Warning"))
                {
                    translator.PushDCETModelLogType(L, DCET.Model.LogType.Warning);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Info"))
                {
                    translator.PushDCETModelLogType(L, DCET.Model.LogType.Info);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Debug"))
                {
                    translator.PushDCETModelLogType(L, DCET.Model.LogType.Debug);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Error"))
                {
                    translator.PushDCETModelLogType(L, DCET.Model.LogType.Error);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DCET.Model.LogType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DCET.Model.LogType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DCETModelEntityStatusWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DCET.Model.EntityStatus), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DCET.Model.EntityStatus), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DCET.Model.EntityStatus), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", DCET.Model.EntityStatus.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IsFromPool", DCET.Model.EntityStatus.IsFromPool);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IsRegister", DCET.Model.EntityStatus.IsRegister);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IsComponent", DCET.Model.EntityStatus.IsComponent);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DCET.Model.EntityStatus), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDCETModelEntityStatus(L, (DCET.Model.EntityStatus)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushDCETModelEntityStatus(L, DCET.Model.EntityStatus.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IsFromPool"))
                {
                    translator.PushDCETModelEntityStatus(L, DCET.Model.EntityStatus.IsFromPool);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IsRegister"))
                {
                    translator.PushDCETModelEntityStatus(L, DCET.Model.EntityStatus.IsRegister);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IsComponent"))
                {
                    translator.PushDCETModelEntityStatus(L, DCET.Model.EntityStatus.IsComponent);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DCET.Model.EntityStatus!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DCET.Model.EntityStatus! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DCETModelSceneTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DCET.Model.SceneType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DCET.Model.SceneType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DCET.Model.SceneType), L, null, 9, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Process", DCET.Model.SceneType.Process);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Manager", DCET.Model.SceneType.Manager);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Realm", DCET.Model.SceneType.Realm);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Gate", DCET.Model.SceneType.Gate);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Http", DCET.Model.SceneType.Http);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Location", DCET.Model.SceneType.Location);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Map", DCET.Model.SceneType.Map);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Client", DCET.Model.SceneType.Client);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DCET.Model.SceneType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDCETModelSceneType(L, (DCET.Model.SceneType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Process"))
                {
                    translator.PushDCETModelSceneType(L, DCET.Model.SceneType.Process);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Manager"))
                {
                    translator.PushDCETModelSceneType(L, DCET.Model.SceneType.Manager);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Realm"))
                {
                    translator.PushDCETModelSceneType(L, DCET.Model.SceneType.Realm);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Gate"))
                {
                    translator.PushDCETModelSceneType(L, DCET.Model.SceneType.Gate);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Http"))
                {
                    translator.PushDCETModelSceneType(L, DCET.Model.SceneType.Http);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Location"))
                {
                    translator.PushDCETModelSceneType(L, DCET.Model.SceneType.Location);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Map"))
                {
                    translator.PushDCETModelSceneType(L, DCET.Model.SceneType.Map);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Client"))
                {
                    translator.PushDCETModelSceneType(L, DCET.Model.SceneType.Client);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DCET.Model.SceneType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DCET.Model.SceneType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DCETModelAppTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DCET.Model.AppType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DCET.Model.AppType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DCET.Model.AppType), L, null, 16, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", DCET.Model.AppType.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Manager", DCET.Model.AppType.Manager);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Realm", DCET.Model.AppType.Realm);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Gate", DCET.Model.AppType.Gate);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Http", DCET.Model.AppType.Http);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DB", DCET.Model.AppType.DB);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Location", DCET.Model.AppType.Location);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Map", DCET.Model.AppType.Map);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BenchmarkWebsocketServer", DCET.Model.AppType.BenchmarkWebsocketServer);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BenchmarkWebsocketClient", DCET.Model.AppType.BenchmarkWebsocketClient);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Robot", DCET.Model.AppType.Robot);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Benchmark", DCET.Model.AppType.Benchmark);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ClientH", DCET.Model.AppType.ClientH);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ClientM", DCET.Model.AppType.ClientM);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AllServer", DCET.Model.AppType.AllServer);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DCET.Model.AppType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDCETModelAppType(L, (DCET.Model.AppType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushDCETModelAppType(L, DCET.Model.AppType.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Manager"))
                {
                    translator.PushDCETModelAppType(L, DCET.Model.AppType.Manager);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Realm"))
                {
                    translator.PushDCETModelAppType(L, DCET.Model.AppType.Realm);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Gate"))
                {
                    translator.PushDCETModelAppType(L, DCET.Model.AppType.Gate);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Http"))
                {
                    translator.PushDCETModelAppType(L, DCET.Model.AppType.Http);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DB"))
                {
                    translator.PushDCETModelAppType(L, DCET.Model.AppType.DB);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Location"))
                {
                    translator.PushDCETModelAppType(L, DCET.Model.AppType.Location);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Map"))
                {
                    translator.PushDCETModelAppType(L, DCET.Model.AppType.Map);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BenchmarkWebsocketServer"))
                {
                    translator.PushDCETModelAppType(L, DCET.Model.AppType.BenchmarkWebsocketServer);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BenchmarkWebsocketClient"))
                {
                    translator.PushDCETModelAppType(L, DCET.Model.AppType.BenchmarkWebsocketClient);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Robot"))
                {
                    translator.PushDCETModelAppType(L, DCET.Model.AppType.Robot);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Benchmark"))
                {
                    translator.PushDCETModelAppType(L, DCET.Model.AppType.Benchmark);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ClientH"))
                {
                    translator.PushDCETModelAppType(L, DCET.Model.AppType.ClientH);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ClientM"))
                {
                    translator.PushDCETModelAppType(L, DCET.Model.AppType.ClientM);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AllServer"))
                {
                    translator.PushDCETModelAppType(L, DCET.Model.AppType.AllServer);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DCET.Model.AppType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DCET.Model.AppType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DCETModelMotionTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DCET.Model.MotionType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DCET.Model.MotionType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DCET.Model.MotionType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", DCET.Model.MotionType.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Idle", DCET.Model.MotionType.Idle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Run", DCET.Model.MotionType.Run);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DCET.Model.MotionType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDCETModelMotionType(L, (DCET.Model.MotionType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushDCETModelMotionType(L, DCET.Model.MotionType.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Idle"))
                {
                    translator.PushDCETModelMotionType(L, DCET.Model.MotionType.Idle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Run"))
                {
                    translator.PushDCETModelMotionType(L, DCET.Model.MotionType.Run);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DCET.Model.MotionType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DCET.Model.MotionType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class MicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamBufferTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamBufferType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamBufferType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamBufferType), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Small", Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamBufferType.Small);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Large", Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamBufferType.Large);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamBufferType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamBufferType(L, (Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamBufferType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Small"))
                {
                    translator.PushMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamBufferType(L, Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamBufferType.Small);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Large"))
                {
                    translator.PushMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamBufferType(L, Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamBufferType.Large);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamBufferType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamBufferType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class MicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamDiscardReasonWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamDiscardReason), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamDiscardReason), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamDiscardReason), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TooLarge", Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamDiscardReason.TooLarge);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "EnoughFree", Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamDiscardReason.EnoughFree);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamDiscardReason), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamDiscardReason(L, (Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamDiscardReason)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "TooLarge"))
                {
                    translator.PushMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamDiscardReason(L, Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamDiscardReason.TooLarge);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "EnoughFree"))
                {
                    translator.PushMicrosoftIORecyclableMemoryStreamManagerEventsMemoryStreamDiscardReason(L, Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamDiscardReason.EnoughFree);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamDiscardReason!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Microsoft.IO.RecyclableMemoryStreamManager.Events.MemoryStreamDiscardReason! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DCETModelMapTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DCET.Model.MapType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DCET.Model.MapType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DCET.Model.MapType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "City", DCET.Model.MapType.City);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Field", DCET.Model.MapType.Field);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Copy", DCET.Model.MapType.Copy);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DCET.Model.MapType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDCETModelMapType(L, (DCET.Model.MapType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "City"))
                {
                    translator.PushDCETModelMapType(L, DCET.Model.MapType.City);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Field"))
                {
                    translator.PushDCETModelMapType(L, DCET.Model.MapType.Field);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Copy"))
                {
                    translator.PushDCETModelMapType(L, DCET.Model.MapType.Copy);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DCET.Model.MapType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DCET.Model.MapType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
}