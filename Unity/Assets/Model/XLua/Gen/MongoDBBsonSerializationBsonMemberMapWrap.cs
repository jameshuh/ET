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
    public class MongoDBBsonSerializationBsonMemberMapWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.Serialization.BsonMemberMap);
			Utils.BeginObjectRegister(type, L, translator, 0, 14, 17, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ApplyDefaultValue", _m_ApplyDefaultValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Freeze", _m_Freeze);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSerializer", _m_GetSerializer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Reset", _m_Reset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDefaultValue", _m_SetDefaultValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetElementName", _m_SetElementName);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetIdGenerator", _m_SetIdGenerator);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetIgnoreIfDefault", _m_SetIgnoreIfDefault);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetIgnoreIfNull", _m_SetIgnoreIfNull);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetIsRequired", _m_SetIsRequired);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetOrder", _m_SetOrder);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetSerializer", _m_SetSerializer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetShouldSerializeMethod", _m_SetShouldSerializeMethod);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ShouldSerialize", _m_ShouldSerialize);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ClassMap", _g_get_ClassMap);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MemberName", _g_get_MemberName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MemberType", _g_get_MemberType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MemberTypeIsBsonValue", _g_get_MemberTypeIsBsonValue);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ElementName", _g_get_ElementName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Order", _g_get_Order);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MemberInfo", _g_get_MemberInfo);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Getter", _g_get_Getter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Setter", _g_get_Setter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IdGenerator", _g_get_IdGenerator);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsDefaultValueSpecified", _g_get_IsDefaultValueSpecified);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsRequired", _g_get_IsRequired);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ShouldSerializeMethod", _g_get_ShouldSerializeMethod);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IgnoreIfDefault", _g_get_IgnoreIfDefault);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IgnoreIfNull", _g_get_IgnoreIfNull);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DefaultValue", _g_get_DefaultValue);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsReadOnly", _g_get_IsReadOnly);
            
			
			
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
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<MongoDB.Bson.Serialization.BsonClassMap>(L, 2) && translator.Assignable<System.Reflection.MemberInfo>(L, 3))
				{
					MongoDB.Bson.Serialization.BsonClassMap _classMap = (MongoDB.Bson.Serialization.BsonClassMap)translator.GetObject(L, 2, typeof(MongoDB.Bson.Serialization.BsonClassMap));
					System.Reflection.MemberInfo _memberInfo = (System.Reflection.MemberInfo)translator.GetObject(L, 3, typeof(System.Reflection.MemberInfo));
					
					MongoDB.Bson.Serialization.BsonMemberMap gen_ret = new MongoDB.Bson.Serialization.BsonMemberMap(_classMap, _memberInfo);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.BsonMemberMap constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ApplyDefaultValue(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _obj = translator.GetObject(L, 2, typeof(object));
                    
                    gen_to_be_invoked.ApplyDefaultValue( _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Freeze(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Freeze(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSerializer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        MongoDB.Bson.Serialization.IBsonSerializer gen_ret = gen_to_be_invoked.GetSerializer(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Reset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        MongoDB.Bson.Serialization.BsonMemberMap gen_ret = gen_to_be_invoked.Reset(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDefaultValue(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Func<object>>(L, 2)) 
                {
                    System.Func<object> _defaultValueCreator = translator.GetDelegate<System.Func<object>>(L, 2);
                    
                        MongoDB.Bson.Serialization.BsonMemberMap gen_ret = gen_to_be_invoked.SetDefaultValue( _defaultValueCreator );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object _defaultValue = translator.GetObject(L, 2, typeof(object));
                    
                        MongoDB.Bson.Serialization.BsonMemberMap gen_ret = gen_to_be_invoked.SetDefaultValue( _defaultValue );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.BsonMemberMap.SetDefaultValue!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetElementName(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _elementName = LuaAPI.lua_tostring(L, 2);
                    
                        MongoDB.Bson.Serialization.BsonMemberMap gen_ret = gen_to_be_invoked.SetElementName( _elementName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIdGenerator(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.Serialization.IIdGenerator _idGenerator = (MongoDB.Bson.Serialization.IIdGenerator)translator.GetObject(L, 2, typeof(MongoDB.Bson.Serialization.IIdGenerator));
                    
                        MongoDB.Bson.Serialization.BsonMemberMap gen_ret = gen_to_be_invoked.SetIdGenerator( _idGenerator );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIgnoreIfDefault(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _ignoreIfDefault = LuaAPI.lua_toboolean(L, 2);
                    
                        MongoDB.Bson.Serialization.BsonMemberMap gen_ret = gen_to_be_invoked.SetIgnoreIfDefault( _ignoreIfDefault );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIgnoreIfNull(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _ignoreIfNull = LuaAPI.lua_toboolean(L, 2);
                    
                        MongoDB.Bson.Serialization.BsonMemberMap gen_ret = gen_to_be_invoked.SetIgnoreIfNull( _ignoreIfNull );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIsRequired(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _isRequired = LuaAPI.lua_toboolean(L, 2);
                    
                        MongoDB.Bson.Serialization.BsonMemberMap gen_ret = gen_to_be_invoked.SetIsRequired( _isRequired );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetOrder(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _order = LuaAPI.xlua_tointeger(L, 2);
                    
                        MongoDB.Bson.Serialization.BsonMemberMap gen_ret = gen_to_be_invoked.SetOrder( _order );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetSerializer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.Serialization.IBsonSerializer _serializer = (MongoDB.Bson.Serialization.IBsonSerializer)translator.GetObject(L, 2, typeof(MongoDB.Bson.Serialization.IBsonSerializer));
                    
                        MongoDB.Bson.Serialization.BsonMemberMap gen_ret = gen_to_be_invoked.SetSerializer( _serializer );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetShouldSerializeMethod(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Func<object, bool> _shouldSerializeMethod = translator.GetDelegate<System.Func<object, bool>>(L, 2);
                    
                        MongoDB.Bson.Serialization.BsonMemberMap gen_ret = gen_to_be_invoked.SetShouldSerializeMethod( _shouldSerializeMethod );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ShouldSerialize(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _obj = translator.GetObject(L, 2, typeof(object));
                    object _value = translator.GetObject(L, 3, typeof(object));
                    
                        bool gen_ret = gen_to_be_invoked.ShouldSerialize( _obj, _value );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ClassMap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ClassMap);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MemberName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.MemberName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MemberType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.MemberType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MemberTypeIsBsonValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.MemberTypeIsBsonValue);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ElementName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.ElementName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Order(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Order);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MemberInfo(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.MemberInfo);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Getter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Getter);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Setter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Setter);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IdGenerator(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.IdGenerator);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsDefaultValueSpecified(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsDefaultValueSpecified);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsRequired(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsRequired);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ShouldSerializeMethod(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ShouldSerializeMethod);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IgnoreIfDefault(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IgnoreIfDefault);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IgnoreIfNull(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IgnoreIfNull);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DefaultValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.DefaultValue);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsReadOnly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonMemberMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonMemberMap)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsReadOnly);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
