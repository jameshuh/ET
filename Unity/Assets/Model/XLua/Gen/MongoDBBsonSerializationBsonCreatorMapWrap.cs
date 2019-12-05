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
    public class MongoDBBsonSerializationBsonCreatorMapWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.Serialization.BsonCreatorMap);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 5, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Freeze", _m_Freeze);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasDefaultValue", _m_HasDefaultValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetArguments", _m_SetArguments);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Arguments", _g_get_Arguments);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ClassMap", _g_get_ClassMap);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Delegate", _g_get_Delegate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ElementNames", _g_get_ElementNames);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MemberInfo", _g_get_MemberInfo);
            
			
			
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
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<MongoDB.Bson.Serialization.BsonClassMap>(L, 2) && translator.Assignable<System.Reflection.MemberInfo>(L, 3) && translator.Assignable<System.Delegate>(L, 4))
				{
					MongoDB.Bson.Serialization.BsonClassMap _classMap = (MongoDB.Bson.Serialization.BsonClassMap)translator.GetObject(L, 2, typeof(MongoDB.Bson.Serialization.BsonClassMap));
					System.Reflection.MemberInfo _memberInfo = (System.Reflection.MemberInfo)translator.GetObject(L, 3, typeof(System.Reflection.MemberInfo));
					System.Delegate _delegate = translator.GetDelegate<System.Delegate>(L, 4);
					
					MongoDB.Bson.Serialization.BsonCreatorMap gen_ret = new MongoDB.Bson.Serialization.BsonCreatorMap(_classMap, _memberInfo, _delegate);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.BsonCreatorMap constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Freeze(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonCreatorMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonCreatorMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Freeze(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasDefaultValue(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonCreatorMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonCreatorMap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _elementName = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.HasDefaultValue( _elementName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetArguments(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.BsonCreatorMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonCreatorMap)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>>(L, 2)) 
                {
                    System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> _arguments = (System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>));
                    
                        MongoDB.Bson.Serialization.BsonCreatorMap gen_ret = gen_to_be_invoked.SetArguments( _arguments );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.IEnumerable<string>>(L, 2)) 
                {
                    System.Collections.Generic.IEnumerable<string> _argumentNames = (System.Collections.Generic.IEnumerable<string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<string>));
                    
                        MongoDB.Bson.Serialization.BsonCreatorMap gen_ret = gen_to_be_invoked.SetArguments( _argumentNames );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.BsonCreatorMap.SetArguments!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Arguments(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonCreatorMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonCreatorMap)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.Arguments);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ClassMap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonCreatorMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonCreatorMap)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ClassMap);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Delegate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonCreatorMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonCreatorMap)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Delegate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ElementNames(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.BsonCreatorMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonCreatorMap)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.ElementNames);
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
			
                MongoDB.Bson.Serialization.BsonCreatorMap gen_to_be_invoked = (MongoDB.Bson.Serialization.BsonCreatorMap)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.MemberInfo);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
