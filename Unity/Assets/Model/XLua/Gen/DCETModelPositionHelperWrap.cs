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
    public class DCETModelPositionHelperWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DCET.Model.PositionHelper);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 12, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "RayCastV2ToV3", _m_RayCastV2ToV3_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RayCastXYToV3", _m_RayCastXYToV3_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RayCastV3ToV3", _m_RayCastV3ToV3_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AngleToQuaternion", _m_AngleToQuaternion_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetVector3ToQuaternion", _m_GetVector3ToQuaternion_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Distance2D", _m_Distance2D_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAngleToQuaternion", _m_GetAngleToQuaternion_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Vector3ToAngle360", _m_Vector3ToAngle360_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DistanceOfPointToVector", _m_DistanceOfPointToVector_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RayCastSphere", _m_RayCastSphere_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GGTheorem", _m_GGTheorem_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "DCET.Model.PositionHelper does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RayCastV2ToV3_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector2 _pos;translator.Get(L, 1, out _pos);
                    
                        UnityEngine.Vector3 gen_ret = DCET.Model.PositionHelper.RayCastV2ToV3( _pos );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RayCastXYToV3_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    float _x = (float)LuaAPI.lua_tonumber(L, 1);
                    float _y = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        UnityEngine.Vector3 gen_ret = DCET.Model.PositionHelper.RayCastXYToV3( _x, _y );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RayCastV3ToV3_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3 _pos;translator.Get(L, 1, out _pos);
                    
                        UnityEngine.Vector3 gen_ret = DCET.Model.PositionHelper.RayCastV3ToV3( _pos );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AngleToQuaternion_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    int _angle = LuaAPI.xlua_tointeger(L, 1);
                    
                        UnityEngine.Quaternion gen_ret = DCET.Model.PositionHelper.AngleToQuaternion( _angle );
                        translator.PushUnityEngineQuaternion(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetVector3ToQuaternion_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3 _source;translator.Get(L, 1, out _source);
                    UnityEngine.Vector3 _dire;translator.Get(L, 2, out _dire);
                    
                        UnityEngine.Quaternion gen_ret = DCET.Model.PositionHelper.GetVector3ToQuaternion( _source, _dire );
                        translator.PushUnityEngineQuaternion(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Distance2D_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3 _v1;translator.Get(L, 1, out _v1);
                    UnityEngine.Vector3 _v2;translator.Get(L, 2, out _v2);
                    
                        float gen_ret = DCET.Model.PositionHelper.Distance2D( _v1, _v2 );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAngleToQuaternion_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    float _angle = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        UnityEngine.Quaternion gen_ret = DCET.Model.PositionHelper.GetAngleToQuaternion( _angle );
                        translator.PushUnityEngineQuaternion(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Vector3ToAngle360_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3 _from;translator.Get(L, 1, out _from);
                    UnityEngine.Vector3 _to;translator.Get(L, 2, out _to);
                    
                        float gen_ret = DCET.Model.PositionHelper.Vector3ToAngle360( _from, _to );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DistanceOfPointToVector_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3 _startPoint;translator.Get(L, 1, out _startPoint);
                    UnityEngine.Vector3 _endPoint;translator.Get(L, 2, out _endPoint);
                    UnityEngine.Vector3 _point;translator.Get(L, 3, out _point);
                    
                        float gen_ret = DCET.Model.PositionHelper.DistanceOfPointToVector( _startPoint, _endPoint, _point );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RayCastSphere_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Ray _ray;translator.Get(L, 1, out _ray);
                    UnityEngine.Vector3 _center;translator.Get(L, 2, out _center);
                    float _redius = (float)LuaAPI.lua_tonumber(L, 3);
                    float _dist;
                    
                        bool gen_ret = DCET.Model.PositionHelper.RayCastSphere( _ray, _center, _redius, out _dist );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.lua_pushnumber(L, _dist);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GGTheorem_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    float _x = (float)LuaAPI.lua_tonumber(L, 1);
                    float _y = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        float gen_ret = DCET.Model.PositionHelper.GGTheorem( _x, _y );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
