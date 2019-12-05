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
    public class DCETModelTimerComponentWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DCET.Model.TimerComponent);
			Utils.BeginObjectRegister(type, L, translator, 0, 9, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Update", _m_Update);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WaitTillAsync", _m_WaitTillAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WaitAsync", _m_WaitAsync);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "NewRepeatedTimer", _m_NewRepeatedTimer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetRepeatedTimer", _m_GetRepeatedTimer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Remove", _m_Remove);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "NewOnceTimer", _m_NewOnceTimer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetOnceTimer", _m_GetOnceTimer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddToTimeId", _m_AddToTimeId);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "TimeId", _g_get_TimeId);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 1);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Instance", _g_get_Instance);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Instance", _s_set_Instance);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					DCET.Model.TimerComponent gen_ret = new DCET.Model.TimerComponent();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to DCET.Model.TimerComponent constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Update(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.TimerComponent gen_to_be_invoked = (DCET.Model.TimerComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Update(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WaitTillAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.TimerComponent gen_to_be_invoked = (DCET.Model.TimerComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || LuaAPI.lua_isint64(L, 2))) 
                {
                    long _tillTime = LuaAPI.lua_toint64(L, 2);
                    
                        DCET.Model.ETTask gen_ret = gen_to_be_invoked.WaitTillAsync( _tillTime );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || LuaAPI.lua_isint64(L, 2))&& translator.Assignable<DCET.Model.ETCancellationToken>(L, 3)) 
                {
                    long _tillTime = LuaAPI.lua_toint64(L, 2);
                    DCET.Model.ETCancellationToken _cancellationToken = (DCET.Model.ETCancellationToken)translator.GetObject(L, 3, typeof(DCET.Model.ETCancellationToken));
                    
                        DCET.Model.ETTask gen_ret = gen_to_be_invoked.WaitTillAsync( _tillTime, _cancellationToken );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to DCET.Model.TimerComponent.WaitTillAsync!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WaitAsync(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.TimerComponent gen_to_be_invoked = (DCET.Model.TimerComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || LuaAPI.lua_isint64(L, 2))) 
                {
                    long _time = LuaAPI.lua_toint64(L, 2);
                    
                        DCET.Model.ETTask gen_ret = gen_to_be_invoked.WaitAsync( _time );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || LuaAPI.lua_isint64(L, 2))&& translator.Assignable<DCET.Model.ETCancellationToken>(L, 3)) 
                {
                    long _time = LuaAPI.lua_toint64(L, 2);
                    DCET.Model.ETCancellationToken _cancellationToken = (DCET.Model.ETCancellationToken)translator.GetObject(L, 3, typeof(DCET.Model.ETCancellationToken));
                    
                        DCET.Model.ETTask gen_ret = gen_to_be_invoked.WaitAsync( _time, _cancellationToken );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to DCET.Model.TimerComponent.WaitAsync!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NewRepeatedTimer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.TimerComponent gen_to_be_invoked = (DCET.Model.TimerComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    long _time = LuaAPI.lua_toint64(L, 2);
                    System.Action _action = translator.GetDelegate<System.Action>(L, 3);
                    
                        long gen_ret = gen_to_be_invoked.NewRepeatedTimer( _time, _action );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRepeatedTimer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.TimerComponent gen_to_be_invoked = (DCET.Model.TimerComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    long _id = LuaAPI.lua_toint64(L, 2);
                    
                        DCET.Model.RepeatedTimer gen_ret = gen_to_be_invoked.GetRepeatedTimer( _id );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Remove(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.TimerComponent gen_to_be_invoked = (DCET.Model.TimerComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    long _id = LuaAPI.lua_toint64(L, 2);
                    
                    gen_to_be_invoked.Remove( _id );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NewOnceTimer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.TimerComponent gen_to_be_invoked = (DCET.Model.TimerComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    long _tillTime = LuaAPI.lua_toint64(L, 2);
                    System.Action _action = translator.GetDelegate<System.Action>(L, 3);
                    
                        long gen_ret = gen_to_be_invoked.NewOnceTimer( _tillTime, _action );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetOnceTimer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.TimerComponent gen_to_be_invoked = (DCET.Model.TimerComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    long _id = LuaAPI.lua_toint64(L, 2);
                    
                        DCET.Model.OnceTimer gen_ret = gen_to_be_invoked.GetOnceTimer( _id );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddToTimeId(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.TimerComponent gen_to_be_invoked = (DCET.Model.TimerComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    long _tillTime = LuaAPI.lua_toint64(L, 2);
                    long _id = LuaAPI.lua_toint64(L, 3);
                    
                    gen_to_be_invoked.AddToTimeId( _tillTime, _id );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, DCET.Model.TimerComponent.Instance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_TimeId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.TimerComponent gen_to_be_invoked = (DCET.Model.TimerComponent)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.TimeId);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    DCET.Model.TimerComponent.Instance = (DCET.Model.TimerComponent)translator.GetObject(L, 1, typeof(DCET.Model.TimerComponent));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
