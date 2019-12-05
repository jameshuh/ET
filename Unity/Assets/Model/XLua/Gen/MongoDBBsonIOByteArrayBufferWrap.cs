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
    public class MongoDBBsonIOByteArrayBufferWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.IO.ByteArrayBuffer);
			Utils.BeginObjectRegister(type, L, translator, 0, 10, 3, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AccessBackingBytes", _m_AccessBackingBytes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EnsureCapacity", _m_EnsureCapacity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetByte", _m_GetByte);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetBytes", _m_GetBytes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSlice", _m_GetSlice);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MakeReadOnly", _m_MakeReadOnly);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetByte", _m_SetByte);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetBytes", _m_SetBytes);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Capacity", _g_get_Capacity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsReadOnly", _g_get_IsReadOnly);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Length", _g_get_Length);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Length", _s_set_Length);
            
			
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
				if(LuaAPI.lua_gettop(L) == 3 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3))
				{
					byte[] _bytes = LuaAPI.lua_tobytes(L, 2);
					bool _isReadOnly = LuaAPI.lua_toboolean(L, 3);
					
					MongoDB.Bson.IO.ByteArrayBuffer gen_ret = new MongoDB.Bson.IO.ByteArrayBuffer(_bytes, _isReadOnly);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING))
				{
					byte[] _bytes = LuaAPI.lua_tobytes(L, 2);
					
					MongoDB.Bson.IO.ByteArrayBuffer gen_ret = new MongoDB.Bson.IO.ByteArrayBuffer(_bytes);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4))
				{
					byte[] _bytes = LuaAPI.lua_tobytes(L, 2);
					int _length = LuaAPI.xlua_tointeger(L, 3);
					bool _isReadOnly = LuaAPI.lua_toboolean(L, 4);
					
					MongoDB.Bson.IO.ByteArrayBuffer gen_ret = new MongoDB.Bson.IO.ByteArrayBuffer(_bytes, _length, _isReadOnly);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
				{
					byte[] _bytes = LuaAPI.lua_tobytes(L, 2);
					int _length = LuaAPI.xlua_tointeger(L, 3);
					
					MongoDB.Bson.IO.ByteArrayBuffer gen_ret = new MongoDB.Bson.IO.ByteArrayBuffer(_bytes, _length);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.IO.ByteArrayBuffer constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AccessBackingBytes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.ByteArrayBuffer gen_to_be_invoked = (MongoDB.Bson.IO.ByteArrayBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _position = LuaAPI.xlua_tointeger(L, 2);
                    
                        System.ArraySegment<byte> gen_ret = gen_to_be_invoked.AccessBackingBytes( _position );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.ByteArrayBuffer gen_to_be_invoked = (MongoDB.Bson.IO.ByteArrayBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _position = LuaAPI.xlua_tointeger(L, 2);
                    int _count = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.Clear( _position, _count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.ByteArrayBuffer gen_to_be_invoked = (MongoDB.Bson.IO.ByteArrayBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EnsureCapacity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.ByteArrayBuffer gen_to_be_invoked = (MongoDB.Bson.IO.ByteArrayBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _minimumCapacity = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.EnsureCapacity( _minimumCapacity );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetByte(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.ByteArrayBuffer gen_to_be_invoked = (MongoDB.Bson.IO.ByteArrayBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _position = LuaAPI.xlua_tointeger(L, 2);
                    
                        byte gen_ret = gen_to_be_invoked.GetByte( _position );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBytes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.ByteArrayBuffer gen_to_be_invoked = (MongoDB.Bson.IO.ByteArrayBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _position = LuaAPI.xlua_tointeger(L, 2);
                    byte[] _destination = LuaAPI.lua_tobytes(L, 3);
                    int _offset = LuaAPI.xlua_tointeger(L, 4);
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.GetBytes( _position, _destination, _offset, _count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSlice(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.ByteArrayBuffer gen_to_be_invoked = (MongoDB.Bson.IO.ByteArrayBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _position = LuaAPI.xlua_tointeger(L, 2);
                    int _length = LuaAPI.xlua_tointeger(L, 3);
                    
                        MongoDB.Bson.IO.IByteBuffer gen_ret = gen_to_be_invoked.GetSlice( _position, _length );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MakeReadOnly(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.ByteArrayBuffer gen_to_be_invoked = (MongoDB.Bson.IO.ByteArrayBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.MakeReadOnly(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetByte(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.ByteArrayBuffer gen_to_be_invoked = (MongoDB.Bson.IO.ByteArrayBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _position = LuaAPI.xlua_tointeger(L, 2);
                    byte _value = (byte)LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetByte( _position, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetBytes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.ByteArrayBuffer gen_to_be_invoked = (MongoDB.Bson.IO.ByteArrayBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _position = LuaAPI.xlua_tointeger(L, 2);
                    byte[] _source = LuaAPI.lua_tobytes(L, 3);
                    int _offset = LuaAPI.xlua_tointeger(L, 4);
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.SetBytes( _position, _source, _offset, _count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Capacity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.ByteArrayBuffer gen_to_be_invoked = (MongoDB.Bson.IO.ByteArrayBuffer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Capacity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsReadOnly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.ByteArrayBuffer gen_to_be_invoked = (MongoDB.Bson.IO.ByteArrayBuffer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsReadOnly);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Length(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.ByteArrayBuffer gen_to_be_invoked = (MongoDB.Bson.IO.ByteArrayBuffer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Length);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Length(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.ByteArrayBuffer gen_to_be_invoked = (MongoDB.Bson.IO.ByteArrayBuffer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Length = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
