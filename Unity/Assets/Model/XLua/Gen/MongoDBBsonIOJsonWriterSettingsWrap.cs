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
    public class MongoDBBsonIOJsonWriterSettingsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.IO.JsonWriterSettings);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 5, 5);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clone", _m_Clone);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Indent", _g_get_Indent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IndentChars", _g_get_IndentChars);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "NewLineChars", _g_get_NewLineChars);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "OutputMode", _g_get_OutputMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ShellVersion", _g_get_ShellVersion);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Indent", _s_set_Indent);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IndentChars", _s_set_IndentChars);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "NewLineChars", _s_set_NewLineChars);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "OutputMode", _s_set_OutputMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ShellVersion", _s_set_ShellVersion);
            
			
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
					
					MongoDB.Bson.IO.JsonWriterSettings gen_ret = new MongoDB.Bson.IO.JsonWriterSettings();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.IO.JsonWriterSettings constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clone(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.JsonWriterSettings gen_to_be_invoked = (MongoDB.Bson.IO.JsonWriterSettings)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        MongoDB.Bson.IO.JsonWriterSettings gen_ret = gen_to_be_invoked.Clone(  );
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
			    translator.Push(L, MongoDB.Bson.IO.JsonWriterSettings.Defaults);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Indent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.JsonWriterSettings gen_to_be_invoked = (MongoDB.Bson.IO.JsonWriterSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.Indent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IndentChars(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.JsonWriterSettings gen_to_be_invoked = (MongoDB.Bson.IO.JsonWriterSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.IndentChars);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_NewLineChars(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.JsonWriterSettings gen_to_be_invoked = (MongoDB.Bson.IO.JsonWriterSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.NewLineChars);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OutputMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.JsonWriterSettings gen_to_be_invoked = (MongoDB.Bson.IO.JsonWriterSettings)translator.FastGetCSObj(L, 1);
                translator.PushMongoDBBsonIOJsonOutputMode(L, gen_to_be_invoked.OutputMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ShellVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.JsonWriterSettings gen_to_be_invoked = (MongoDB.Bson.IO.JsonWriterSettings)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ShellVersion);
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
			    MongoDB.Bson.IO.JsonWriterSettings.Defaults = (MongoDB.Bson.IO.JsonWriterSettings)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.JsonWriterSettings));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Indent(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.JsonWriterSettings gen_to_be_invoked = (MongoDB.Bson.IO.JsonWriterSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Indent = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IndentChars(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.JsonWriterSettings gen_to_be_invoked = (MongoDB.Bson.IO.JsonWriterSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IndentChars = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_NewLineChars(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.JsonWriterSettings gen_to_be_invoked = (MongoDB.Bson.IO.JsonWriterSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.NewLineChars = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OutputMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.JsonWriterSettings gen_to_be_invoked = (MongoDB.Bson.IO.JsonWriterSettings)translator.FastGetCSObj(L, 1);
                MongoDB.Bson.IO.JsonOutputMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.OutputMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ShellVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.JsonWriterSettings gen_to_be_invoked = (MongoDB.Bson.IO.JsonWriterSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ShellVersion = (System.Version)translator.GetObject(L, 2, typeof(System.Version));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
