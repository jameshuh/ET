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
    public class MongoDBBsonSerializationConventionsStandardDiscriminatorConventionWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.Serialization.Conventions.StandardDiscriminatorConvention);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetActualType", _m_GetActualType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDiscriminator", _m_GetDiscriminator);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ElementName", _g_get_ElementName);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 2, 0);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Scalar", _g_get_Scalar);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Hierarchical", _g_get_Hierarchical);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "MongoDB.Bson.Serialization.Conventions.StandardDiscriminatorConvention does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetActualType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Conventions.StandardDiscriminatorConvention gen_to_be_invoked = (MongoDB.Bson.Serialization.Conventions.StandardDiscriminatorConvention)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _bsonReader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 2, typeof(MongoDB.Bson.IO.IBsonReader));
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    
                        System.Type gen_ret = gen_to_be_invoked.GetActualType( _bsonReader, _nominalType );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDiscriminator(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.Conventions.StandardDiscriminatorConvention gen_to_be_invoked = (MongoDB.Bson.Serialization.Conventions.StandardDiscriminatorConvention)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _nominalType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    System.Type _actualType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    
                        MongoDB.Bson.BsonValue gen_ret = gen_to_be_invoked.GetDiscriminator( _nominalType, _actualType );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Scalar(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, MongoDB.Bson.Serialization.Conventions.StandardDiscriminatorConvention.Scalar);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Hierarchical(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, MongoDB.Bson.Serialization.Conventions.StandardDiscriminatorConvention.Hierarchical);
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
			
                MongoDB.Bson.Serialization.Conventions.StandardDiscriminatorConvention gen_to_be_invoked = (MongoDB.Bson.Serialization.Conventions.StandardDiscriminatorConvention)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.ElementName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
