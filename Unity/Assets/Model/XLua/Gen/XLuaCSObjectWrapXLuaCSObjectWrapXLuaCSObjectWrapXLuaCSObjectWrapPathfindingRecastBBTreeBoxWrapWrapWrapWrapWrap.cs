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
    public class XLuaCSObjectWrapXLuaCSObjectWrapXLuaCSObjectWrapXLuaCSObjectWrapPathfindingRecastBBTreeBoxWrapWrapWrapWrapWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(XLua.CSObjectWrap.XLuaCSObjectWrapXLuaCSObjectWrapXLuaCSObjectWrapPathfindingRecastBBTreeBoxWrapWrapWrapWrap);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__Register", _m___Register_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					XLua.CSObjectWrap.XLuaCSObjectWrapXLuaCSObjectWrapXLuaCSObjectWrapPathfindingRecastBBTreeBoxWrapWrapWrapWrap gen_ret = new XLua.CSObjectWrap.XLuaCSObjectWrapXLuaCSObjectWrapXLuaCSObjectWrapPathfindingRecastBBTreeBoxWrapWrapWrapWrap();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to XLua.CSObjectWrap.XLuaCSObjectWrapXLuaCSObjectWrapXLuaCSObjectWrapPathfindingRecastBBTreeBoxWrapWrapWrapWrap constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m___Register_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                    XLua.CSObjectWrap.XLuaCSObjectWrapXLuaCSObjectWrapXLuaCSObjectWrapPathfindingRecastBBTreeBoxWrapWrapWrapWrap.__Register( _L );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
