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
    public class PathfindingEditorResourceHelperWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Pathfinding.EditorResourceHelper);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
            			
						
            
			
						
			
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 10, 3, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "LocateEditorAssets", _m_LocateEditorAssets_xlua_st_);
            
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "getGizmoSurfaceMaterial", _g_get_GizmoSurfaceMaterial);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "getGizmoLineMaterial", _g_get_GizmoLineMaterial);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "geteditorAssets", _g_get_editorAssets);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "seteditorAssets", _s_set_editorAssets);
            
			
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "GizmoSurfaceMaterial", _g_get_GizmoSurfaceMaterial);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "GizmoLineMaterial", _g_get_GizmoLineMaterial);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "editorAssets", _g_get_editorAssets);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "editorAssets", _s_set_editorAssets);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "Pathfinding.EditorResourceHelper does not have a constructor!");
        }
        
		
        
		
        
        

		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LocateEditorAssets_xlua_st_(RealStatePtr L)
        {
		    try {
			
            
            
                
                {
                    
                        bool gen_ret = Pathfinding.EditorResourceHelper.LocateEditorAssets(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GizmoSurfaceMaterial(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, Pathfinding.EditorResourceHelper.GizmoSurfaceMaterial);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GizmoLineMaterial(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, Pathfinding.EditorResourceHelper.GizmoLineMaterial);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_editorAssets(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, Pathfinding.EditorResourceHelper.editorAssets);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_editorAssets(RealStatePtr L)
        {
		    try {
                
			    Pathfinding.EditorResourceHelper.editorAssets = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		

		
		
		
		
		
		
		
    }
}
