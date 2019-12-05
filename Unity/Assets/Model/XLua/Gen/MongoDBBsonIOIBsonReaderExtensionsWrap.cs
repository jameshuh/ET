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
    public class MongoDBBsonIOIBsonReaderExtensionsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.IO.IBsonReaderExtensions);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 25, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "FindElement", _m_FindElement_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindStringElement", _m_FindStringElement_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadBinaryData", _m_ReadBinaryData_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadBoolean", _m_ReadBoolean_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadBytes", _m_ReadBytes_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadDateTime", _m_ReadDateTime_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadDecimal128", _m_ReadDecimal128_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadDouble", _m_ReadDouble_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadInt32", _m_ReadInt32_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadInt64", _m_ReadInt64_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadJavaScript", _m_ReadJavaScript_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadJavaScriptWithScope", _m_ReadJavaScriptWithScope_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadMaxKey", _m_ReadMaxKey_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadMinKey", _m_ReadMinKey_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadName", _m_ReadName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadNull", _m_ReadNull_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadObjectId", _m_ReadObjectId_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadRawBsonArray", _m_ReadRawBsonArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadRawBsonDocument", _m_ReadRawBsonDocument_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadRegularExpression", _m_ReadRegularExpression_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadString", _m_ReadString_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadSymbol", _m_ReadSymbol_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadTimestamp", _m_ReadTimestamp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadUndefined", _m_ReadUndefined_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "MongoDB.Bson.IO.IBsonReaderExtensions does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindElement_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = MongoDB.Bson.IO.IBsonReaderExtensions.FindElement( _reader, _name );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindStringElement_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        string gen_ret = MongoDB.Bson.IO.IBsonReaderExtensions.FindStringElement( _reader, _name );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadBinaryData_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        MongoDB.Bson.BsonBinaryData gen_ret = MongoDB.Bson.IO.IBsonReaderExtensions.ReadBinaryData( _reader, _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadBoolean_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = MongoDB.Bson.IO.IBsonReaderExtensions.ReadBoolean( _reader, _name );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadBytes_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        byte[] gen_ret = MongoDB.Bson.IO.IBsonReaderExtensions.ReadBytes( _reader, _name );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadDateTime_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        long gen_ret = MongoDB.Bson.IO.IBsonReaderExtensions.ReadDateTime( _reader, _name );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadDecimal128_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        MongoDB.Bson.Decimal128 gen_ret = MongoDB.Bson.IO.IBsonReaderExtensions.ReadDecimal128( _reader, _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadDouble_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        double gen_ret = MongoDB.Bson.IO.IBsonReaderExtensions.ReadDouble( _reader, _name );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadInt32_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        int gen_ret = MongoDB.Bson.IO.IBsonReaderExtensions.ReadInt32( _reader, _name );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadInt64_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        long gen_ret = MongoDB.Bson.IO.IBsonReaderExtensions.ReadInt64( _reader, _name );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadJavaScript_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        string gen_ret = MongoDB.Bson.IO.IBsonReaderExtensions.ReadJavaScript( _reader, _name );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadJavaScriptWithScope_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        string gen_ret = MongoDB.Bson.IO.IBsonReaderExtensions.ReadJavaScriptWithScope( _reader, _name );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadMaxKey_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    MongoDB.Bson.IO.IBsonReaderExtensions.ReadMaxKey( _reader, _name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadMinKey_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    MongoDB.Bson.IO.IBsonReaderExtensions.ReadMinKey( _reader, _name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadName_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<MongoDB.Bson.IO.IBsonReader>(L, 1)) 
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    
                        string gen_ret = MongoDB.Bson.IO.IBsonReaderExtensions.ReadName( _reader );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<MongoDB.Bson.IO.IBsonReader>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    MongoDB.Bson.IO.IBsonReaderExtensions.ReadName( _reader, _name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.IO.IBsonReaderExtensions.ReadName!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadNull_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    MongoDB.Bson.IO.IBsonReaderExtensions.ReadNull( _reader, _name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadObjectId_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        MongoDB.Bson.ObjectId gen_ret = MongoDB.Bson.IO.IBsonReaderExtensions.ReadObjectId( _reader, _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadRawBsonArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        MongoDB.Bson.IO.IByteBuffer gen_ret = MongoDB.Bson.IO.IBsonReaderExtensions.ReadRawBsonArray( _reader, _name );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadRawBsonDocument_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        MongoDB.Bson.IO.IByteBuffer gen_ret = MongoDB.Bson.IO.IBsonReaderExtensions.ReadRawBsonDocument( _reader, _name );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadRegularExpression_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        MongoDB.Bson.BsonRegularExpression gen_ret = MongoDB.Bson.IO.IBsonReaderExtensions.ReadRegularExpression( _reader, _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadString_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        string gen_ret = MongoDB.Bson.IO.IBsonReaderExtensions.ReadString( _reader, _name );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadSymbol_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        string gen_ret = MongoDB.Bson.IO.IBsonReaderExtensions.ReadSymbol( _reader, _name );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadTimestamp_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        long gen_ret = MongoDB.Bson.IO.IBsonReaderExtensions.ReadTimestamp( _reader, _name );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadUndefined_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    MongoDB.Bson.IO.IBsonReader _reader = (MongoDB.Bson.IO.IBsonReader)translator.GetObject(L, 1, typeof(MongoDB.Bson.IO.IBsonReader));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    MongoDB.Bson.IO.IBsonReaderExtensions.ReadUndefined( _reader, _name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
