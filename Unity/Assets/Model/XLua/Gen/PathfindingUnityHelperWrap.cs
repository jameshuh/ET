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
    public class PathfindingUnityHelperWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Pathfinding.UnityHelper);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 8, 6, 6);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Close", _m_Close_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGraph", _m_GetGraph_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateNavmeshOutlineVisualization", _m_CreateNavmeshOutlineVisualization_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReversesFaceOrientations", _m_ReversesFaceOrientations_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReversesFaceOrientationsXZ", _m_ReversesFaceOrientationsXZ_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IntToColor", _m_IntToColor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HSVToRGB", _m_HSVToRGB_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "OnGraphPreScan", _g_get_OnGraphPreScan);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "OnGraphPostScan", _g_get_OnGraphPostScan);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "OnPreScan", _g_get_OnPreScan);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "OnPostScan", _g_get_OnPostScan);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "OnLatePostScan", _g_get_OnLatePostScan);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "OnGraphsUpdated", _g_get_OnGraphsUpdated);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "OnGraphPreScan", _s_set_OnGraphPreScan);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "OnGraphPostScan", _s_set_OnGraphPostScan);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "OnPreScan", _s_set_OnPreScan);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "OnPostScan", _s_set_OnPostScan);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "OnLatePostScan", _s_set_OnLatePostScan);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "OnGraphsUpdated", _s_set_OnGraphsUpdated);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "Pathfinding.UnityHelper does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Close_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    Pathfinding.UnityHelper.Close(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGraph_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    PF.GraphNode _node = (PF.GraphNode)translator.GetObject(L, 1, typeof(PF.GraphNode));
                    
                        PF.NavGraph gen_ret = Pathfinding.UnityHelper.GetGraph( _node );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateNavmeshOutlineVisualization_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    PF.NavmeshTile _tile = (PF.NavmeshTile)translator.GetObject(L, 1, typeof(PF.NavmeshTile));
                    Pathfinding.Util.GraphGizmoHelper _helper = (Pathfinding.Util.GraphGizmoHelper)translator.GetObject(L, 2, typeof(Pathfinding.Util.GraphGizmoHelper));
                    
                    Pathfinding.UnityHelper.CreateNavmeshOutlineVisualization( _tile, _helper );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReversesFaceOrientations_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Matrix4x4 _matrix;translator.Get(L, 1, out _matrix);
                    
                        bool gen_ret = Pathfinding.UnityHelper.ReversesFaceOrientations( _matrix );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReversesFaceOrientationsXZ_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Matrix4x4 _matrix;translator.Get(L, 1, out _matrix);
                    
                        bool gen_ret = Pathfinding.UnityHelper.ReversesFaceOrientationsXZ( _matrix );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IntToColor_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    int _i = LuaAPI.xlua_tointeger(L, 1);
                    float _a = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        UnityEngine.Color gen_ret = Pathfinding.UnityHelper.IntToColor( _i, _a );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HSVToRGB_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    float _h = (float)LuaAPI.lua_tonumber(L, 1);
                    float _s = (float)LuaAPI.lua_tonumber(L, 2);
                    float _v = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.Color gen_ret = Pathfinding.UnityHelper.HSVToRGB( _h, _s, _v );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnGraphPreScan(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, Pathfinding.UnityHelper.OnGraphPreScan);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnGraphPostScan(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, Pathfinding.UnityHelper.OnGraphPostScan);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnPreScan(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, Pathfinding.UnityHelper.OnPreScan);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnPostScan(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, Pathfinding.UnityHelper.OnPostScan);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnLatePostScan(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, Pathfinding.UnityHelper.OnLatePostScan);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnGraphsUpdated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, Pathfinding.UnityHelper.OnGraphsUpdated);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnGraphPreScan(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    Pathfinding.UnityHelper.OnGraphPreScan = translator.GetDelegate<Pathfinding.OnGraphDelegate>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnGraphPostScan(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    Pathfinding.UnityHelper.OnGraphPostScan = translator.GetDelegate<Pathfinding.OnGraphDelegate>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnPreScan(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    Pathfinding.UnityHelper.OnPreScan = translator.GetDelegate<Pathfinding.OnScanDelegate>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnPostScan(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    Pathfinding.UnityHelper.OnPostScan = translator.GetDelegate<Pathfinding.OnScanDelegate>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnLatePostScan(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    Pathfinding.UnityHelper.OnLatePostScan = translator.GetDelegate<Pathfinding.OnScanDelegate>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnGraphsUpdated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    Pathfinding.UnityHelper.OnGraphsUpdated = translator.GetDelegate<Pathfinding.OnScanDelegate>(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
