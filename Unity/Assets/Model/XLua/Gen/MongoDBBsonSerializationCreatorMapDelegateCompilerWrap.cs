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
    public class MongoDBBsonSerializationCreatorMapDelegateCompilerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.Serialization.CreatorMapDelegateCompiler);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CompileConstructorDelegate", _m_CompileConstructorDelegate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CompileFactoryMethodDelegate", _m_CompileFactoryMethodDelegate);
			
			
			
			
			
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
					
					MongoDB.Bson.Serialization.CreatorMapDelegateCompiler gen_ret = new MongoDB.Bson.Serialization.CreatorMapDelegateCompiler();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.Serialization.CreatorMapDelegateCompiler constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CompileConstructorDelegate(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.CreatorMapDelegateCompiler gen_to_be_invoked = (MongoDB.Bson.Serialization.CreatorMapDelegateCompiler)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Reflection.ConstructorInfo _constructorInfo = (System.Reflection.ConstructorInfo)translator.GetObject(L, 2, typeof(System.Reflection.ConstructorInfo));
                    
                        System.Delegate gen_ret = gen_to_be_invoked.CompileConstructorDelegate( _constructorInfo );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CompileFactoryMethodDelegate(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.CreatorMapDelegateCompiler gen_to_be_invoked = (MongoDB.Bson.Serialization.CreatorMapDelegateCompiler)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Reflection.MethodInfo _methodInfo = (System.Reflection.MethodInfo)translator.GetObject(L, 2, typeof(System.Reflection.MethodInfo));
                    
                        System.Delegate gen_ret = gen_to_be_invoked.CompileFactoryMethodDelegate( _methodInfo );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
