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
    public class MongoDBBsonSerializationConventionsNamedIdMemberConventionWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.Serialization.Conventions.NamedIdMemberConvention);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Apply", _m_Apply);
			
			
			
			
			
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
				if(LuaAPI.lua_gettop(L) >= 1 && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)))
				{
					string[] _names = translator.GetParams<string>(L, 2);
					
					MongoDB.Bson.Serialization.Conventions.NamedIdMemberConvention gen_ret = new MongoDB.Bson.Serialization.Conventions.NamedIdMemberConvention(_names);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Collections.Generic.IEnumerable<string>>(L, 2))
				{
					System.Collections.Generic.IEnumerable<string> _names = (System.Collections.Generic.IEnumerable<string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<string>));
					
					MongoDB.Bson.Serialization.Conventions.NamedIdMemberConvention gen_ret = new MongoDB.Bson.Serialization.Conventions.NamedIdMemberConvention(_names);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<System.Collections.Generic.IEnumerable<string>>(L, 2) && translator.Assignable<System.Reflection.MemberTypes>(L, 3))
				{
					System.Collections.Generic.IEnumerable<string> _names = (System.Collections.Generic.IEnumerable<string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<string>));
					System.Reflection.MemberTypes _memberTypes;translator.Get(L, 3, out _memberTypes);
					
					MongoDB.Bson.Serialization.Conventions.NamedIdMemberConvention gen_ret = new MongoDB.Bson.Serialization.Conventions.NamedIdMemberConvention(_names, _memberTypes);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<System.Collections.Generic.IEnumerable<string>>(L, 2) && translator.Assignable<System.Reflection.BindingFlags>(L, 3))
				{
					System.Collections.Generic.IEnumerable<string> _names = (System.Collections.Generic.IEnumerable<string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<string>));
					System.Reflection.BindingFlags _bindingFlags;translator.Get(L, 3, out _bindingFlags);
					
					MongoDB.Bson.Serialization.Conventions.NamedIdMemberConvention gen_ret = new MongoDB.Bson.Serialization.Conventions.NamedIdMemberConvention(_names, _bindingFlags);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<System.Collections.Generic.IEnumerable<string>>(L, 2) && translator.Assignable<System.Reflection.MemberTypes>(L, 3) && translator.Assignable<System.Reflection.BindingFlags>(L, 4))
				{
					System.Collections.Generic.IEnumerable<string> _names = (System.Collections.Generic.IEnumerable<string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<string>));
					System.Reflection.MemberTypes _memberTypes;translator.Get(L, 3, out _memberTypes);
					System.Reflection.BindingFlags _bindingFlags;translator.Get(L, 4, out _bindingFlags);
					
					MongoDB.Bson.Serialization.Conventions.NamedIdMemberConvention gen_ret = new MongoDB.Bson.Serialization.Conventions.NamedIdMemberConvention(_names, _memberTypes, _bindingFlags);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.Conventions.NamedIdMemberConvention constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Apply(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Conventions.NamedIdMemberConvention gen_to_be_invoked = (MongoDB.Bson.Serialization.Conventions.NamedIdMemberConvention)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.Serialization.BsonClassMap _classMap = (MongoDB.Bson.Serialization.BsonClassMap)translator.GetObject(L, 2, typeof(MongoDB.Bson.Serialization.BsonClassMap));
                    
                    gen_to_be_invoked.Apply( _classMap );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
