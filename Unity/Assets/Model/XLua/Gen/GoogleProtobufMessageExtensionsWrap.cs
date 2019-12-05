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
    public class GoogleProtobufMessageExtensionsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Google.Protobuf.MessageExtensions);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 7, 2, 2);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "MergeFrom", _m_MergeFrom_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MergeDelimitedFrom", _m_MergeDelimitedFrom_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToByteArray", _m_ToByteArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteTo", _m_WriteTo_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteDelimitedTo", _m_WriteDelimitedTo_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ToByteString", _m_ToByteString_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "inputStream", _g_get_inputStream);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "outputStream", _g_get_outputStream);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "inputStream", _s_set_inputStream);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "outputStream", _s_set_outputStream);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "Google.Protobuf.MessageExtensions does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MergeFrom_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<Google.Protobuf.IMessage>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    Google.Protobuf.IMessage _message = (Google.Protobuf.IMessage)translator.GetObject(L, 1, typeof(Google.Protobuf.IMessage));
                    byte[] _data = LuaAPI.lua_tobytes(L, 2);
                    
                    Google.Protobuf.MessageExtensions.MergeFrom( _message, _data );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<Google.Protobuf.IMessage>(L, 1)&& translator.Assignable<Google.Protobuf.ByteString>(L, 2)) 
                {
                    Google.Protobuf.IMessage _message = (Google.Protobuf.IMessage)translator.GetObject(L, 1, typeof(Google.Protobuf.IMessage));
                    Google.Protobuf.ByteString _data = (Google.Protobuf.ByteString)translator.GetObject(L, 2, typeof(Google.Protobuf.ByteString));
                    
                    Google.Protobuf.MessageExtensions.MergeFrom( _message, _data );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<Google.Protobuf.IMessage>(L, 1)&& translator.Assignable<System.IO.Stream>(L, 2)) 
                {
                    Google.Protobuf.IMessage _message = (Google.Protobuf.IMessage)translator.GetObject(L, 1, typeof(Google.Protobuf.IMessage));
                    System.IO.Stream _input = (System.IO.Stream)translator.GetObject(L, 2, typeof(System.IO.Stream));
                    
                    Google.Protobuf.MessageExtensions.MergeFrom( _message, _input );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<Google.Protobuf.IMessage>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    Google.Protobuf.IMessage _message = (Google.Protobuf.IMessage)translator.GetObject(L, 1, typeof(Google.Protobuf.IMessage));
                    byte[] _data = LuaAPI.lua_tobytes(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _length = LuaAPI.xlua_tointeger(L, 4);
                    
                    Google.Protobuf.MessageExtensions.MergeFrom( _message, _data, _offset, _length );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Google.Protobuf.MessageExtensions.MergeFrom!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MergeDelimitedFrom_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    Google.Protobuf.IMessage _message = (Google.Protobuf.IMessage)translator.GetObject(L, 1, typeof(Google.Protobuf.IMessage));
                    System.IO.Stream _input = (System.IO.Stream)translator.GetObject(L, 2, typeof(System.IO.Stream));
                    
                    Google.Protobuf.MessageExtensions.MergeDelimitedFrom( _message, _input );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToByteArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    Google.Protobuf.IMessage _message = (Google.Protobuf.IMessage)translator.GetObject(L, 1, typeof(Google.Protobuf.IMessage));
                    
                        byte[] gen_ret = Google.Protobuf.MessageExtensions.ToByteArray( _message );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteTo_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    Google.Protobuf.IMessage _message = (Google.Protobuf.IMessage)translator.GetObject(L, 1, typeof(Google.Protobuf.IMessage));
                    System.IO.MemoryStream _output = (System.IO.MemoryStream)translator.GetObject(L, 2, typeof(System.IO.MemoryStream));
                    
                    Google.Protobuf.MessageExtensions.WriteTo( _message, _output );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteDelimitedTo_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    Google.Protobuf.IMessage _message = (Google.Protobuf.IMessage)translator.GetObject(L, 1, typeof(Google.Protobuf.IMessage));
                    System.IO.Stream _output = (System.IO.Stream)translator.GetObject(L, 2, typeof(System.IO.Stream));
                    
                    Google.Protobuf.MessageExtensions.WriteDelimitedTo( _message, _output );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToByteString_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    Google.Protobuf.IMessage _message = (Google.Protobuf.IMessage)translator.GetObject(L, 1, typeof(Google.Protobuf.IMessage));
                    
                        Google.Protobuf.ByteString gen_ret = Google.Protobuf.MessageExtensions.ToByteString( _message );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_inputStream(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, Google.Protobuf.MessageExtensions.inputStream);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_outputStream(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, Google.Protobuf.MessageExtensions.outputStream);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_inputStream(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    Google.Protobuf.MessageExtensions.inputStream = (Google.Protobuf.CodedInputStream)translator.GetObject(L, 1, typeof(Google.Protobuf.CodedInputStream));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_outputStream(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    Google.Protobuf.MessageExtensions.outputStream = (Google.Protobuf.CodedOutputStream)translator.GetObject(L, 1, typeof(Google.Protobuf.CodedOutputStream));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
