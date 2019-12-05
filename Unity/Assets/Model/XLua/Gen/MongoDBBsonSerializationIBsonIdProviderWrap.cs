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
    public class MongoDBBsonSerializationIBsonIdProviderWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.Serialization.IBsonIdProvider);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDocumentId", _m_GetDocumentId);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDocumentId", _m_SetDocumentId);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "MongoDB.Bson.Serialization.IBsonIdProvider does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDocumentId(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.IBsonIdProvider gen_to_be_invoked = (MongoDB.Bson.Serialization.IBsonIdProvider)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _document = translator.GetObject(L, 2, typeof(object));
                    object _id;
                    System.Type _idNominalType;
                    MongoDB.Bson.Serialization.IIdGenerator _idGenerator;
                    
                        bool gen_ret = gen_to_be_invoked.GetDocumentId( _document, out _id, out _idNominalType, out _idGenerator );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.PushAny(L, _id);
                        
                    translator.Push(L, _idNominalType);
                        
                    translator.PushAny(L, _idGenerator);
                        
                    
                    
                    
                    return 4;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDocumentId(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.Serialization.IBsonIdProvider gen_to_be_invoked = (MongoDB.Bson.Serialization.IBsonIdProvider)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _document = translator.GetObject(L, 2, typeof(object));
                    object _id = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.SetDocumentId( _document, _id );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
