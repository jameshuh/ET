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
    public class MongoDBBsonIOIBsonWriterExtensionsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.IO.IBsonWriterExtensions);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 24, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteBinaryData", _m_WriteBinaryData_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteBoolean", _m_WriteBoolean_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteBytes", _m_WriteBytes_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteDateTime", _m_WriteDateTime_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteDecimal128", _m_WriteDecimal128_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteDouble", _m_WriteDouble_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteInt32", _m_WriteInt32_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteInt64", _m_WriteInt64_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteJavaScript", _m_WriteJavaScript_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteJavaScriptWithScope", _m_WriteJavaScriptWithScope_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteMaxKey", _m_WriteMaxKey_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteMinKey", _m_WriteMinKey_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteNull", _m_WriteNull_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteObjectId", _m_WriteObjectId_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteRawBsonArray", _m_WriteRawBsonArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteRawBsonDocument", _m_WriteRawBsonDocument_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteRegularExpression", _m_WriteRegularExpression_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteStartArray", _m_WriteStartArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteStartDocument", _m_WriteStartDocument_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteString", _m_WriteString_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteSymbol", _m_WriteSymbol_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteTimestamp", _m_WriteTimestamp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WriteUndefined", _m_WriteUndefined_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "MongoDB.Bson.IO.IBsonWriterExtensions does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteBinaryData_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    MongoDB.Bson.BsonBinaryData _binaryData = (MongoDB.Bson.BsonBinaryData)translator.GetObject(L, 3, typeof(MongoDB.Bson.BsonBinaryData));
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteBinaryData( _writer, _name, _binaryData );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteBoolean_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    bool _value = LuaAPI.lua_toboolean(L, 3);
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteBoolean( _writer, _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteBytes_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    byte[] _bytes = LuaAPI.lua_tobytes(L, 3);
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteBytes( _writer, _name, _bytes );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteDateTime_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    long _value = LuaAPI.lua_toint64(L, 3);
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteDateTime( _writer, _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteDecimal128_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    MongoDB.Bson.Decimal128 _value;translator.Get(L, 3, out _value);
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteDecimal128( _writer, _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteDouble_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    double _value = LuaAPI.lua_tonumber(L, 3);
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteDouble( _writer, _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteInt32_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    int _value = LuaAPI.xlua_tointeger(L, 3);
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteInt32( _writer, _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteInt64_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    long _value = LuaAPI.lua_toint64(L, 3);
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteInt64( _writer, _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteJavaScript_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    string _code = LuaAPI.lua_tostring(L, 3);
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteJavaScript( _writer, _name, _code );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteJavaScriptWithScope_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    string _code = LuaAPI.lua_tostring(L, 3);
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteJavaScriptWithScope( _writer, _name, _code );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteMaxKey_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteMaxKey( _writer, _name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteMinKey_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteMinKey( _writer, _name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteNull_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteNull( _writer, _name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteObjectId_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    MongoDB.Bson.ObjectId _objectId;translator.Get(L, 3, out _objectId);
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteObjectId( _writer, _name, _objectId );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteRawBsonArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    MongoDB.Bson.IO.IByteBuffer _slice = (MongoDB.Bson.IO.IByteBuffer)translator.GetObject(L, 3, typeof(MongoDB.Bson.IO.IByteBuffer));
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteRawBsonArray( _writer, _name, _slice );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteRawBsonDocument_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    MongoDB.Bson.IO.IByteBuffer _slice = (MongoDB.Bson.IO.IByteBuffer)translator.GetObject(L, 3, typeof(MongoDB.Bson.IO.IByteBuffer));
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteRawBsonDocument( _writer, _name, _slice );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteRegularExpression_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    MongoDB.Bson.BsonRegularExpression _regex = (MongoDB.Bson.BsonRegularExpression)translator.GetObject(L, 3, typeof(MongoDB.Bson.BsonRegularExpression));
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteRegularExpression( _writer, _name, _regex );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteStartArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteStartArray( _writer, _name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteStartDocument_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteStartDocument( _writer, _name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteString_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    string _value = LuaAPI.lua_tostring(L, 3);
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteString( _writer, _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteSymbol_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    string _value = LuaAPI.lua_tostring(L, 3);
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteSymbol( _writer, _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteTimestamp_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    long _value = LuaAPI.lua_toint64(L, 3);
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteTimestamp( _writer, _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteUndefined_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonWriter _writer = (MongoDB.Bson.IO.IBsonWriter)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonWriter));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    MongoDB.Bson.IO.IBsonWriterExtensions.WriteUndefined( _writer, _name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
