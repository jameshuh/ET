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
    public class XLuaDelegateBridgeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(XLua.DelegateBridge);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PCall", _m_PCall);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "__Gen_Delegate_Imp0", _m___Gen_Delegate_Imp0);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "__Gen_Delegate_Imp1", _m___Gen_Delegate_Imp1);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "__Gen_Delegate_Imp2", _m___Gen_Delegate_Imp2);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "__Gen_Delegate_Imp3", _m___Gen_Delegate_Imp3);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDelegateByType", _m_GetDelegateByType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Action", _m_Action);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 1);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Gen_Flag", _g_get_Gen_Flag);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Gen_Flag", _s_set_Gen_Flag);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 3 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && translator.Assignable<XLua.LuaEnv>(L, 3))
				{
					int _reference = LuaAPI.xlua_tointeger(L, 2);
					XLua.LuaEnv _luaenv = (XLua.LuaEnv)translator.GetObject(L, 3, typeof(XLua.LuaEnv));
					
					XLua.DelegateBridge gen_ret = new XLua.DelegateBridge(_reference, _luaenv);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to XLua.DelegateBridge constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PCall(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.DelegateBridge gen_to_be_invoked = (XLua.DelegateBridge)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _nArgs = LuaAPI.xlua_tointeger(L, 3);
                    int _nResults = LuaAPI.xlua_tointeger(L, 4);
                    int _errFunc = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.PCall( _L, _nArgs, _nResults, _errFunc );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m___Gen_Delegate_Imp0(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.DelegateBridge gen_to_be_invoked = (XLua.DelegateBridge)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.__Gen_Delegate_Imp0(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m___Gen_Delegate_Imp1(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.DelegateBridge gen_to_be_invoked = (XLua.DelegateBridge)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    double _p0 = LuaAPI.lua_tonumber(L, 2);
                    double _p1 = LuaAPI.lua_tonumber(L, 3);
                    
                        double gen_ret = gen_to_be_invoked.__Gen_Delegate_Imp1( _p0, _p1 );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m___Gen_Delegate_Imp2(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.DelegateBridge gen_to_be_invoked = (XLua.DelegateBridge)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _p0 = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.__Gen_Delegate_Imp2( _p0 );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m___Gen_Delegate_Imp3(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.DelegateBridge gen_to_be_invoked = (XLua.DelegateBridge)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    double _p0 = LuaAPI.lua_tonumber(L, 2);
                    
                    gen_to_be_invoked.__Gen_Delegate_Imp3( _p0 );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDelegateByType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.DelegateBridge gen_to_be_invoked = (XLua.DelegateBridge)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        System.Delegate gen_ret = gen_to_be_invoked.GetDelegateByType( _type );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Action(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.DelegateBridge gen_to_be_invoked = (XLua.DelegateBridge)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Action(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Gen_Flag(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, XLua.DelegateBridge.Gen_Flag);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Gen_Flag(RealStatePtr L)
        {
		    try {
                
			    XLua.DelegateBridge.Gen_Flag = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
