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
    public class GoogleProtobufFieldCodecWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Google.Protobuf.FieldCodec);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 16, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "ForString", _m_ForString_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ForBytes", _m_ForBytes_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ForBool", _m_ForBool_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ForInt32", _m_ForInt32_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ForSInt32", _m_ForSInt32_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ForFixed32", _m_ForFixed32_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ForSFixed32", _m_ForSFixed32_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ForUInt32", _m_ForUInt32_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ForInt64", _m_ForInt64_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ForSInt64", _m_ForSInt64_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ForFixed64", _m_ForFixed64_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ForSFixed64", _m_ForSFixed64_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ForUInt64", _m_ForUInt64_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ForFloat", _m_ForFloat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ForDouble", _m_ForDouble_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "Google.Protobuf.FieldCodec does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ForString_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    uint _tag = LuaAPI.xlua_touint(L, 1);
                    
                        Google.Protobuf.FieldCodec<string> gen_ret = Google.Protobuf.FieldCodec.ForString( _tag );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ForBytes_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    uint _tag = LuaAPI.xlua_touint(L, 1);
                    
                        Google.Protobuf.FieldCodec<Google.Protobuf.ByteString> gen_ret = Google.Protobuf.FieldCodec.ForBytes( _tag );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ForBool_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    uint _tag = LuaAPI.xlua_touint(L, 1);
                    
                        Google.Protobuf.FieldCodec<bool> gen_ret = Google.Protobuf.FieldCodec.ForBool( _tag );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ForInt32_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    uint _tag = LuaAPI.xlua_touint(L, 1);
                    
                        Google.Protobuf.FieldCodec<int> gen_ret = Google.Protobuf.FieldCodec.ForInt32( _tag );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ForSInt32_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    uint _tag = LuaAPI.xlua_touint(L, 1);
                    
                        Google.Protobuf.FieldCodec<int> gen_ret = Google.Protobuf.FieldCodec.ForSInt32( _tag );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ForFixed32_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    uint _tag = LuaAPI.xlua_touint(L, 1);
                    
                        Google.Protobuf.FieldCodec<uint> gen_ret = Google.Protobuf.FieldCodec.ForFixed32( _tag );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ForSFixed32_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    uint _tag = LuaAPI.xlua_touint(L, 1);
                    
                        Google.Protobuf.FieldCodec<int> gen_ret = Google.Protobuf.FieldCodec.ForSFixed32( _tag );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ForUInt32_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    uint _tag = LuaAPI.xlua_touint(L, 1);
                    
                        Google.Protobuf.FieldCodec<uint> gen_ret = Google.Protobuf.FieldCodec.ForUInt32( _tag );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ForInt64_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    uint _tag = LuaAPI.xlua_touint(L, 1);
                    
                        Google.Protobuf.FieldCodec<long> gen_ret = Google.Protobuf.FieldCodec.ForInt64( _tag );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ForSInt64_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    uint _tag = LuaAPI.xlua_touint(L, 1);
                    
                        Google.Protobuf.FieldCodec<long> gen_ret = Google.Protobuf.FieldCodec.ForSInt64( _tag );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ForFixed64_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    uint _tag = LuaAPI.xlua_touint(L, 1);
                    
                        Google.Protobuf.FieldCodec<ulong> gen_ret = Google.Protobuf.FieldCodec.ForFixed64( _tag );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ForSFixed64_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    uint _tag = LuaAPI.xlua_touint(L, 1);
                    
                        Google.Protobuf.FieldCodec<long> gen_ret = Google.Protobuf.FieldCodec.ForSFixed64( _tag );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ForUInt64_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    uint _tag = LuaAPI.xlua_touint(L, 1);
                    
                        Google.Protobuf.FieldCodec<ulong> gen_ret = Google.Protobuf.FieldCodec.ForUInt64( _tag );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ForFloat_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    uint _tag = LuaAPI.xlua_touint(L, 1);
                    
                        Google.Protobuf.FieldCodec<float> gen_ret = Google.Protobuf.FieldCodec.ForFloat( _tag );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ForDouble_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    uint _tag = LuaAPI.xlua_touint(L, 1);
                    
                        Google.Protobuf.FieldCodec<double> gen_ret = Google.Protobuf.FieldCodec.ForDouble( _tag );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
