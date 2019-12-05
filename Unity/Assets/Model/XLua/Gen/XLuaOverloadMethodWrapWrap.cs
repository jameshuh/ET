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
    public class XLuaOverloadMethodWrapWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(XLua.OverloadMethodWrap);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Init", _m_Init);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Check", _m_Check);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Call", _m_Call);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "HasDefalutValue", _g_get_HasDefalutValue);
            
			
			
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
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<XLua.ObjectTranslator>(L, 2) && translator.Assignable<System.Type>(L, 3) && translator.Assignable<System.Reflection.MethodBase>(L, 4))
				{
					XLua.ObjectTranslator _translator = (XLua.ObjectTranslator)translator.GetObject(L, 2, typeof(XLua.ObjectTranslator));
					System.Type _targetType = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
					System.Reflection.MethodBase _method = (System.Reflection.MethodBase)translator.GetObject(L, 4, typeof(System.Reflection.MethodBase));
					
					XLua.OverloadMethodWrap gen_ret = new XLua.OverloadMethodWrap(_translator, _targetType, _method);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to XLua.OverloadMethodWrap constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Init(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.OverloadMethodWrap gen_to_be_invoked = (XLua.OverloadMethodWrap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    XLua.ObjectCheckers _objCheckers = (XLua.ObjectCheckers)translator.GetObject(L, 2, typeof(XLua.ObjectCheckers));
                    XLua.ObjectCasters _objCasters = (XLua.ObjectCasters)translator.GetObject(L, 3, typeof(XLua.ObjectCasters));
                    
                    gen_to_be_invoked.Init( _objCheckers, _objCasters );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Check(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.OverloadMethodWrap gen_to_be_invoked = (XLua.OverloadMethodWrap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.Check( _L );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Call(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.OverloadMethodWrap gen_to_be_invoked = (XLua.OverloadMethodWrap)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    
                        int gen_ret = gen_to_be_invoked.Call( _L );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HasDefalutValue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XLua.OverloadMethodWrap gen_to_be_invoked = (XLua.OverloadMethodWrap)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.HasDefalutValue);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
