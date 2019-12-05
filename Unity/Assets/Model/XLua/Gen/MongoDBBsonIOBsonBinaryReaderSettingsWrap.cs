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
    public class MongoDBBsonIOBsonBinaryReaderSettingsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.IO.BsonBinaryReaderSettings);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 4, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clone", _m_Clone);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Encoding", _g_get_Encoding);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "FixOldBinarySubTypeOnInput", _g_get_FixOldBinarySubTypeOnInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "FixOldDateTimeMaxValueOnInput", _g_get_FixOldDateTimeMaxValueOnInput);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MaxDocumentSize", _g_get_MaxDocumentSize);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Encoding", _s_set_Encoding);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "FixOldBinarySubTypeOnInput", _s_set_FixOldBinarySubTypeOnInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "FixOldDateTimeMaxValueOnInput", _s_set_FixOldDateTimeMaxValueOnInput);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "MaxDocumentSize", _s_set_MaxDocumentSize);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 1);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Defaults", _g_get_Defaults);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Defaults", _s_set_Defaults);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					MongoDB.Bson.IO.BsonBinaryReaderSettings gen_ret = new MongoDB.Bson.IO.BsonBinaryReaderSettings();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.IO.BsonBinaryReaderSettings constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clone(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonBinaryReaderSettings gen_to_be_invoked = (MongoDB.Bson.IO.BsonBinaryReaderSettings)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        MongoDB.Bson.IO.BsonBinaryReaderSettings gen_ret = gen_to_be_invoked.Clone(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Defaults(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, MongoDB.Bson.IO.BsonBinaryReaderSettings.Defaults);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Encoding(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.BsonBinaryReaderSettings gen_to_be_invoked = (MongoDB.Bson.IO.BsonBinaryReaderSettings)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Encoding);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_FixOldBinarySubTypeOnInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.BsonBinaryReaderSettings gen_to_be_invoked = (MongoDB.Bson.IO.BsonBinaryReaderSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.FixOldBinarySubTypeOnInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_FixOldDateTimeMaxValueOnInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.BsonBinaryReaderSettings gen_to_be_invoked = (MongoDB.Bson.IO.BsonBinaryReaderSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.FixOldDateTimeMaxValueOnInput);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MaxDocumentSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.BsonBinaryReaderSettings gen_to_be_invoked = (MongoDB.Bson.IO.BsonBinaryReaderSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.MaxDocumentSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Defaults(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    MongoDB.Bson.IO.BsonBinaryReaderSettings.Defaults = (MongoDB.Bson.IO.BsonBinaryReaderSettings)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.BsonBinaryReaderSettings));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Encoding(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.BsonBinaryReaderSettings gen_to_be_invoked = (MongoDB.Bson.IO.BsonBinaryReaderSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Encoding = (System.Text.UTF8Encoding)translator.GetObject(L, 2, typeof(System.Text.UTF8Encoding));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_FixOldBinarySubTypeOnInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.BsonBinaryReaderSettings gen_to_be_invoked = (MongoDB.Bson.IO.BsonBinaryReaderSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.FixOldBinarySubTypeOnInput = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_FixOldDateTimeMaxValueOnInput(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.BsonBinaryReaderSettings gen_to_be_invoked = (MongoDB.Bson.IO.BsonBinaryReaderSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.FixOldDateTimeMaxValueOnInput = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MaxDocumentSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.BsonBinaryReaderSettings gen_to_be_invoked = (MongoDB.Bson.IO.BsonBinaryReaderSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.MaxDocumentSize = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
