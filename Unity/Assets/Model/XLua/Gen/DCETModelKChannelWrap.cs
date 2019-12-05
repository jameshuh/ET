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
    public class DCETModelKChannelWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DCET.Model.KChannel);
			Utils.BeginObjectRegister(type, L, translator, 0, 9, 3, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Disconnect", _m_Disconnect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HandleConnnect", _m_HandleConnnect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Accept", _m_Accept);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Update", _m_Update);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HandleRecv", _m_HandleRecv);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Output", _m_Output);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetOutput", _m_SetOutput);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Send", _m_Send);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "RemoteConn", _g_get_RemoteConn);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LocalConn", _g_get_LocalConn);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Stream", _g_get_Stream);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "LocalConn", _s_set_LocalConn);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "KcpOutput", _m_KcpOutput_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 6 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && translator.Assignable<System.Net.Sockets.Socket>(L, 4) && translator.Assignable<System.Net.IPEndPoint>(L, 5) && translator.Assignable<DCET.Model.KService>(L, 6))
				{
					uint _localConn = LuaAPI.xlua_touint(L, 2);
					uint _remoteConn = LuaAPI.xlua_touint(L, 3);
					System.Net.Sockets.Socket _socket = (System.Net.Sockets.Socket)translator.GetObject(L, 4, typeof(System.Net.Sockets.Socket));
					System.Net.IPEndPoint _remoteEndPoint = (System.Net.IPEndPoint)translator.GetObject(L, 5, typeof(System.Net.IPEndPoint));
					DCET.Model.KService _kService = (DCET.Model.KService)translator.GetObject(L, 6, typeof(DCET.Model.KService));
					
					DCET.Model.KChannel gen_ret = new DCET.Model.KChannel(_localConn, _remoteConn, _socket, _remoteEndPoint, _kService);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 5 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && translator.Assignable<System.Net.Sockets.Socket>(L, 3) && translator.Assignable<System.Net.IPEndPoint>(L, 4) && translator.Assignable<DCET.Model.KService>(L, 5))
				{
					uint _localConn = LuaAPI.xlua_touint(L, 2);
					System.Net.Sockets.Socket _socket = (System.Net.Sockets.Socket)translator.GetObject(L, 3, typeof(System.Net.Sockets.Socket));
					System.Net.IPEndPoint _remoteEndPoint = (System.Net.IPEndPoint)translator.GetObject(L, 4, typeof(System.Net.IPEndPoint));
					DCET.Model.KService _kService = (DCET.Model.KService)translator.GetObject(L, 5, typeof(DCET.Model.KService));
					
					DCET.Model.KChannel gen_ret = new DCET.Model.KChannel(_localConn, _socket, _remoteEndPoint, _kService);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to DCET.Model.KChannel constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.KChannel gen_to_be_invoked = (DCET.Model.KChannel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Disconnect(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.KChannel gen_to_be_invoked = (DCET.Model.KChannel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _error = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.Disconnect( _error );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HandleConnnect(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.KChannel gen_to_be_invoked = (DCET.Model.KChannel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    uint _remoteConn = LuaAPI.xlua_touint(L, 2);
                    
                    gen_to_be_invoked.HandleConnnect( _remoteConn );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Accept(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.KChannel gen_to_be_invoked = (DCET.Model.KChannel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Accept(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Update(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.KChannel gen_to_be_invoked = (DCET.Model.KChannel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Update(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HandleRecv(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.KChannel gen_to_be_invoked = (DCET.Model.KChannel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    byte[] _date = LuaAPI.lua_tobytes(L, 2);
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _length = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.HandleRecv( _date, _offset, _length );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Output(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.KChannel gen_to_be_invoked = (DCET.Model.KChannel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _bytes = LuaAPI.lua_touserdata(L, 2);
                    int _count = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.Output( _bytes, _count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetOutput(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.KChannel gen_to_be_invoked = (DCET.Model.KChannel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SetOutput(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_KcpOutput_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _bytes = LuaAPI.lua_touserdata(L, 1);
                    int _len = LuaAPI.xlua_tointeger(L, 2);
                    System.IntPtr _kcp = LuaAPI.lua_touserdata(L, 3);
                    System.IntPtr _user = LuaAPI.lua_touserdata(L, 4);
                    
                        int gen_ret = DCET.Model.KChannel.KcpOutput( _bytes, _len, _kcp, _user );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
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
            
            
                DCET.Model.KChannel gen_to_be_invoked = (DCET.Model.KChannel)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _g_get_RemoteConn(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.KChannel gen_to_be_invoked = (DCET.Model.KChannel)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushuint(L, gen_to_be_invoked.RemoteConn);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LocalConn(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.KChannel gen_to_be_invoked = (DCET.Model.KChannel)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushuint(L, gen_to_be_invoked.LocalConn);
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
			
                DCET.Model.KChannel gen_to_be_invoked = (DCET.Model.KChannel)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Stream);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LocalConn(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.KChannel gen_to_be_invoked = (DCET.Model.KChannel)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.LocalConn = LuaAPI.xlua_touint(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
