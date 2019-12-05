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
    public class MongoDBBsonSerializationBsonClassMapWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.Serialization.BsonClassMap);
			Utils.BeginObjectRegister(type, L, translator, 0, 32, 18, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AutoMap", _m_AutoMap);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CreateInstance", _m_CreateInstance);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Freeze", _m_Freeze);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMemberMap", _m_GetMemberMap);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMemberMapForElement", _m_GetMemberMapForElement);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MapConstructor", _m_MapConstructor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MapCreator", _m_MapCreator);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MapExtraElementsField", _m_MapExtraElementsField);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MapExtraElementsMember", _m_MapExtraElementsMember);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MapExtraElementsProperty", _m_MapExtraElementsProperty);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MapFactoryMethod", _m_MapFactoryMethod);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MapField", _m_MapField);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MapIdField", _m_MapIdField);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MapIdMember", _m_MapIdMember);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MapIdProperty", _m_MapIdProperty);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MapMember", _m_MapMember);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MapProperty", _m_MapProperty);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Reset", _m_Reset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetCreator", _m_SetCreator);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDiscriminator", _m_SetDiscriminator);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDiscriminatorIsRequired", _m_SetDiscriminatorIsRequired);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetExtraElementsMember", _m_SetExtraElementsMember);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddKnownType", _m_AddKnownType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetIdMember", _m_SetIdMember);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetIgnoreExtraElements", _m_SetIgnoreExtraElements);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetIgnoreExtraElementsIsInherited", _m_SetIgnoreExtraElementsIsInherited);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetIsRootClass", _m_SetIsRootClass);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnmapConstructor", _m_UnmapConstructor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnmapFactoryMethod", _m_UnmapFactoryMethod);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnmapField", _m_UnmapField);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnmapMember", _m_UnmapMember);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnmapProperty", _m_UnmapProperty);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "AllMemberMaps", _g_get_AllMemberMaps);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "BaseClassMap", _g_get_BaseClassMap);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ClassType", _g_get_ClassType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CreatorMaps", _g_get_CreatorMaps);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ConventionPack", _g_get_ConventionPack);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DeclaredMemberMaps", _g_get_DeclaredMemberMaps);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Discriminator", _g_get_Discriminator);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DiscriminatorIsRequired", _g_get_DiscriminatorIsRequired);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ExtraElementsMemberMap", _g_get_ExtraElementsMemberMap);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "HasCreatorMaps", _g_get_HasCreatorMaps);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "HasRootClass", _g_get_HasRootClass);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IdMemberMap", _g_get_IdMemberMap);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IgnoreExtraElements", _g_get_IgnoreExtraElements);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IgnoreExtraElementsIsInherited", _g_get_IgnoreExtraElementsIsInherited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsAnonymous", _g_get_IsAnonymous);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsFrozen", _g_get_IsFrozen);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsRootClass", _g_get_IsRootClass);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "KnownTypes", _g_get_KnownTypes);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 6, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetMemberInfoType", _m_GetMemberInfoType_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRegisteredClassMaps", _m_GetRegisteredClassMaps_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsClassMapRegistered", _m_IsClassMapRegistered_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LookupClassMap", _m_LookupClassMap_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RegisterClassMap", _m_RegisterClassMap_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Type>(L, 2))
				{
					System.Type _classType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
					
					MongoDB.Bson.Serialization.BsonClassMap gen_ret = new MongoDB.Bson.Serialization.BsonClassMap(_classType);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<System.Type>(L, 2) && translator.Assignable<MongoDB.Bson.Serialization.BsonClassMap>(L, 3))
				{
					System.Type _classType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
					MongoDB.Bson.Serialization.BsonClassMap _baseClassMap = (MongoDB.Bson.Serialization.BsonClassMap)translator.GetObject(L, 3, typeof(MongoDB.Bson.Serialization.BsonClassMap));
					
					MongoDB.Bson.Serialization.BsonClassMap gen_ret = new MongoDB.Bson.Serialization.BsonClassMap(_classType, _baseClassMap);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.BsonClassMap constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMemberInfoType_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Reflection.MemberInfo _memberInfo = (System.Reflection.MemberInfo)translator.GetObject(L, 1, typeof(System.Reflection.MemberInfo));
                    
                        System.Type gen_ret = MongoDB.Bson.Serialization.BsonClassMap.GetMemberInfoType( _memberInfo );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRegisteredClassMaps_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        System.Collections.Generic.IEnumerable<MongoDB.Bson.Serialization.BsonClassMap> gen_ret = MongoDB.Bson.Serialization.BsonClassMap.GetRegisteredClassMaps(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsClassMapRegistered_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    
                        bool gen_ret = MongoDB.Bson.Serialization.BsonClassMap.IsClassMapRegistered( _type );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LookupClassMap_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type _classType = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    
                        MongoDB.Bson.Serialization.BsonClassMap gen_ret = MongoDB.Bson.Serialization.BsonClassMap.LookupClassMap( _classType );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterClassMap_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.Serialization.BsonClassMap _classMap = (MongoDB.Bson.Serialization.BsonClassMap)translator.GetObject(L, 1, typeof(MongoDB.Bson.Serialization.BsonClassMap));
                    
                    MongoDB.Bson.Serialization.BsonClassMap.RegisterClassMap( _classMap );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AutoMap(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.AutoMap(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateInstance(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        object gen_ret = gen_to_be_invoked.CreateInstance(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
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
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        MongoDB.Bson.Serialization.BsonClassMap gen_ret = gen_to_be_invoked.Freeze(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMemberMap(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _memberName = LuaAPI.lua_tostring(L, 2);
                    
                        MongoDB.Bson.Serialization.BsonMemberMap gen_ret = gen_to_be_invoked.GetMemberMap( _memberName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMemberMapForElement(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _elementName = LuaAPI.lua_tostring(L, 2);
                    
                        MongoDB.Bson.Serialization.BsonMemberMap gen_ret = gen_to_be_invoked.GetMemberMapForElement( _elementName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MapConstructor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Reflection.ConstructorInfo>(L, 2)) 
                {
                    System.Reflection.ConstructorInfo _constructorInfo = (System.Reflection.ConstructorInfo)translator.GetObject(L, 2, typeof(System.Reflection.ConstructorInfo));
                    
                        MongoDB.Bson.Serialization.BsonCreatorMap gen_ret = gen_to_be_invoked.MapConstructor( _constructorInfo );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& translator.Assignable<System.Reflection.ConstructorInfo>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING))) 
                {
                    System.Reflection.ConstructorInfo _constructorInfo = (System.Reflection.ConstructorInfo)translator.GetObject(L, 2, typeof(System.Reflection.ConstructorInfo));
                    string[] _argumentNames = translator.GetParams<string>(L, 3);
                    
                        MongoDB.Bson.Serialization.BsonCreatorMap gen_ret = gen_to_be_invoked.MapConstructor( _constructorInfo, _argumentNames );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.BsonClassMap.MapConstructor!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MapCreator(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Delegate>(L, 2)) 
                {
                    System.Delegate _delegate = translator.GetDelegate<System.Delegate>(L, 2);
                    
                        MongoDB.Bson.Serialization.BsonCreatorMap gen_ret = gen_to_be_invoked.MapCreator( _delegate );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& translator.Assignable<System.Delegate>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING))) 
                {
                    System.Delegate _delegate = translator.GetDelegate<System.Delegate>(L, 2);
                    string[] _argumentNames = translator.GetParams<string>(L, 3);
                    
                        MongoDB.Bson.Serialization.BsonCreatorMap gen_ret = gen_to_be_invoked.MapCreator( _delegate, _argumentNames );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.BsonClassMap.MapCreator!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MapExtraElementsField(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _fieldName = LuaAPI.lua_tostring(L, 2);
                    
                        MongoDB.Bson.Serialization.BsonMemberMap gen_ret = gen_to_be_invoked.MapExtraElementsField( _fieldName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MapExtraElementsMember(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Reflection.MemberInfo _memberInfo = (System.Reflection.MemberInfo)translator.GetObject(L, 2, typeof(System.Reflection.MemberInfo));
                    
                        MongoDB.Bson.Serialization.BsonMemberMap gen_ret = gen_to_be_invoked.MapExtraElementsMember( _memberInfo );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MapExtraElementsProperty(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _propertyName = LuaAPI.lua_tostring(L, 2);
                    
                        MongoDB.Bson.Serialization.BsonMemberMap gen_ret = gen_to_be_invoked.MapExtraElementsProperty( _propertyName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MapFactoryMethod(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Reflection.MethodInfo>(L, 2)) 
                {
                    System.Reflection.MethodInfo _methodInfo = (System.Reflection.MethodInfo)translator.GetObject(L, 2, typeof(System.Reflection.MethodInfo));
                    
                        MongoDB.Bson.Serialization.BsonCreatorMap gen_ret = gen_to_be_invoked.MapFactoryMethod( _methodInfo );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 2&& translator.Assignable<System.Reflection.MethodInfo>(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING))) 
                {
                    System.Reflection.MethodInfo _methodInfo = (System.Reflection.MethodInfo)translator.GetObject(L, 2, typeof(System.Reflection.MethodInfo));
                    string[] _argumentNames = translator.GetParams<string>(L, 3);
                    
                        MongoDB.Bson.Serialization.BsonCreatorMap gen_ret = gen_to_be_invoked.MapFactoryMethod( _methodInfo, _argumentNames );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.BsonClassMap.MapFactoryMethod!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MapField(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _fieldName = LuaAPI.lua_tostring(L, 2);
                    
                        MongoDB.Bson.Serialization.BsonMemberMap gen_ret = gen_to_be_invoked.MapField( _fieldName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MapIdField(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _fieldName = LuaAPI.lua_tostring(L, 2);
                    
                        MongoDB.Bson.Serialization.BsonMemberMap gen_ret = gen_to_be_invoked.MapIdField( _fieldName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MapIdMember(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Reflection.MemberInfo _memberInfo = (System.Reflection.MemberInfo)translator.GetObject(L, 2, typeof(System.Reflection.MemberInfo));
                    
                        MongoDB.Bson.Serialization.BsonMemberMap gen_ret = gen_to_be_invoked.MapIdMember( _memberInfo );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MapIdProperty(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _propertyName = LuaAPI.lua_tostring(L, 2);
                    
                        MongoDB.Bson.Serialization.BsonMemberMap gen_ret = gen_to_be_invoked.MapIdProperty( _propertyName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MapMember(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Reflection.MemberInfo _memberInfo = (System.Reflection.MemberInfo)translator.GetObject(L, 2, typeof(System.Reflection.MemberInfo));
                    
                        MongoDB.Bson.Serialization.BsonMemberMap gen_ret = gen_to_be_invoked.MapMember( _memberInfo );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MapProperty(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _propertyName = LuaAPI.lua_tostring(L, 2);
                    
                        MongoDB.Bson.Serialization.BsonMemberMap gen_ret = gen_to_be_invoked.MapProperty( _propertyName );
                        translator.Push(L, gen_ret);
                    
                    
                    
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
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Reset(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCreator(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Func<object> _creator = translator.GetDelegate<System.Func<object>>(L, 2);
                    
                        MongoDB.Bson.Serialization.BsonClassMap gen_ret = gen_to_be_invoked.SetCreator( _creator );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDiscriminator(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _discriminator = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.SetDiscriminator( _discriminator );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDiscriminatorIsRequired(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _discriminatorIsRequired = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.SetDiscriminatorIsRequired( _discriminatorIsRequired );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetExtraElementsMember(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.Serialization.BsonMemberMap _memberMap = (MongoDB.Bson.Serialization.BsonMemberMap)translator.GetObject(L, 2, typeof(MongoDB.Bson.Serialization.BsonMemberMap));
                    
                    gen_to_be_invoked.SetExtraElementsMember( _memberMap );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddKnownType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                    gen_to_be_invoked.AddKnownType( _type );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIdMember(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.Serialization.BsonMemberMap _memberMap = (MongoDB.Bson.Serialization.BsonMemberMap)translator.GetObject(L, 2, typeof(MongoDB.Bson.Serialization.BsonMemberMap));
                    
                    gen_to_be_invoked.SetIdMember( _memberMap );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIgnoreExtraElements(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _ignoreExtraElements = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.SetIgnoreExtraElements( _ignoreExtraElements );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIgnoreExtraElementsIsInherited(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _ignoreExtraElementsIsInherited = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.SetIgnoreExtraElementsIsInherited( _ignoreExtraElementsIsInherited );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIsRootClass(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _isRootClass = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.SetIsRootClass( _isRootClass );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnmapConstructor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Reflection.ConstructorInfo _constructorInfo = (System.Reflection.ConstructorInfo)translator.GetObject(L, 2, typeof(System.Reflection.ConstructorInfo));
                    
                    gen_to_be_invoked.UnmapConstructor( _constructorInfo );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnmapFactoryMethod(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Reflection.MethodInfo _methodInfo = (System.Reflection.MethodInfo)translator.GetObject(L, 2, typeof(System.Reflection.MethodInfo));
                    
                    gen_to_be_invoked.UnmapFactoryMethod( _methodInfo );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnmapField(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _fieldName = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.UnmapField( _fieldName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnmapMember(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Reflection.MemberInfo _memberInfo = (System.Reflection.MemberInfo)translator.GetObject(L, 2, typeof(System.Reflection.MemberInfo));
                    
                    gen_to_be_invoked.UnmapMember( _memberInfo );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnmapProperty(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _propertyName = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.UnmapProperty( _propertyName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AllMemberMaps(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AllMemberMaps);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BaseClassMap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.BaseClassMap);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ClassType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ClassType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CreatorMaps(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.CreatorMaps);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ConventionPack(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.ConventionPack);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DeclaredMemberMaps(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.DeclaredMemberMaps);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Discriminator(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Discriminator);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DiscriminatorIsRequired(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.DiscriminatorIsRequired);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ExtraElementsMemberMap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ExtraElementsMemberMap);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HasCreatorMaps(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.HasCreatorMaps);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HasRootClass(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.HasRootClass);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IdMemberMap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.IdMemberMap);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IgnoreExtraElements(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IgnoreExtraElements);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IgnoreExtraElementsIsInherited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IgnoreExtraElementsIsInherited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsAnonymous(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsAnonymous);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsFrozen(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsFrozen);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsRootClass(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsRootClass);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_KnownTypes(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonClassMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonClassMap)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.KnownTypes);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
