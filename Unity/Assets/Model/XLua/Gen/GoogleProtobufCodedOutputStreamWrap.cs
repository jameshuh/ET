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
    public class GoogleProtobufCodedOutputStreamWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Google.Protobuf.CodedOutputStream);
			Utils.BeginObjectRegister(type, L, translator, 0, 24, 2, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Reset", _m_Reset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteDouble", _m_WriteDouble);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteFloat", _m_WriteFloat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteUInt64", _m_WriteUInt64);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteInt64", _m_WriteInt64);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteInt32", _m_WriteInt32);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteFixed64", _m_WriteFixed64);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteFixed32", _m_WriteFixed32);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteBool", _m_WriteBool);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteString", _m_WriteString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteMessage", _m_WriteMessage);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteBytes", _m_WriteBytes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteUInt32", _m_WriteUInt32);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteEnum", _m_WriteEnum);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteSFixed32", _m_WriteSFixed32);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteSFixed64", _m_WriteSFixed64);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteSInt32", _m_WriteSInt32);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteSInt64", _m_WriteSInt64);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteLength", _m_WriteLength);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteTag", _m_WriteTag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteRawTag", _m_WriteRawTag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Flush", _m_Flush);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CheckNoSpaceLeft", _m_CheckNoSpaceLeft);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Position", _g_get_Position);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "SpaceLeft", _g_get_SpaceLeft);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 24, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeDoubleSize", _m_ComputeDoubleSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeFloatSize", _m_ComputeFloatSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeUInt64Size", _m_ComputeUInt64Size_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeInt64Size", _m_ComputeInt64Size_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeInt32Size", _m_ComputeInt32Size_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeFixed64Size", _m_ComputeFixed64Size_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeFixed32Size", _m_ComputeFixed32Size_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeBoolSize", _m_ComputeBoolSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeStringSize", _m_ComputeStringSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeGroupSize", _m_ComputeGroupSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeMessageSize", _m_ComputeMessageSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeBytesSize", _m_ComputeBytesSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeUInt32Size", _m_ComputeUInt32Size_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeEnumSize", _m_ComputeEnumSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeSFixed32Size", _m_ComputeSFixed32Size_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeSFixed64Size", _m_ComputeSFixed64Size_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeSInt32Size", _m_ComputeSInt32Size_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeSInt64Size", _m_ComputeSInt64Size_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeLengthSize", _m_ComputeLengthSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeRawVarint32Size", _m_ComputeRawVarint32Size_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeRawVarint64Size", _m_ComputeRawVarint64Size_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeTagSize", _m_ComputeTagSize_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DefaultBufferSize", Google.Protobuf.CodedOutputStream.DefaultBufferSize);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING))
				{
					byte[] _flatArray = LuaAPI.lua_tobytes(L, 2);
					
					Google.Protobuf.CodedOutputStream gen_ret = new Google.Protobuf.CodedOutputStream(_flatArray);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.IO.Stream>(L, 2))
				{
					System.IO.Stream _output = (System.IO.Stream)translator.GetObject(L, 2, typeof(System.IO.Stream));
					
					Google.Protobuf.CodedOutputStream gen_ret = new Google.Protobuf.CodedOutputStream(_output);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<System.IO.Stream>(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
				{
					System.IO.Stream _output = (System.IO.Stream)translator.GetObject(L, 2, typeof(System.IO.Stream));
					int _bufferSize = LuaAPI.xlua_tointeger(L, 3);
					
					Google.Protobuf.CodedOutputStream gen_ret = new Google.Protobuf.CodedOutputStream(_output, _bufferSize);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<System.IO.Stream>(L, 2) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3))
				{
					System.IO.Stream _output = (System.IO.Stream)translator.GetObject(L, 2, typeof(System.IO.Stream));
					bool _leaveOpen = LuaAPI.lua_toboolean(L, 3);
					
					Google.Protobuf.CodedOutputStream gen_ret = new Google.Protobuf.CodedOutputStream(_output, _leaveOpen);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<System.IO.Stream>(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4))
				{
					System.IO.Stream _output = (System.IO.Stream)translator.GetObject(L, 2, typeof(System.IO.Stream));
					int _bufferSize = LuaAPI.xlua_tointeger(L, 3);
					bool _leaveOpen = LuaAPI.lua_toboolean(L, 4);
					
					Google.Protobuf.CodedOutputStream gen_ret = new Google.Protobuf.CodedOutputStream(_output, _bufferSize, _leaveOpen);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Google.Protobuf.CodedOutputStream constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeDoubleSize_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    double _value = LuaAPI.lua_tonumber(L, 1);
                    
                        int gen_ret = Google.Protobuf.CodedOutputStream.ComputeDoubleSize( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeFloatSize_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    float _value = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        int gen_ret = Google.Protobuf.CodedOutputStream.ComputeFloatSize( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeUInt64Size_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    ulong _value = LuaAPI.lua_touint64(L, 1);
                    
                        int gen_ret = Google.Protobuf.CodedOutputStream.ComputeUInt64Size( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeInt64Size_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    long _value = LuaAPI.lua_toint64(L, 1);
                    
                        int gen_ret = Google.Protobuf.CodedOutputStream.ComputeInt64Size( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeInt32Size_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _value = LuaAPI.xlua_tointeger(L, 1);
                    
                        int gen_ret = Google.Protobuf.CodedOutputStream.ComputeInt32Size( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeFixed64Size_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    ulong _value = LuaAPI.lua_touint64(L, 1);
                    
                        int gen_ret = Google.Protobuf.CodedOutputStream.ComputeFixed64Size( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeFixed32Size_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    uint _value = LuaAPI.xlua_touint(L, 1);
                    
                        int gen_ret = Google.Protobuf.CodedOutputStream.ComputeFixed32Size( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeBoolSize_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    bool _value = LuaAPI.lua_toboolean(L, 1);
                    
                        int gen_ret = Google.Protobuf.CodedOutputStream.ComputeBoolSize( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeStringSize_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _value = LuaAPI.lua_tostring(L, 1);
                    
                        int gen_ret = Google.Protobuf.CodedOutputStream.ComputeStringSize( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeGroupSize_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    Google.Protobuf.IMessage _value = (Google.Protobuf.IMessage)translator.GetObject(L, 1, typeof(Google.Protobuf.IMessage));
                    
                        int gen_ret = Google.Protobuf.CodedOutputStream.ComputeGroupSize( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeMessageSize_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    Google.Protobuf.IMessage _value = (Google.Protobuf.IMessage)translator.GetObject(L, 1, typeof(Google.Protobuf.IMessage));
                    
                        int gen_ret = Google.Protobuf.CodedOutputStream.ComputeMessageSize( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeBytesSize_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    Google.Protobuf.ByteString _value = (Google.Protobuf.ByteString)translator.GetObject(L, 1, typeof(Google.Protobuf.ByteString));
                    
                        int gen_ret = Google.Protobuf.CodedOutputStream.ComputeBytesSize( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeUInt32Size_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    uint _value = LuaAPI.xlua_touint(L, 1);
                    
                        int gen_ret = Google.Protobuf.CodedOutputStream.ComputeUInt32Size( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeEnumSize_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _value = LuaAPI.xlua_tointeger(L, 1);
                    
                        int gen_ret = Google.Protobuf.CodedOutputStream.ComputeEnumSize( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeSFixed32Size_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _value = LuaAPI.xlua_tointeger(L, 1);
                    
                        int gen_ret = Google.Protobuf.CodedOutputStream.ComputeSFixed32Size( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeSFixed64Size_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    long _value = LuaAPI.lua_toint64(L, 1);
                    
                        int gen_ret = Google.Protobuf.CodedOutputStream.ComputeSFixed64Size( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeSInt32Size_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _value = LuaAPI.xlua_tointeger(L, 1);
                    
                        int gen_ret = Google.Protobuf.CodedOutputStream.ComputeSInt32Size( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeSInt64Size_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    long _value = LuaAPI.lua_toint64(L, 1);
                    
                        int gen_ret = Google.Protobuf.CodedOutputStream.ComputeSInt64Size( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeLengthSize_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _length = LuaAPI.xlua_tointeger(L, 1);
                    
                        int gen_ret = Google.Protobuf.CodedOutputStream.ComputeLengthSize( _length );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeRawVarint32Size_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    uint _value = LuaAPI.xlua_touint(L, 1);
                    
                        int gen_ret = Google.Protobuf.CodedOutputStream.ComputeRawVarint32Size( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeRawVarint64Size_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    ulong _value = LuaAPI.lua_touint64(L, 1);
                    
                        int gen_ret = Google.Protobuf.CodedOutputStream.ComputeRawVarint64Size( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeTagSize_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _fieldNumber = LuaAPI.xlua_tointeger(L, 1);
                    
                        int gen_ret = Google.Protobuf.CodedOutputStream.ComputeTagSize( _fieldNumber );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Reset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    byte[] _buf = LuaAPI.lua_tobytes(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _length = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.Reset( _buf, _offset, _length );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteDouble(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    double _value = LuaAPI.lua_tonumber(L, 2);
                    
                    gen_to_be_invoked.WriteDouble( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteFloat(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _value = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    gen_to_be_invoked.WriteFloat( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteUInt64(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ulong _value = LuaAPI.lua_touint64(L, 2);
                    
                    gen_to_be_invoked.WriteUInt64( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteInt64(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    long _value = LuaAPI.lua_toint64(L, 2);
                    
                    gen_to_be_invoked.WriteInt64( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteInt32(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _value = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.WriteInt32( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteFixed64(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ulong _value = LuaAPI.lua_touint64(L, 2);
                    
                    gen_to_be_invoked.WriteFixed64( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteFixed32(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    uint _value = LuaAPI.xlua_touint(L, 2);
                    
                    gen_to_be_invoked.WriteFixed32( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteBool(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _value = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.WriteBool( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteString(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _value = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.WriteString( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteMessage(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Google.Protobuf.IMessage _value = (Google.Protobuf.IMessage)translator.GetObject(L, 2, typeof(Google.Protobuf.IMessage));
                    
                    gen_to_be_invoked.WriteMessage( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteBytes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Google.Protobuf.ByteString _value = (Google.Protobuf.ByteString)translator.GetObject(L, 2, typeof(Google.Protobuf.ByteString));
                    
                    gen_to_be_invoked.WriteBytes( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteUInt32(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    uint _value = LuaAPI.xlua_touint(L, 2);
                    
                    gen_to_be_invoked.WriteUInt32( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteEnum(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _value = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.WriteEnum( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteSFixed32(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _value = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.WriteSFixed32( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteSFixed64(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    long _value = LuaAPI.lua_toint64(L, 2);
                    
                    gen_to_be_invoked.WriteSFixed64( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteSInt32(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _value = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.WriteSInt32( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteSInt64(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    long _value = LuaAPI.lua_toint64(L, 2);
                    
                    gen_to_be_invoked.WriteSInt64( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteLength(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _length = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.WriteLength( _length );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteTag(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    uint _tag = LuaAPI.xlua_touint(L, 2);
                    
                    gen_to_be_invoked.WriteTag( _tag );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<Google.Protobuf.WireFormat.WireType>(L, 3)) 
                {
                    int _fieldNumber = LuaAPI.xlua_tointeger(L, 2);
                    Google.Protobuf.WireFormat.WireType _type;translator.Get(L, 3, out _type);
                    
                    gen_to_be_invoked.WriteTag( _fieldNumber, _type );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Google.Protobuf.CodedOutputStream.WriteTag!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteRawTag(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    byte _b1 = (byte)LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.WriteRawTag( _b1 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    byte _b1 = (byte)LuaAPI.xlua_tointeger(L, 2);
                    byte _b2 = (byte)LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.WriteRawTag( _b1, _b2 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    byte _b1 = (byte)LuaAPI.xlua_tointeger(L, 2);
                    byte _b2 = (byte)LuaAPI.xlua_tointeger(L, 3);
                    byte _b3 = (byte)LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.WriteRawTag( _b1, _b2, _b3 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    byte _b1 = (byte)LuaAPI.xlua_tointeger(L, 2);
                    byte _b2 = (byte)LuaAPI.xlua_tointeger(L, 3);
                    byte _b3 = (byte)LuaAPI.xlua_tointeger(L, 4);
                    byte _b4 = (byte)LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.WriteRawTag( _b1, _b2, _b3, _b4 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    byte _b1 = (byte)LuaAPI.xlua_tointeger(L, 2);
                    byte _b2 = (byte)LuaAPI.xlua_tointeger(L, 3);
                    byte _b3 = (byte)LuaAPI.xlua_tointeger(L, 4);
                    byte _b4 = (byte)LuaAPI.xlua_tointeger(L, 5);
                    byte _b5 = (byte)LuaAPI.xlua_tointeger(L, 6);
                    
                    gen_to_be_invoked.WriteRawTag( _b1, _b2, _b3, _b4, _b5 );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Google.Protobuf.CodedOutputStream.WriteRawTag!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Flush(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Flush(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CheckNoSpaceLeft(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.CheckNoSpaceLeft(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Position(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushint64(L, gen_to_be_invoked.Position);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SpaceLeft(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Google.Protobuf.CodedOutputStream gen_to_be_invoked = (Google.Protobuf.CodedOutputStream)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.SpaceLeft);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
