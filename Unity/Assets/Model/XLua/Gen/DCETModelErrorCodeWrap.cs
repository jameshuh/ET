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
    public class DCETModelErrorCodeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DCET.Model.ErrorCode);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 30, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "IsRpcNeedThrowException", _m_IsRpcNeedThrowException_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_Success", DCET.Model.ErrorCode.ERR_Success);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_MyErrorCode", DCET.Model.ErrorCode.ERR_MyErrorCode);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_NotFoundActor", DCET.Model.ErrorCode.ERR_NotFoundActor);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_ActorNoMailBoxComponent", DCET.Model.ErrorCode.ERR_ActorNoMailBoxComponent);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_ActorRemove", DCET.Model.ErrorCode.ERR_ActorRemove);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_PacketParserError", DCET.Model.ErrorCode.ERR_PacketParserError);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_ConnectGateKeyError", DCET.Model.ErrorCode.ERR_ConnectGateKeyError);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_RpcFail", DCET.Model.ErrorCode.ERR_RpcFail);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_ReloadFail", DCET.Model.ErrorCode.ERR_ReloadFail);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_ActorLocationNotFound", DCET.Model.ErrorCode.ERR_ActorLocationNotFound);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_KcpCantConnect", DCET.Model.ErrorCode.ERR_KcpCantConnect);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_KcpChannelTimeout", DCET.Model.ErrorCode.ERR_KcpChannelTimeout);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_KcpRemoteDisconnect", DCET.Model.ErrorCode.ERR_KcpRemoteDisconnect);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_PeerDisconnect", DCET.Model.ErrorCode.ERR_PeerDisconnect);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_SocketCantSend", DCET.Model.ErrorCode.ERR_SocketCantSend);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_SocketError", DCET.Model.ErrorCode.ERR_SocketError);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_KcpWaitSendSizeTooLarge", DCET.Model.ErrorCode.ERR_KcpWaitSendSizeTooLarge);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_ActorNotOnline", DCET.Model.ErrorCode.ERR_ActorNotOnline);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_ActorTimeout", DCET.Model.ErrorCode.ERR_ActorTimeout);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_SessionSendOrRecvTimeout", DCET.Model.ErrorCode.ERR_SessionSendOrRecvTimeout);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_WebsocketPeerReset", DCET.Model.ErrorCode.ERR_WebsocketPeerReset);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_WebsocketMessageTooBig", DCET.Model.ErrorCode.ERR_WebsocketMessageTooBig);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_WebsocketError", DCET.Model.ErrorCode.ERR_WebsocketError);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_WebsocketConnectError", DCET.Model.ErrorCode.ERR_WebsocketConnectError);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_WebsocketSendError", DCET.Model.ErrorCode.ERR_WebsocketSendError);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_WebsocketRecvError", DCET.Model.ErrorCode.ERR_WebsocketRecvError);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_Exception", DCET.Model.ErrorCode.ERR_Exception);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERR_AccountOrPasswordError", DCET.Model.ErrorCode.ERR_AccountOrPasswordError);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "DCET.Model.ErrorCode does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsRpcNeedThrowException_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _error = LuaAPI.xlua_tointeger(L, 1);
                    
                        bool gen_ret = DCET.Model.ErrorCode.IsRpcNeedThrowException( _error );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
