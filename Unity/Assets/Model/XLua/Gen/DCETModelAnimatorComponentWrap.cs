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
    public class DCETModelAnimatorComponentWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DCET.Model.AnimatorComponent);
			Utils.BeginObjectRegister(type, L, translator, 0, 15, 7, 7);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Awake", _m_Awake);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Update", _m_Update);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasParameter", _m_HasParameter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PlayInTime", _m_PlayInTime);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Play", _m_Play);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AnimationTime", _m_AnimationTime);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PauseAnimator", _m_PauseAnimator);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RunAnimator", _m_RunAnimator);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetBoolValue", _m_SetBoolValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetFloatValue", _m_SetFloatValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetIntValue", _m_SetIntValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetTrigger", _m_SetTrigger);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetAnimatorSpeed", _m_SetAnimatorSpeed);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetAnimatorSpeed", _m_ResetAnimatorSpeed);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "animationClips", _g_get_animationClips);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Parameter", _g_get_Parameter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MotionType", _g_get_MotionType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MontionSpeed", _g_get_MontionSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isStop", _g_get_isStop);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stopSpeed", _g_get_stopSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Animator", _g_get_Animator);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "animationClips", _s_set_animationClips);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Parameter", _s_set_Parameter);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "MotionType", _s_set_MotionType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "MontionSpeed", _s_set_MontionSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isStop", _s_set_isStop);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "stopSpeed", _s_set_stopSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Animator", _s_set_Animator);
            
			
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
					
					DCET.Model.AnimatorComponent gen_ret = new DCET.Model.AnimatorComponent();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to DCET.Model.AnimatorComponent constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Awake(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Awake(  );
                    
                    
                    
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
            
            
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Update(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasParameter(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _parameter = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.HasParameter( _parameter );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PlayInTime(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    DCET.Model.MotionType _motionType;translator.Get(L, 2, out _motionType);
                    float _time = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    gen_to_be_invoked.PlayInTime( _motionType, _time );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Play(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<DCET.Model.MotionType>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    DCET.Model.MotionType _motionType;translator.Get(L, 2, out _motionType);
                    float _motionSpeed = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    gen_to_be_invoked.Play( _motionType, _motionSpeed );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<DCET.Model.MotionType>(L, 2)) 
                {
                    DCET.Model.MotionType _motionType;translator.Get(L, 2, out _motionType);
                    
                    gen_to_be_invoked.Play( _motionType );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to DCET.Model.AnimatorComponent.Play!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AnimationTime(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    DCET.Model.MotionType _motionType;translator.Get(L, 2, out _motionType);
                    
                        float gen_ret = gen_to_be_invoked.AnimationTime( _motionType );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PauseAnimator(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.PauseAnimator(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RunAnimator(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.RunAnimator(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetBoolValue(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    bool _state = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.SetBoolValue( _name, _state );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetFloatValue(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    float _state = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    gen_to_be_invoked.SetFloatValue( _name, _state );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIntValue(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    int _value = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetIntValue( _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTrigger(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.SetTrigger( _name );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAnimatorSpeed(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _speed = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    gen_to_be_invoked.SetAnimatorSpeed( _speed );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetAnimatorSpeed(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ResetAnimatorSpeed(  );
                    
                    
                    
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
            
            
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_animationClips(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.animationClips);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Parameter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Parameter);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MotionType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
                translator.PushDCETModelMotionType(L, gen_to_be_invoked.MotionType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MontionSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.MontionSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isStop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isStop);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_stopSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.stopSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Animator(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Animator);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_animationClips(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.animationClips = (System.Collections.Generic.Dictionary<string, UnityEngine.AnimationClip>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<string, UnityEngine.AnimationClip>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Parameter(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Parameter = (System.Collections.Generic.HashSet<string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.HashSet<string>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MotionType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
                DCET.Model.MotionType gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.MotionType = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MontionSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.MontionSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isStop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isStop = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_stopSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.stopSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Animator(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                DCET.Model.AnimatorComponent gen_to_be_invoked = (DCET.Model.AnimatorComponent)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
