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
    public class MongoDBBsonSerializationConventionsConventionPackWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.Serialization.Conventions.ConventionPack);
			Utils.BeginObjectRegister(type, L, translator, 0, 10, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Add", _m_Add);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddClassMapConvention", _m_AddClassMapConvention);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddMemberMapConvention", _m_AddMemberMapConvention);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddPostProcessingConvention", _m_AddPostProcessingConvention);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddRange", _m_AddRange);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Append", _m_Append);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEnumerator", _m_GetEnumerator);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InsertAfter", _m_InsertAfter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InsertBefore", _m_InsertBefore);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Remove", _m_Remove);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Conventions", _g_get_Conventions);
            
			
			
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
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					MongoDB.Bson.Serialization.Conventions.ConventionPack gen_ret = new MongoDB.Bson.Serialization.Conventions.ConventionPack();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.Conventions.ConventionPack constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Add(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Conventions.ConventionPack gen_to_be_invoked = (MongoDB.Bson.Serialization.Conventions.ConventionPack)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.Serialization.Conventions.IConvention _convention = (MongoDB.Bson.Serialization.Conventions.IConvention)translator.GetObject(L, 2, typeof(MongoDB.Bson.Serialization.Conventions.IConvention));
                    
                    gen_to_be_invoked.Add( _convention );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddClassMapConvention(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Conventions.ConventionPack gen_to_be_invoked = (MongoDB.Bson.Serialization.Conventions.ConventionPack)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Action<MongoDB.Bson.Serialization.BsonClassMap> _action = translator.GetDelegate<System.Action<MongoDB.Bson.Serialization.BsonClassMap>>(L, 3);
                    
                    gen_to_be_invoked.AddClassMapConvention( _name, _action );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddMemberMapConvention(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Conventions.ConventionPack gen_to_be_invoked = (MongoDB.Bson.Serialization.Conventions.ConventionPack)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Action<MongoDB.Bson.Serialization.BsonMemberMap> _action = translator.GetDelegate<System.Action<MongoDB.Bson.Serialization.BsonMemberMap>>(L, 3);
                    
                    gen_to_be_invoked.AddMemberMapConvention( _name, _action );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddPostProcessingConvention(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Conventions.ConventionPack gen_to_be_invoked = (MongoDB.Bson.Serialization.Conventions.ConventionPack)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Action<MongoDB.Bson.Serialization.BsonClassMap> _action = translator.GetDelegate<System.Action<MongoDB.Bson.Serialization.BsonClassMap>>(L, 3);
                    
                    gen_to_be_invoked.AddPostProcessingConvention( _name, _action );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddRange(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Conventions.ConventionPack gen_to_be_invoked = (MongoDB.Bson.Serialization.Conventions.ConventionPack)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.IEnumerable<MongoDB.Bson.Serialization.Conventions.IConvention> _conventions = (System.Collections.Generic.IEnumerable<MongoDB.Bson.Serialization.Conventions.IConvention>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<MongoDB.Bson.Serialization.Conventions.IConvention>));
                    
                    gen_to_be_invoked.AddRange( _conventions );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Append(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Conventions.ConventionPack gen_to_be_invoked = (MongoDB.Bson.Serialization.Conventions.ConventionPack)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.Serialization.Conventions.IConventionPack _other = (MongoDB.Bson.Serialization.Conventions.IConventionPack)translator.GetObject(L, 2, typeof(MongoDB.Bson.Serialization.Conventions.IConventionPack));
                    
                    gen_to_be_invoked.Append( _other );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEnumerator(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Conventions.ConventionPack gen_to_be_invoked = (MongoDB.Bson.Serialization.Conventions.ConventionPack)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Collections.Generic.IEnumerator<MongoDB.Bson.Serialization.Conventions.IConvention> gen_ret = gen_to_be_invoked.GetEnumerator(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InsertAfter(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Conventions.ConventionPack gen_to_be_invoked = (MongoDB.Bson.Serialization.Conventions.ConventionPack)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    MongoDB.Bson.Serialization.Conventions.IConvention _convention = (MongoDB.Bson.Serialization.Conventions.IConvention)translator.GetObject(L, 3, typeof(MongoDB.Bson.Serialization.Conventions.IConvention));
                    
                    gen_to_be_invoked.InsertAfter( _name, _convention );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InsertBefore(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Conventions.ConventionPack gen_to_be_invoked = (MongoDB.Bson.Serialization.Conventions.ConventionPack)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    MongoDB.Bson.Serialization.Conventions.IConvention _convention = (MongoDB.Bson.Serialization.Conventions.IConvention)translator.GetObject(L, 3, typeof(MongoDB.Bson.Serialization.Conventions.IConvention));
                    
                    gen_to_be_invoked.InsertBefore( _name, _convention );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Remove(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Conventions.ConventionPack gen_to_be_invoked = (MongoDB.Bson.Serialization.Conventions.ConventionPack)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.Remove( _name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Conventions(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.Serialization.Conventions.ConventionPack gen_to_be_invoked = (MongoDB.Bson.Serialization.Conventions.ConventionPack)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.Conventions);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
