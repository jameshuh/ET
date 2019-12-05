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
    public class MongoDBBsonBsonJavaScriptWithScopeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.BsonJavaScriptWithScope);
			Utils.BeginObjectRegister(type, L, translator, 1, 6, 2, 0);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__eq", __EqMeta);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clone", _m_Clone);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DeepClone", _m_DeepClone);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CompareTo", _m_CompareTo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", _m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", _m_GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", _m_ToString);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "BsonType", _g_get_BsonType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Scope", _g_get_Scope);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Create", _m_Create_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 3 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && translator.Assignable<MongoDB.Bson.BsonDocument>(L, 3))
				{
					string _code = LuaAPI.lua_tostring(L, 2);
					MongoDB.Bson.BsonDocument _scope = (MongoDB.Bson.BsonDocument)translator.GetObject(L, 3, typeof(MongoDB.Bson.BsonDocument));
					
					MongoDB.Bson.BsonJavaScriptWithScope gen_ret = new MongoDB.Bson.BsonJavaScriptWithScope(_code, _scope);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.BsonJavaScriptWithScope constructor!");
            
        }
        
		
        
		
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __EqMeta(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			
				if (translator.Assignable<MongoDB.Bson.BsonJavaScriptWithScope>(L, 1) && translator.Assignable<MongoDB.Bson.BsonJavaScriptWithScope>(L, 2))
				{
					MongoDB.Bson.BsonJavaScriptWithScope leftside = (MongoDB.Bson.BsonJavaScriptWithScope)translator.GetObject(L, 1, typeof(MongoDB.Bson.BsonJavaScriptWithScope));
					MongoDB.Bson.BsonJavaScriptWithScope rightside = (MongoDB.Bson.BsonJavaScriptWithScope)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonJavaScriptWithScope));
					
					LuaAPI.lua_pushboolean(L, leftside == rightside);
					
					return 1;
				}
            
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of == operator, need MongoDB.Bson.BsonJavaScriptWithScope!");
            
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Create_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    object _value = translator.GetObject(L, 1, typeof(object));
                    
                        MongoDB.Bson.BsonJavaScriptWithScope gen_ret = MongoDB.Bson.BsonJavaScriptWithScope.Create( _value );
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
            
            
                MongoDB.Bson.BsonJavaScriptWithScope gen_to_be_invoked = (MongoDB.Bson.BsonJavaScriptWithScope)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_DeepClone(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonJavaScriptWithScope gen_to_be_invoked = (MongoDB.Bson.BsonJavaScriptWithScope)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_CompareTo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonJavaScriptWithScope gen_to_be_invoked = (MongoDB.Bson.BsonJavaScriptWithScope)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<MongoDB.Bson.BsonJavaScriptWithScope>(L, 2)) 
                {
                    MongoDB.Bson.BsonJavaScriptWithScope _other = (MongoDB.Bson.BsonJavaScriptWithScope)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonJavaScriptWithScope));
                    
                        int gen_ret = gen_to_be_invoked.CompareTo( _other );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<MongoDB.Bson.BsonValue>(L, 2)) 
                {
                    MongoDB.Bson.BsonValue _other = (MongoDB.Bson.BsonValue)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonValue));
                    
                        int gen_ret = gen_to_be_invoked.CompareTo( _other );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.BsonJavaScriptWithScope.CompareTo!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Equals(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonJavaScriptWithScope gen_to_be_invoked = (MongoDB.Bson.BsonJavaScriptWithScope)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<MongoDB.Bson.BsonJavaScriptWithScope>(L, 2)) 
                {
                    MongoDB.Bson.BsonJavaScriptWithScope _rhs = (MongoDB.Bson.BsonJavaScriptWithScope)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonJavaScriptWithScope));
                    
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
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.BsonJavaScriptWithScope.Equals!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHashCode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonJavaScriptWithScope gen_to_be_invoked = (MongoDB.Bson.BsonJavaScriptWithScope)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_ToString(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonJavaScriptWithScope gen_to_be_invoked = (MongoDB.Bson.BsonJavaScriptWithScope)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string gen_ret = gen_to_be_invoked.ToString(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BsonType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonJavaScriptWithScope gen_to_be_invoked = (MongoDB.Bson.BsonJavaScriptWithScope)translator.FastGetCSObj(L, 1);
                translator.PushMongoDBBsonBsonType(L, gen_to_be_invoked.BsonType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Scope(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonJavaScriptWithScope gen_to_be_invoked = (MongoDB.Bson.BsonJavaScriptWithScope)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Scope);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
