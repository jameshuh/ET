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
    public class XLuaTemplateEngineLuaTemplateWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(XLua.TemplateEngine.LuaTemplate);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 5, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "ComposeCode", _m_ComposeCode_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Compile", _m_Compile_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Execute", _m_Execute_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OpenLib", _m_OpenLib_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					XLua.TemplateEngine.LuaTemplate gen_ret = new XLua.TemplateEngine.LuaTemplate();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to XLua.TemplateEngine.LuaTemplate constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComposeCode_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Collections.Generic.List<XLua.TemplateEngine.Chunk> _chunks = (System.Collections.Generic.List<XLua.TemplateEngine.Chunk>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<XLua.TemplateEngine.Chunk>));
                    
                        string gen_ret = XLua.TemplateEngine.LuaTemplate.ComposeCode( _chunks );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Compile_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                        int gen_ret = XLua.TemplateEngine.LuaTemplate.Compile( _L );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<XLua.LuaEnv>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    XLua.LuaEnv _luaenv = (XLua.LuaEnv)translator.GetObject(L, 1, typeof(XLua.LuaEnv));
                    string _snippet = LuaAPI.lua_tostring(L, 2);
                    
                        XLua.LuaFunction gen_ret = XLua.TemplateEngine.LuaTemplate.Compile( _luaenv, _snippet );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to XLua.TemplateEngine.LuaTemplate.Compile!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Execute_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                        int gen_ret = XLua.TemplateEngine.LuaTemplate.Execute( _L );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TFUNCTION)) 
                {
                    XLua.LuaFunction _compiledTemplate = (XLua.LuaFunction)translator.GetObject(L, 1, typeof(XLua.LuaFunction));
                    
                        string gen_ret = XLua.TemplateEngine.LuaTemplate.Execute( _compiledTemplate );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TFUNCTION)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TTABLE)) 
                {
                    XLua.LuaFunction _compiledTemplate = (XLua.LuaFunction)translator.GetObject(L, 1, typeof(XLua.LuaFunction));
                    XLua.LuaTable _parameters = (XLua.LuaTable)translator.GetObject(L, 2, typeof(XLua.LuaTable));
                    
                        string gen_ret = XLua.TemplateEngine.LuaTemplate.Execute( _compiledTemplate, _parameters );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to XLua.TemplateEngine.LuaTemplate.Execute!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OpenLib_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                    XLua.TemplateEngine.LuaTemplate.OpenLib( _L );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
