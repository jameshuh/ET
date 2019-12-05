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
    public class XLuaMethodWrapsCacheWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(XLua.MethodWrapsCache);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetConstructorWrap", _m_GetConstructorWrap);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMethodWrap", _m_GetMethodWrap);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMethodWrapInCache", _m_GetMethodWrapInCache);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDelegateWrap", _m_GetDelegateWrap);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEventWrap", _m_GetEventWrap);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "_GenMethodWrap", _m__GenMethodWrap);
			
			
			
			
			
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
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<XLua.ObjectTranslator>(L, 2) && translator.Assignable<XLua.ObjectCheckers>(L, 3) && translator.Assignable<XLua.ObjectCasters>(L, 4))
				{
					XLua.ObjectTranslator _translator = (XLua.ObjectTranslator)translator.GetObject(L, 2, typeof(XLua.ObjectTranslator));
					XLua.ObjectCheckers _objCheckers = (XLua.ObjectCheckers)translator.GetObject(L, 3, typeof(XLua.ObjectCheckers));
					XLua.ObjectCasters _objCasters = (XLua.ObjectCasters)translator.GetObject(L, 4, typeof(XLua.ObjectCasters));
					
					XLua.MethodWrapsCache gen_ret = new XLua.MethodWrapsCache(_translator, _objCheckers, _objCasters);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to XLua.MethodWrapsCache constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetConstructorWrap(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.MethodWrapsCache gen_to_be_invoked = (XLua.MethodWrapsCache)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        XLua.LuaDLL.lua_CSFunction gen_ret = gen_to_be_invoked.GetConstructorWrap( _type );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMethodWrap(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.MethodWrapsCache gen_to_be_invoked = (XLua.MethodWrapsCache)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string _methodName = LuaAPI.lua_tostring(L, 3);
                    
                        XLua.LuaDLL.lua_CSFunction gen_ret = gen_to_be_invoked.GetMethodWrap( _type, _methodName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMethodWrapInCache(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.MethodWrapsCache gen_to_be_invoked = (XLua.MethodWrapsCache)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string _methodName = LuaAPI.lua_tostring(L, 3);
                    
                        XLua.LuaDLL.lua_CSFunction gen_ret = gen_to_be_invoked.GetMethodWrapInCache( _type, _methodName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDelegateWrap(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.MethodWrapsCache gen_to_be_invoked = (XLua.MethodWrapsCache)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        XLua.LuaDLL.lua_CSFunction gen_ret = gen_to_be_invoked.GetDelegateWrap( _type );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEventWrap(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.MethodWrapsCache gen_to_be_invoked = (XLua.MethodWrapsCache)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string _eventName = LuaAPI.lua_tostring(L, 3);
                    
                        XLua.LuaDLL.lua_CSFunction gen_ret = gen_to_be_invoked.GetEventWrap( _type, _eventName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m__GenMethodWrap(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.MethodWrapsCache gen_to_be_invoked = (XLua.MethodWrapsCache)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>>(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string _methodName = LuaAPI.lua_tostring(L, 3);
                    System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> _methodBases = (System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>)translator.GetObject(L, 4, typeof(System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>));
                    bool _forceCheck = LuaAPI.lua_toboolean(L, 5);
                    
                        XLua.MethodWrap gen_ret = gen_to_be_invoked._GenMethodWrap( _type, _methodName, _methodBases, _forceCheck );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<System.Type>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>>(L, 4)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    string _methodName = LuaAPI.lua_tostring(L, 3);
                    System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> _methodBases = (System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>)translator.GetObject(L, 4, typeof(System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>));
                    
                        XLua.MethodWrap gen_ret = gen_to_be_invoked._GenMethodWrap( _type, _methodName, _methodBases );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to XLua.MethodWrapsCache._GenMethodWrap!");
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
