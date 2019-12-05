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
    public class GoogleProtobufMessageParserWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Google.Protobuf.MessageParser);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ParseFrom", _m_ParseFrom);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ParseDelimitedFrom", _m_ParseDelimitedFrom);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "Google.Protobuf.MessageParser does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ParseFrom(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.MessageParser gen_to_be_invoked = (Google.Protobuf.MessageParser)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    byte[] _data = LuaAPI.lua_tobytes(L, 2);
                    
                        Google.Protobuf.IMessage gen_ret = gen_to_be_invoked.ParseFrom( _data );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<Google.Protobuf.ByteString>(L, 2)) 
                {
                    Google.Protobuf.ByteString _data = (Google.Protobuf.ByteString)translator.GetObject(L, 2, typeof(Google.Protobuf.ByteString));
                    
                        Google.Protobuf.IMessage gen_ret = gen_to_be_invoked.ParseFrom( _data );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.IO.Stream>(L, 2)) 
                {
                    System.IO.Stream _input = (System.IO.Stream)translator.GetObject(L, 2, typeof(System.IO.Stream));
                    
                        Google.Protobuf.IMessage gen_ret = gen_to_be_invoked.ParseFrom( _input );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<Google.Protobuf.CodedInputStream>(L, 2)) 
                {
                    Google.Protobuf.CodedInputStream _input = (Google.Protobuf.CodedInputStream)translator.GetObject(L, 2, typeof(Google.Protobuf.CodedInputStream));
                    
                        Google.Protobuf.IMessage gen_ret = gen_to_be_invoked.ParseFrom( _input );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Google.Protobuf.MessageParser.ParseFrom!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ParseDelimitedFrom(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Google.Protobuf.MessageParser gen_to_be_invoked = (Google.Protobuf.MessageParser)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IO.Stream _input = (System.IO.Stream)translator.GetObject(L, 2, typeof(System.IO.Stream));
                    
                        Google.Protobuf.IMessage gen_ret = gen_to_be_invoked.ParseDelimitedFrom( _input );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
