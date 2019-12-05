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
    public class MongoDBBsonIOOutputBufferChunkSourceWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.IO.OutputBufferChunkSource);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 4, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetChunk", _m_GetChunk);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "BaseSource", _g_get_BaseSource);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "InitialUnpooledChunkSize", _g_get_InitialUnpooledChunkSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MaxChunkSize", _g_get_MaxChunkSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MinChunkSize", _g_get_MinChunkSize);
            
			
			
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
				if(LuaAPI.lua_gettop(L) == 5 && translator.Assignable<MongoDB.Bson.IO.IBsonChunkSource>(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5))
				{
					MongoDB.Bson.IO.IBsonChunkSource _baseSource = (MongoDB.Bson.IO.IBsonChunkSource)translator.GetObject(L, 2, typeof(MongoDB.Bson.IO.IBsonChunkSource));
					int _initialUnpooledChunkSize = LuaAPI.xlua_tointeger(L, 3);
					int _minChunkSize = LuaAPI.xlua_tointeger(L, 4);
					int _maxChunkSize = LuaAPI.xlua_tointeger(L, 5);
					
					MongoDB.Bson.IO.OutputBufferChunkSource gen_ret = new MongoDB.Bson.IO.OutputBufferChunkSource(_baseSource, _initialUnpooledChunkSize, _minChunkSize, _maxChunkSize);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<MongoDB.Bson.IO.IBsonChunkSource>(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4))
				{
					MongoDB.Bson.IO.IBsonChunkSource _baseSource = (MongoDB.Bson.IO.IBsonChunkSource)translator.GetObject(L, 2, typeof(MongoDB.Bson.IO.IBsonChunkSource));
					int _initialUnpooledChunkSize = LuaAPI.xlua_tointeger(L, 3);
					int _minChunkSize = LuaAPI.xlua_tointeger(L, 4);
					
					MongoDB.Bson.IO.OutputBufferChunkSource gen_ret = new MongoDB.Bson.IO.OutputBufferChunkSource(_baseSource, _initialUnpooledChunkSize, _minChunkSize);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<MongoDB.Bson.IO.IBsonChunkSource>(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
				{
					MongoDB.Bson.IO.IBsonChunkSource _baseSource = (MongoDB.Bson.IO.IBsonChunkSource)translator.GetObject(L, 2, typeof(MongoDB.Bson.IO.IBsonChunkSource));
					int _initialUnpooledChunkSize = LuaAPI.xlua_tointeger(L, 3);
					
					MongoDB.Bson.IO.OutputBufferChunkSource gen_ret = new MongoDB.Bson.IO.OutputBufferChunkSource(_baseSource, _initialUnpooledChunkSize);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<MongoDB.Bson.IO.IBsonChunkSource>(L, 2))
				{
					MongoDB.Bson.IO.IBsonChunkSource _baseSource = (MongoDB.Bson.IO.IBsonChunkSource)translator.GetObject(L, 2, typeof(MongoDB.Bson.IO.IBsonChunkSource));
					
					MongoDB.Bson.IO.OutputBufferChunkSource gen_ret = new MongoDB.Bson.IO.OutputBufferChunkSource(_baseSource);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.IO.OutputBufferChunkSource constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.OutputBufferChunkSource gen_to_be_invoked = (MongoDB.Bson.IO.OutputBufferChunkSource)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetChunk(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.IO.OutputBufferChunkSource gen_to_be_invoked = (MongoDB.Bson.IO.OutputBufferChunkSource)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _requestedSize = LuaAPI.xlua_tointeger(L, 2);
                    
                        MongoDB.Bson.IO.IBsonChunk gen_ret = gen_to_be_invoked.GetChunk( _requestedSize );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BaseSource(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.OutputBufferChunkSource gen_to_be_invoked = (MongoDB.Bson.IO.OutputBufferChunkSource)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.BaseSource);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_InitialUnpooledChunkSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.OutputBufferChunkSource gen_to_be_invoked = (MongoDB.Bson.IO.OutputBufferChunkSource)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.InitialUnpooledChunkSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MaxChunkSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.OutputBufferChunkSource gen_to_be_invoked = (MongoDB.Bson.IO.OutputBufferChunkSource)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.MaxChunkSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MinChunkSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.IO.OutputBufferChunkSource gen_to_be_invoked = (MongoDB.Bson.IO.OutputBufferChunkSource)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.MinChunkSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
