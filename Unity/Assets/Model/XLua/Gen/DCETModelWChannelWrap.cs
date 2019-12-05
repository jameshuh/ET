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
    public class DCETModelWChannelWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DCET.Model.WChannel);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 2, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Start", _m_Start);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ConnectAsync", _m_ConnectAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Send", _m_Send);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StartSend", _m_StartSend);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StartRecv", _m_StartRecv);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "WebSocketContext", _g_get_WebSocketContext);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Stream", _g_get_Stream);
            
			
			
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
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<System.Net.WebSockets.HttpListenerWebSocketContext>(L, 2) && translator.Assignable<DCET.Model.AService>(L, 3))
				{
					System.Net.WebSockets.HttpListenerWebSocketContext _webSocketContext = (System.Net.WebSockets.HttpListenerWebSocketContext)translator.GetObject(L, 2, typeof(System.Net.WebSockets.HttpListenerWebSocketContext));
					DCET.Model.AService _service = (DCET.Model.AService)translator.GetObject(L, 3, typeof(DCET.Model.AService));
					
					DCET.Model.WChannel gen_ret = new DCET.Model.WChannel(_webSocketContext, _service);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<System.Net.WebSockets.WebSocket>(L, 2) && translator.Assignable<DCET.Model.AService>(L, 3))
				{
					System.Net.WebSockets.WebSocket _webSocket = (System.Net.WebSockets.WebSocket)translator.GetObject(L, 2, typeof(System.Net.WebSockets.WebSocket));
					DCET.Model.AService _service = (DCET.Model.AService)translator.GetObject(L, 3, typeof(DCET.Model.AService));
					
					DCET.Model.WChannel gen_ret = new DCET.Model.WChannel(_webSocket, _service);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to DCET.Model.WChannel constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.WChannel gen_to_be_invoked = (DCET.Model.WChannel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Start(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.WChannel gen_to_be_invoked = (DCET.Model.WChannel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Start(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ConnectAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.WChannel gen_to_be_invoked = (DCET.Model.WChannel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _url = LuaAPI.lua_tostring(L, 2);
                    
                        DCET.Model.ETVoid gen_ret = gen_to_be_invoked.ConnectAsync( _url );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
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
            
            
                DCET.Model.WChannel gen_to_be_invoked = (DCET.Model.WChannel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IO.MemoryStream _stream = (System.IO.MemoryStream)translator.GetObject(L, 2, typeof(System.IO.MemoryStream));
                    
                    gen_to_be_invoked.Send( _stream );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StartSend(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.WChannel gen_to_be_invoked = (DCET.Model.WChannel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        DCET.Model.ETVoid gen_ret = gen_to_be_invoked.StartSend(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StartRecv(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.WChannel gen_to_be_invoked = (DCET.Model.WChannel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        DCET.Model.ETVoid gen_ret = gen_to_be_invoked.StartRecv(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_WebSocketContext(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.WChannel gen_to_be_invoked = (DCET.Model.WChannel)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.WebSocketContext);
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
			
                DCET.Model.WChannel gen_to_be_invoked = (DCET.Model.WChannel)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Stream);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
