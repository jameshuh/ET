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
using MongoDB.Bson.IO;

namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class MongoDBBsonIOBsonStreamWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.IO.BsonStream);
			Utils.BeginObjectRegister(type, L, translator, 0, 28, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReadCString", _m_ReadCString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReadCStringBytes", _m_ReadCStringBytes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReadDecimal128", _m_ReadDecimal128);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReadDouble", _m_ReadDouble);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReadInt32", _m_ReadInt32);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReadInt64", _m_ReadInt64);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReadObjectId", _m_ReadObjectId);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReadSlice", _m_ReadSlice);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReadString", _m_ReadString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SkipCString", _m_SkipCString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteCString", _m_WriteCString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteCStringBytes", _m_WriteCStringBytes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteDecimal128", _m_WriteDecimal128);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteDouble", _m_WriteDouble);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteInt32", _m_WriteInt32);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteInt64", _m_WriteInt64);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteObjectId", _m_WriteObjectId);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteString", _m_WriteString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BackpatchSize", _m_BackpatchSize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReadBinarySubType", _m_ReadBinarySubType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReadBoolean", _m_ReadBoolean);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReadBsonType", _m_ReadBsonType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ReadBytes", _m_ReadBytes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteBinarySubType", _m_WriteBinarySubType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteBoolean", _m_WriteBoolean);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteBsonType", _m_WriteBsonType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteBytes", _m_WriteBytes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteSlice", _m_WriteSlice);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "MongoDB.Bson.IO.BsonStream does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadCString(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Text.UTF8Encoding _encoding = (System.Text.UTF8Encoding)translator.GetObject(L, 2, typeof(System.Text.UTF8Encoding));
                    
                        string gen_ret = gen_to_be_invoked.ReadCString( _encoding );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadCStringBytes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.ArraySegment<byte> gen_ret = gen_to_be_invoked.ReadCStringBytes(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadDecimal128(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        MongoDB.Bson.Decimal128 gen_ret = gen_to_be_invoked.ReadDecimal128(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadDouble(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        double gen_ret = gen_to_be_invoked.ReadDouble(  );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadInt32(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int gen_ret = gen_to_be_invoked.ReadInt32(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadInt64(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        long gen_ret = gen_to_be_invoked.ReadInt64(  );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadObjectId(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        MongoDB.Bson.ObjectId gen_ret = gen_to_be_invoked.ReadObjectId(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadSlice(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        MongoDB.Bson.IO.IByteBuffer gen_ret = gen_to_be_invoked.ReadSlice(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadString(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Text.UTF8Encoding _encoding = (System.Text.UTF8Encoding)translator.GetObject(L, 2, typeof(System.Text.UTF8Encoding));
                    
                        string gen_ret = gen_to_be_invoked.ReadString( _encoding );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SkipCString(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SkipCString(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteCString(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _value = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.WriteCString( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteCStringBytes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    byte[] _value = LuaAPI.lua_tobytes(L, 2);
                    
                    gen_to_be_invoked.WriteCStringBytes( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteDecimal128(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.Decimal128 _value;translator.Get(L, 2, out _value);
                    
                    gen_to_be_invoked.WriteDecimal128( _value );
                    
                    
                    
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
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_WriteInt32(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_WriteInt64(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_WriteObjectId(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.ObjectId _value;translator.Get(L, 2, out _value);
                    
                    gen_to_be_invoked.WriteObjectId( _value );
                    
                    
                    
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
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _value = LuaAPI.lua_tostring(L, 2);
                    System.Text.UTF8Encoding _encoding = (System.Text.UTF8Encoding)translator.GetObject(L, 3, typeof(System.Text.UTF8Encoding));
                    
                    gen_to_be_invoked.WriteString( _value, _encoding );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BackpatchSize(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    long _startPosition = LuaAPI.lua_toint64(L, 2);
                    
                    gen_to_be_invoked.BackpatchSize( _startPosition );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadBinarySubType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        MongoDB.Bson.BsonBinarySubType gen_ret = gen_to_be_invoked.ReadBinarySubType(  );
                        translator.PushMongoDBBsonBsonBinarySubType(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadBoolean(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        bool gen_ret = gen_to_be_invoked.ReadBoolean(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadBsonType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        MongoDB.Bson.BsonType gen_ret = gen_to_be_invoked.ReadBsonType(  );
                        translator.PushMongoDBBsonBsonType(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadBytes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _count = LuaAPI.xlua_tointeger(L, 2);
                    
                        byte[] gen_ret = gen_to_be_invoked.ReadBytes( _count );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _count = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.ReadBytes( _buffer, _offset, _count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.IO.BsonStream.ReadBytes!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteBinarySubType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.BsonBinarySubType _value;translator.Get(L, 2, out _value);
                    
                    gen_to_be_invoked.WriteBinarySubType( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteBoolean(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _value = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.WriteBoolean( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteBsonType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.BsonType _value;translator.Get(L, 2, out _value);
                    
                    gen_to_be_invoked.WriteBsonType( _value );
                    
                    
                    
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
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _count = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.WriteBytes( _buffer, _offset, _count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteSlice(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.BsonStream gen_to_be_invoked = (MongoDB.Bson.IO.BsonStream)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.IO.IByteBuffer _slice = (MongoDB.Bson.IO.IByteBuffer)translator.GetObject(L, 2, typeof(MongoDB.Bson.IO.IByteBuffer));
                    
                    gen_to_be_invoked.WriteSlice( _slice );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
