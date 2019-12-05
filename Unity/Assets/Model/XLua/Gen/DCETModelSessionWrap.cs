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
    public class DCETModelSessionWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DCET.Model.Session);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 7, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Awake", _m_Awake);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnRead", _m_OnRead);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CallWithoutException", _m_CallWithoutException);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Call", _m_Call);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Reply", _m_Reply);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Send", _m_Send);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "LastRecvTime", _g_get_LastRecvTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LastSendTime", _g_get_LastSendTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Network", _g_get_Network);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Error", _g_get_Error);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "RemoteAddress", _g_get_RemoteAddress);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ChannelType", _g_get_ChannelType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Stream", _g_get_Stream);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Error", _s_set_Error);
            
			
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
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					DCET.Model.Session gen_ret = new DCET.Model.Session();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to DCET.Model.Session constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Awake(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.Session gen_to_be_invoked = (DCET.Model.Session)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    DCET.Model.AChannel _aChannel = (DCET.Model.AChannel)translator.GetObject(L, 2, typeof(DCET.Model.AChannel));
                    
                    gen_to_be_invoked.Awake( _aChannel );
                    
                    
                    
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
            
            
                DCET.Model.Session gen_to_be_invoked = (DCET.Model.Session)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnRead(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.Session gen_to_be_invoked = (DCET.Model.Session)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IO.MemoryStream _memoryStream = (System.IO.MemoryStream)translator.GetObject(L, 2, typeof(System.IO.MemoryStream));
                    
                    gen_to_be_invoked.OnRead( _memoryStream );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CallWithoutException(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.Session gen_to_be_invoked = (DCET.Model.Session)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    DCET.Model.IRequest _request = (DCET.Model.IRequest)translator.GetObject(L, 2, typeof(DCET.Model.IRequest));
                    
                        DCET.Model.ETTask<DCET.Model.IResponse> gen_ret = gen_to_be_invoked.CallWithoutException( _request );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Call(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.Session gen_to_be_invoked = (DCET.Model.Session)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    DCET.Model.IRequest _request = (DCET.Model.IRequest)translator.GetObject(L, 2, typeof(DCET.Model.IRequest));
                    
                        DCET.Model.ETTask<DCET.Model.IResponse> gen_ret = gen_to_be_invoked.Call( _request );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Reply(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.Session gen_to_be_invoked = (DCET.Model.Session)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    DCET.Model.IResponse _message = (DCET.Model.IResponse)translator.GetObject(L, 2, typeof(DCET.Model.IResponse));
                    
                    gen_to_be_invoked.Reply( _message );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Send(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.Session gen_to_be_invoked = (DCET.Model.Session)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<DCET.Model.IMessage>(L, 2)) 
                {
                    DCET.Model.IMessage _message = (DCET.Model.IMessage)translator.GetObject(L, 2, typeof(DCET.Model.IMessage));
                    
                    gen_to_be_invoked.Send( _message );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<System.IO.MemoryStream>(L, 2)) 
                {
                    System.IO.MemoryStream _stream = (System.IO.MemoryStream)translator.GetObject(L, 2, typeof(System.IO.MemoryStream));
                    
                    gen_to_be_invoked.Send( _stream );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    ushort _opcode = (ushort)LuaAPI.xlua_tointeger(L, 2);
                    object _message = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.Send( _opcode, _message );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to DCET.Model.Session.Send!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LastRecvTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.Session gen_to_be_invoked = (DCET.Model.Session)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushint64(L, gen_to_be_invoked.LastRecvTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LastSendTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.Session gen_to_be_invoked = (DCET.Model.Session)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushint64(L, gen_to_be_invoked.LastSendTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Network(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.Session gen_to_be_invoked = (DCET.Model.Session)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Network);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Error(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.Session gen_to_be_invoked = (DCET.Model.Session)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Error);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RemoteAddress(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.Session gen_to_be_invoked = (DCET.Model.Session)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.RemoteAddress);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ChannelType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.Session gen_to_be_invoked = (DCET.Model.Session)translator.FastGetCSObj(L, 1);
                translator.PushDCETModelChannelType(L, gen_to_be_invoked.ChannelType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Stream(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.Session gen_to_be_invoked = (DCET.Model.Session)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Stream);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Error(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.Session gen_to_be_invoked = (DCET.Model.Session)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Error = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
