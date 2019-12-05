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
    public class MongoDBBsonBsonValueWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.BsonValue);
			Utils.BeginObjectRegister(type, L, translator, 3, 18, 57, 0);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__lt", __LTMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__le", __LEMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__eq", __EqMeta);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "get_Item", _m_get_Item);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "set_Item", _m_set_Item);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clone", _m_Clone);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CompareTo", _m_CompareTo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CompareTypeTo", _m_CompareTypeTo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DeepClone", _m_DeepClone);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", _m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", _m_GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToBoolean", _m_ToBoolean);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToDecimal", _m_ToDecimal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToDecimal128", _m_ToDecimal128);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToDouble", _m_ToDouble);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToInt32", _m_ToInt32);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToInt64", _m_ToInt64);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToLocalTime", _m_ToLocalTime);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToNullableLocalTime", _m_ToNullableLocalTime);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToNullableUniversalTime", _m_ToNullableUniversalTime);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToUniversalTime", _m_ToUniversalTime);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsBoolean", _g_get_AsBoolean);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsBsonArray", _g_get_AsBsonArray);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsBsonBinaryData", _g_get_AsBsonBinaryData);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsBsonDateTime", _g_get_AsBsonDateTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsBsonDocument", _g_get_AsBsonDocument);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsBsonJavaScript", _g_get_AsBsonJavaScript);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsBsonJavaScriptWithScope", _g_get_AsBsonJavaScriptWithScope);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsBsonMaxKey", _g_get_AsBsonMaxKey);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsBsonMinKey", _g_get_AsBsonMinKey);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsBsonNull", _g_get_AsBsonNull);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsBsonRegularExpression", _g_get_AsBsonRegularExpression);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsBsonSymbol", _g_get_AsBsonSymbol);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsBsonTimestamp", _g_get_AsBsonTimestamp);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsBsonUndefined", _g_get_AsBsonUndefined);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsBsonValue", _g_get_AsBsonValue);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsByteArray", _g_get_AsByteArray);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsDecimal", _g_get_AsDecimal);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsDecimal128", _g_get_AsDecimal128);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsDouble", _g_get_AsDouble);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsGuid", _g_get_AsGuid);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsInt32", _g_get_AsInt32);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsInt64", _g_get_AsInt64);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsNullableBoolean", _g_get_AsNullableBoolean);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsNullableDecimal", _g_get_AsNullableDecimal);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsNullableDecimal128", _g_get_AsNullableDecimal128);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsNullableDouble", _g_get_AsNullableDouble);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsNullableGuid", _g_get_AsNullableGuid);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsNullableInt32", _g_get_AsNullableInt32);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsNullableInt64", _g_get_AsNullableInt64);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsNullableObjectId", _g_get_AsNullableObjectId);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsObjectId", _g_get_AsObjectId);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsRegex", _g_get_AsRegex);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AsString", _g_get_AsString);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "BsonType", _g_get_BsonType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsBoolean", _g_get_IsBoolean);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsBsonArray", _g_get_IsBsonArray);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsBsonBinaryData", _g_get_IsBsonBinaryData);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsBsonDateTime", _g_get_IsBsonDateTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsBsonDocument", _g_get_IsBsonDocument);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsBsonJavaScript", _g_get_IsBsonJavaScript);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsBsonJavaScriptWithScope", _g_get_IsBsonJavaScriptWithScope);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsBsonMaxKey", _g_get_IsBsonMaxKey);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsBsonMinKey", _g_get_IsBsonMinKey);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsBsonNull", _g_get_IsBsonNull);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsBsonRegularExpression", _g_get_IsBsonRegularExpression);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsBsonSymbol", _g_get_IsBsonSymbol);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsBsonTimestamp", _g_get_IsBsonTimestamp);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsBsonUndefined", _g_get_IsBsonUndefined);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsDecimal128", _g_get_IsDecimal128);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsDouble", _g_get_IsDouble);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsGuid", _g_get_IsGuid);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsInt32", _g_get_IsInt32);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsInt64", _g_get_IsInt64);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsNumeric", _g_get_IsNumeric);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsObjectId", _g_get_IsObjectId);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsString", _g_get_IsString);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsValidDateTime", _g_get_IsValidDateTime);
            
			
			
			Utils.EndObjectRegister(type, L, translator, __CSIndexer, __NewIndexer,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Create", _m_Create_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "MongoDB.Bson.BsonValue does not have a constructor!");
        }
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __CSIndexer(RealStatePtr L)
        {
			try {
			    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				
				if (translator.Assignable<MongoDB.Bson.BsonValue>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					
					MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
					int index = LuaAPI.xlua_tointeger(L, 2);
					LuaAPI.lua_pushboolean(L, true);
					translator.Push(L, gen_to_be_invoked[index]);
					return 2;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			
            LuaAPI.lua_pushboolean(L, false);
			return 1;
        }
		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __NewIndexer(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
			try {
				
				if (translator.Assignable<MongoDB.Bson.BsonValue>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && translator.Assignable<MongoDB.Bson.BsonValue>(L, 3))
				{
					
					MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
					int key = LuaAPI.xlua_tointeger(L, 2);
					gen_to_be_invoked[key] = (MongoDB.Bson.BsonValue)translator.GetObject(L, 3, typeof(MongoDB.Bson.BsonValue));
					LuaAPI.lua_pushboolean(L, true);
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			
			LuaAPI.lua_pushboolean(L, false);
            return 1;
        }
		
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __LTMeta(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			
				if (translator.Assignable<MongoDB.Bson.BsonValue>(L, 1) && translator.Assignable<MongoDB.Bson.BsonValue>(L, 2))
				{
					MongoDB.Bson.BsonValue leftside = (MongoDB.Bson.BsonValue)translator.GetObject(L, 1, typeof(MongoDB.Bson.BsonValue));
					MongoDB.Bson.BsonValue rightside = (MongoDB.Bson.BsonValue)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonValue));
					
					LuaAPI.lua_pushboolean(L, leftside < rightside);
					
					return 1;
				}
            
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of < operator, need MongoDB.Bson.BsonValue!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __LEMeta(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			
				if (translator.Assignable<MongoDB.Bson.BsonValue>(L, 1) && translator.Assignable<MongoDB.Bson.BsonValue>(L, 2))
				{
					MongoDB.Bson.BsonValue leftside = (MongoDB.Bson.BsonValue)translator.GetObject(L, 1, typeof(MongoDB.Bson.BsonValue));
					MongoDB.Bson.BsonValue rightside = (MongoDB.Bson.BsonValue)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonValue));
					
					LuaAPI.lua_pushboolean(L, leftside <= rightside);
					
					return 1;
				}
            
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of <= operator, need MongoDB.Bson.BsonValue!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __EqMeta(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			
				if (translator.Assignable<MongoDB.Bson.BsonValue>(L, 1) && translator.Assignable<MongoDB.Bson.BsonValue>(L, 2))
				{
					MongoDB.Bson.BsonValue leftside = (MongoDB.Bson.BsonValue)translator.GetObject(L, 1, typeof(MongoDB.Bson.BsonValue));
					MongoDB.Bson.BsonValue rightside = (MongoDB.Bson.BsonValue)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonValue));
					
					LuaAPI.lua_pushboolean(L, leftside == rightside);
					
					return 1;
				}
            
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of == operator, need MongoDB.Bson.BsonValue!");
            
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_get_Item(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
					string key = LuaAPI.lua_tostring(L, 2);
					translator.Push(L, gen_to_be_invoked[key]);
					
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_set_Item(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
					string key = LuaAPI.lua_tostring(L, 2);
					gen_to_be_invoked[key] = (MongoDB.Bson.BsonValue)translator.GetObject(L, 3, typeof(MongoDB.Bson.BsonValue));
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Create_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    object _value = translator.GetObject(L, 1, typeof(object));
                    
                        MongoDB.Bson.BsonValue gen_ret = MongoDB.Bson.BsonValue.Create( _value );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clone(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        MongoDB.Bson.BsonValue gen_ret = gen_to_be_invoked.Clone(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CompareTo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.BsonValue _other = (MongoDB.Bson.BsonValue)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonValue));
                    
                        int gen_ret = gen_to_be_invoked.CompareTo( _other );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CompareTypeTo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.BsonValue _other = (MongoDB.Bson.BsonValue)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonValue));
                    
                        int gen_ret = gen_to_be_invoked.CompareTypeTo( _other );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DeepClone(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        MongoDB.Bson.BsonValue gen_ret = gen_to_be_invoked.DeepClone(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Equals(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<MongoDB.Bson.BsonValue>(L, 2)) 
                {
                    MongoDB.Bson.BsonValue _rhs = (MongoDB.Bson.BsonValue)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonValue));
                    
                        bool gen_ret = gen_to_be_invoked.Equals( _rhs );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object _obj = translator.GetObject(L, 2, typeof(object));
                    
                        bool gen_ret = gen_to_be_invoked.Equals( _obj );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.BsonValue.Equals!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHashCode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int gen_ret = gen_to_be_invoked.GetHashCode(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToBoolean(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.ToBoolean(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToDecimal(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        decimal gen_ret = gen_to_be_invoked.ToDecimal(  );
                        translator.PushDecimal(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToDecimal128(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        MongoDB.Bson.Decimal128 gen_ret = gen_to_be_invoked.ToDecimal128(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToDouble(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        double gen_ret = gen_to_be_invoked.ToDouble(  );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToInt32(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int gen_ret = gen_to_be_invoked.ToInt32(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToInt64(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        long gen_ret = gen_to_be_invoked.ToInt64(  );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToLocalTime(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.DateTime gen_ret = gen_to_be_invoked.ToLocalTime(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToNullableLocalTime(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Nullable<System.DateTime> gen_ret = gen_to_be_invoked.ToNullableLocalTime(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToNullableUniversalTime(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Nullable<System.DateTime> gen_ret = gen_to_be_invoked.ToNullableUniversalTime(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToUniversalTime(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.DateTime gen_ret = gen_to_be_invoked.ToUniversalTime(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsBoolean(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.AsBoolean);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsBsonArray(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AsBsonArray);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsBsonBinaryData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AsBsonBinaryData);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsBsonDateTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AsBsonDateTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsBsonDocument(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AsBsonDocument);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsBsonJavaScript(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AsBsonJavaScript);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsBsonJavaScriptWithScope(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AsBsonJavaScriptWithScope);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsBsonMaxKey(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AsBsonMaxKey);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsBsonMinKey(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AsBsonMinKey);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsBsonNull(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AsBsonNull);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsBsonRegularExpression(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AsBsonRegularExpression);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsBsonSymbol(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AsBsonSymbol);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsBsonTimestamp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AsBsonTimestamp);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsBsonUndefined(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AsBsonUndefined);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsBsonValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AsBsonValue);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsByteArray(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.AsByteArray);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsDecimal(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.PushDecimal(L, gen_to_be_invoked.AsDecimal);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsDecimal128(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AsDecimal128);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsDouble(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.AsDouble);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsGuid(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AsGuid);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsInt32(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.AsInt32);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsInt64(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushint64(L, gen_to_be_invoked.AsInt64);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsNullableBoolean(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.AsNullableBoolean);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsNullableDecimal(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.AsNullableDecimal);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsNullableDecimal128(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.AsNullableDecimal128);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsNullableDouble(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.AsNullableDouble);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsNullableGuid(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.AsNullableGuid);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsNullableInt32(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.AsNullableInt32);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsNullableInt64(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.AsNullableInt64);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsNullableObjectId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.AsNullableObjectId);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsObjectId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AsObjectId);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsRegex(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AsRegex);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AsString(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.AsString);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BsonType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                translator.PushMongoDBBsonBsonType(L, gen_to_be_invoked.BsonType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsBoolean(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsBoolean);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsBsonArray(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsBsonArray);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsBsonBinaryData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsBsonBinaryData);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsBsonDateTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsBsonDateTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsBsonDocument(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsBsonDocument);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsBsonJavaScript(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsBsonJavaScript);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsBsonJavaScriptWithScope(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsBsonJavaScriptWithScope);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsBsonMaxKey(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsBsonMaxKey);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsBsonMinKey(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsBsonMinKey);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsBsonNull(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsBsonNull);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsBsonRegularExpression(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsBsonRegularExpression);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsBsonSymbol(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsBsonSymbol);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsBsonTimestamp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsBsonTimestamp);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsBsonUndefined(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsBsonUndefined);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsDecimal128(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsDecimal128);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsDouble(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsDouble);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsGuid(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsGuid);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsInt32(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsInt32);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsInt64(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsInt64);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsNumeric(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsNumeric);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsObjectId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsObjectId);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsString(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsString);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsValidDateTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonValue gen_to_be_invoked = (MongoDB.Bson.BsonValue)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsValidDateTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
