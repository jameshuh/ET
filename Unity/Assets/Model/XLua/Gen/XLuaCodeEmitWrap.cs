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
    public class XLuaCodeEmitWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(XLua.CodeEmit);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EmitDelegateImpl", _m_EmitDelegateImpl);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetGenInterfaces", _m_SetGenInterfaces);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EmitInterfaceImpl", _m_EmitInterfaceImpl);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "emitFieldWrap", _m_emitFieldWrap);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "emitPropertyWrap", _m_emitPropertyWrap);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EmitTypeWrap", _m_EmitTypeWrap);
			
			
			
			
			
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
					
					XLua.CodeEmit gen_ret = new XLua.CodeEmit();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to XLua.CodeEmit constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EmitDelegateImpl(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.CodeEmit gen_to_be_invoked = (XLua.CodeEmit)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.IEnumerable<System.Linq.IGrouping<System.Reflection.MethodInfo, System.Type>> _groups = (System.Collections.Generic.IEnumerable<System.Linq.IGrouping<System.Reflection.MethodInfo, System.Type>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<System.Linq.IGrouping<System.Reflection.MethodInfo, System.Type>>));
                    
                        System.Type gen_ret = gen_to_be_invoked.EmitDelegateImpl( _groups );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGenInterfaces(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.CodeEmit gen_to_be_invoked = (XLua.CodeEmit)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<System.Type> _gen_interfaces = (System.Collections.Generic.List<System.Type>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<System.Type>));
                    
                    gen_to_be_invoked.SetGenInterfaces( _gen_interfaces );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EmitInterfaceImpl(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.CodeEmit gen_to_be_invoked = (XLua.CodeEmit)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _to_be_impl = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        System.Type gen_ret = gen_to_be_invoked.EmitInterfaceImpl( _to_be_impl );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_emitFieldWrap(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.CodeEmit gen_to_be_invoked = (XLua.CodeEmit)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Reflection.Emit.TypeBuilder _typeBuilder = (System.Reflection.Emit.TypeBuilder)translator.GetObject(L, 2, typeof(System.Reflection.Emit.TypeBuilder));
                    System.Reflection.FieldInfo _field = (System.Reflection.FieldInfo)translator.GetObject(L, 3, typeof(System.Reflection.FieldInfo));
                    bool _genGetter = LuaAPI.lua_toboolean(L, 4);
                    
                        System.Reflection.Emit.MethodBuilder gen_ret = gen_to_be_invoked.emitFieldWrap( _typeBuilder, _field, _genGetter );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_emitPropertyWrap(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.CodeEmit gen_to_be_invoked = (XLua.CodeEmit)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Reflection.Emit.TypeBuilder _typeBuilder = (System.Reflection.Emit.TypeBuilder)translator.GetObject(L, 2, typeof(System.Reflection.Emit.TypeBuilder));
                    System.Reflection.PropertyInfo _prop = (System.Reflection.PropertyInfo)translator.GetObject(L, 3, typeof(System.Reflection.PropertyInfo));
                    System.Reflection.MethodInfo _op = (System.Reflection.MethodInfo)translator.GetObject(L, 4, typeof(System.Reflection.MethodInfo));
                    bool _genGetter = LuaAPI.lua_toboolean(L, 5);
                    
                        System.Reflection.Emit.MethodBuilder gen_ret = gen_to_be_invoked.emitPropertyWrap( _typeBuilder, _prop, _op, _genGetter );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EmitTypeWrap(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XLua.CodeEmit gen_to_be_invoked = (XLua.CodeEmit)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _toBeWrap = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        System.Type gen_ret = gen_to_be_invoked.EmitTypeWrap( _toBeWrap );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
