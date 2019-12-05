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
    public class XLuaLuaDLLLuaWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(XLua.LuaDLL.Lua);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 134, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_tothread", _m_lua_tothread_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_get_lib_version", _m_xlua_get_lib_version_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_gc", _m_lua_gc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_getupvalue", _m_lua_getupvalue_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_setupvalue", _m_lua_setupvalue_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_pushthread", _m_lua_pushthread_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_isfunction", _m_lua_isfunction_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_islightuserdata", _m_lua_islightuserdata_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_istable", _m_lua_istable_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_isthread", _m_lua_isthread_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "luaL_error", _m_luaL_error_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_setfenv", _m_lua_setfenv_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "luaL_newstate", _m_luaL_newstate_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_close", _m_lua_close_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "luaopen_xlua", _m_luaopen_xlua_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "luaL_openlibs", _m_luaL_openlibs_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_objlen", _m_xlua_objlen_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_createtable", _m_lua_createtable_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_newtable", _m_lua_newtable_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_getglobal", _m_xlua_getglobal_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_setglobal", _m_xlua_setglobal_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_getloaders", _m_xlua_getloaders_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_settop", _m_lua_settop_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_pop", _m_lua_pop_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_insert", _m_lua_insert_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_remove", _m_lua_remove_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_rawget", _m_lua_rawget_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_rawset", _m_lua_rawset_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_setmetatable", _m_lua_setmetatable_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_rawequal", _m_lua_rawequal_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_pushvalue", _m_lua_pushvalue_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_pushcclosure", _m_lua_pushcclosure_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_replace", _m_lua_replace_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_gettop", _m_lua_gettop_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_type", _m_lua_type_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_isnil", _m_lua_isnil_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_isnumber", _m_lua_isnumber_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_isboolean", _m_lua_isboolean_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "luaL_ref", _m_luaL_ref_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_rawgeti", _m_xlua_rawgeti_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_rawseti", _m_xlua_rawseti_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_getref", _m_lua_getref_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "pcall_prepare", _m_pcall_prepare_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "luaL_unref", _m_luaL_unref_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_unref", _m_lua_unref_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_isstring", _m_lua_isstring_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_isinteger", _m_lua_isinteger_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_pushnil", _m_lua_pushnil_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_pushstdcallcfunction", _m_lua_pushstdcallcfunction_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_upvalueindex", _m_xlua_upvalueindex_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_pcall", _m_lua_pcall_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_tonumber", _m_lua_tonumber_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_tointeger", _m_xlua_tointeger_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_touint", _m_xlua_touint_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_toboolean", _m_lua_toboolean_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_topointer", _m_lua_topointer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_tolstring", _m_lua_tolstring_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_tostring", _m_lua_tostring_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_atpanic", _m_lua_atpanic_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_pushnumber", _m_lua_pushnumber_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_pushboolean", _m_lua_pushboolean_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_pushinteger", _m_xlua_pushinteger_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_pushuint", _m_xlua_pushuint_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_pushstring", _m_lua_pushstring_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_pushlstring", _m_xlua_pushlstring_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_pushasciistring", _m_xlua_pushasciistring_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_tobytes", _m_lua_tobytes_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "luaL_newmetatable", _m_luaL_newmetatable_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_pgettable", _m_xlua_pgettable_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_psettable", _m_xlua_psettable_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "luaL_getmetatable", _m_luaL_getmetatable_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xluaL_loadbuffer", _m_xluaL_loadbuffer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "luaL_loadbuffer", _m_luaL_loadbuffer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_tocsobj_safe", _m_xlua_tocsobj_safe_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_tocsobj_fast", _m_xlua_tocsobj_fast_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_error", _m_lua_error_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_checkstack", _m_lua_checkstack_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_next", _m_lua_next_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_pushlightuserdata", _m_lua_pushlightuserdata_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_tag", _m_xlua_tag_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "luaL_where", _m_luaL_where_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_tryget_cachedud", _m_xlua_tryget_cachedud_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_pushcsobj", _m_xlua_pushcsobj_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "gen_obj_indexer", _m_gen_obj_indexer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "gen_obj_newindexer", _m_gen_obj_newindexer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "gen_cls_indexer", _m_gen_cls_indexer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "gen_cls_newindexer", _m_gen_cls_newindexer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "get_error_func_ref", _m_get_error_func_ref_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "load_error_func", _m_load_error_func_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "luaopen_i64lib", _m_luaopen_i64lib_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "luaopen_socket_core", _m_luaopen_socket_core_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_pushint64", _m_lua_pushint64_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_pushuint64", _m_lua_pushuint64_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_isint64", _m_lua_isint64_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_isuint64", _m_lua_isuint64_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_toint64", _m_lua_toint64_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_touint64", _m_lua_touint64_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_push_csharp_function", _m_xlua_push_csharp_function_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_csharp_str_error", _m_xlua_csharp_str_error_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_csharp_error", _m_xlua_csharp_error_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_pack_int8_t", _m_xlua_pack_int8_t_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_unpack_int8_t", _m_xlua_unpack_int8_t_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_pack_int16_t", _m_xlua_pack_int16_t_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_unpack_int16_t", _m_xlua_unpack_int16_t_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_pack_int32_t", _m_xlua_pack_int32_t_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_unpack_int32_t", _m_xlua_unpack_int32_t_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_pack_int64_t", _m_xlua_pack_int64_t_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_unpack_int64_t", _m_xlua_unpack_int64_t_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_pack_float", _m_xlua_pack_float_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_unpack_float", _m_xlua_unpack_float_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_pack_double", _m_xlua_pack_double_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_unpack_double", _m_xlua_unpack_double_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_pushstruct", _m_xlua_pushstruct_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_pushcstable", _m_xlua_pushcstable_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "lua_touserdata", _m_lua_touserdata_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_gettypeid", _m_xlua_gettypeid_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_get_registry_index", _m_xlua_get_registry_index_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_pgettable_bypath", _m_xlua_pgettable_bypath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_psettable_bypath", _m_xlua_psettable_bypath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_pack_float2", _m_xlua_pack_float2_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_unpack_float2", _m_xlua_unpack_float2_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_pack_float3", _m_xlua_pack_float3_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_unpack_float3", _m_xlua_unpack_float3_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_pack_float4", _m_xlua_pack_float4_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_unpack_float4", _m_xlua_unpack_float4_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_pack_float5", _m_xlua_pack_float5_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_unpack_float5", _m_xlua_unpack_float5_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_pack_float6", _m_xlua_pack_float6_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_unpack_float6", _m_xlua_unpack_float6_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_pack_decimal", _m_xlua_pack_decimal_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_unpack_decimal", _m_xlua_unpack_decimal_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_is_eq_str", _m_xlua_is_eq_str_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "xlua_gl", _m_xlua_gl_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					XLua.LuaDLL.Lua gen_ret = new XLua.LuaDLL.Lua();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to XLua.LuaDLL.Lua constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_tothread_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        System.IntPtr gen_ret = XLua.LuaDLL.Lua.lua_tothread( _L, _index );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_get_lib_version_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        int gen_ret = XLua.LuaDLL.Lua.xlua_get_lib_version(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_gc_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    XLua.LuaGCOptions _what;translator.Get(L, 2, out _what);
                    int _data = LuaAPI.xlua_tointeger(L, 3);
                    
                        int gen_ret = XLua.LuaDLL.Lua.lua_gc( _L, _what, _data );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_getupvalue_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _funcindex = LuaAPI.xlua_tointeger(L, 2);
                    int _n = LuaAPI.xlua_tointeger(L, 3);
                    
                        System.IntPtr gen_ret = XLua.LuaDLL.Lua.lua_getupvalue( _L, _funcindex, _n );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_setupvalue_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _funcindex = LuaAPI.xlua_tointeger(L, 2);
                    int _n = LuaAPI.xlua_tointeger(L, 3);
                    
                        System.IntPtr gen_ret = XLua.LuaDLL.Lua.lua_setupvalue( _L, _funcindex, _n );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_pushthread_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                        int gen_ret = XLua.LuaDLL.Lua.lua_pushthread( _L );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_isfunction_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _stackPos = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.lua_isfunction( _L, _stackPos );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_islightuserdata_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _stackPos = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.lua_islightuserdata( _L, _stackPos );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_istable_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _stackPos = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.lua_istable( _L, _stackPos );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_isthread_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _stackPos = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.lua_isthread( _L, _stackPos );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_luaL_error_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    string _message = LuaAPI.lua_tostring(L, 2);
                    
                        int gen_ret = XLua.LuaDLL.Lua.luaL_error( _L, _message );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_setfenv_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _stackPos = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = XLua.LuaDLL.Lua.lua_setfenv( _L, _stackPos );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_luaL_newstate_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        System.IntPtr gen_ret = XLua.LuaDLL.Lua.luaL_newstate(  );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_close_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                    XLua.LuaDLL.Lua.lua_close( _L );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_luaopen_xlua_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                    XLua.LuaDLL.Lua.luaopen_xlua( _L );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_luaL_openlibs_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                    XLua.LuaDLL.Lua.luaL_openlibs( _L );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_objlen_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _stackPos = LuaAPI.xlua_tointeger(L, 2);
                    
                        uint gen_ret = XLua.LuaDLL.Lua.xlua_objlen( _L, _stackPos );
                        LuaAPI.xlua_pushuint(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_createtable_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _narr = LuaAPI.xlua_tointeger(L, 2);
                    int _nrec = LuaAPI.xlua_tointeger(L, 3);
                    
                    XLua.LuaDLL.Lua.lua_createtable( _L, _narr, _nrec );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_newtable_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                    XLua.LuaDLL.Lua.lua_newtable( _L );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_getglobal_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        int gen_ret = XLua.LuaDLL.Lua.xlua_getglobal( _L, _name );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_setglobal_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        int gen_ret = XLua.LuaDLL.Lua.xlua_setglobal( _L, _name );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_getloaders_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                    XLua.LuaDLL.Lua.xlua_getloaders( _L );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_settop_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _newTop = LuaAPI.xlua_tointeger(L, 2);
                    
                    XLua.LuaDLL.Lua.lua_settop( _L, _newTop );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_pop_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _amount = LuaAPI.xlua_tointeger(L, 2);
                    
                    XLua.LuaDLL.Lua.lua_pop( _L, _amount );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_insert_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _newTop = LuaAPI.xlua_tointeger(L, 2);
                    
                    XLua.LuaDLL.Lua.lua_insert( _L, _newTop );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_remove_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                    XLua.LuaDLL.Lua.lua_remove( _L, _index );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_rawget_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = XLua.LuaDLL.Lua.lua_rawget( _L, _index );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_rawset_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                    XLua.LuaDLL.Lua.lua_rawset( _L, _index );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_setmetatable_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _objIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = XLua.LuaDLL.Lua.lua_setmetatable( _L, _objIndex );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_rawequal_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index1 = LuaAPI.xlua_tointeger(L, 2);
                    int _index2 = LuaAPI.xlua_tointeger(L, 3);
                    
                        int gen_ret = XLua.LuaDLL.Lua.lua_rawequal( _L, _index1, _index2 );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_pushvalue_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                    XLua.LuaDLL.Lua.lua_pushvalue( _L, _index );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_pushcclosure_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fn = LuaAPI.lua_touserdata(L, 2);
                    int _n = LuaAPI.xlua_tointeger(L, 3);
                    
                    XLua.LuaDLL.Lua.lua_pushcclosure( _L, _fn, _n );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_replace_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                    XLua.LuaDLL.Lua.lua_replace( _L, _index );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_gettop_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                        int gen_ret = XLua.LuaDLL.Lua.lua_gettop( _L );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_type_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        XLua.LuaTypes gen_ret = XLua.LuaDLL.Lua.lua_type( _L, _index );
                        translator.PushXLuaLuaTypes(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_isnil_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.lua_isnil( _L, _index );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_isnumber_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.lua_isnumber( _L, _index );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_isboolean_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.lua_isboolean( _L, _index );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_luaL_ref_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                        int gen_ret = XLua.LuaDLL.Lua.luaL_ref( _L );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _registryIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = XLua.LuaDLL.Lua.luaL_ref( _L, _registryIndex );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to XLua.LuaDLL.Lua.luaL_ref!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_rawgeti_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _tableIndex = LuaAPI.xlua_tointeger(L, 2);
                    long _index = LuaAPI.lua_toint64(L, 3);
                    
                    XLua.LuaDLL.Lua.xlua_rawgeti( _L, _tableIndex, _index );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_rawseti_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _tableIndex = LuaAPI.xlua_tointeger(L, 2);
                    long _index = LuaAPI.lua_toint64(L, 3);
                    
                    XLua.LuaDLL.Lua.xlua_rawseti( _L, _tableIndex, _index );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_getref_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _reference = LuaAPI.xlua_tointeger(L, 2);
                    
                    XLua.LuaDLL.Lua.lua_getref( _L, _reference );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_pcall_prepare_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _error_func_ref = LuaAPI.xlua_tointeger(L, 2);
                    int _func_ref = LuaAPI.xlua_tointeger(L, 3);
                    
                        int gen_ret = XLua.LuaDLL.Lua.pcall_prepare( _L, _error_func_ref, _func_ref );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_luaL_unref_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _registryIndex = LuaAPI.xlua_tointeger(L, 2);
                    int _reference = LuaAPI.xlua_tointeger(L, 3);
                    
                    XLua.LuaDLL.Lua.luaL_unref( _L, _registryIndex, _reference );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_unref_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _reference = LuaAPI.xlua_tointeger(L, 2);
                    
                    XLua.LuaDLL.Lua.lua_unref( _L, _reference );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_isstring_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.lua_isstring( _L, _index );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_isinteger_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.lua_isinteger( _L, _index );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_pushnil_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                    XLua.LuaDLL.Lua.lua_pushnil( _L );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_pushstdcallcfunction_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& translator.Assignable<XLua.LuaDLL.lua_CSFunction>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    XLua.LuaDLL.lua_CSFunction _function = translator.GetDelegate<XLua.LuaDLL.lua_CSFunction>(L, 2);
                    int _n = LuaAPI.xlua_tointeger(L, 3);
                    
                    XLua.LuaDLL.Lua.lua_pushstdcallcfunction( _L, _function, _n );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& translator.Assignable<XLua.LuaDLL.lua_CSFunction>(L, 2)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    XLua.LuaDLL.lua_CSFunction _function = translator.GetDelegate<XLua.LuaDLL.lua_CSFunction>(L, 2);
                    
                    XLua.LuaDLL.Lua.lua_pushstdcallcfunction( _L, _function );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to XLua.LuaDLL.Lua.lua_pushstdcallcfunction!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_upvalueindex_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _n = LuaAPI.xlua_tointeger(L, 1);
                    
                        int gen_ret = XLua.LuaDLL.Lua.xlua_upvalueindex( _n );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_pcall_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _nArgs = LuaAPI.xlua_tointeger(L, 2);
                    int _nResults = LuaAPI.xlua_tointeger(L, 3);
                    int _errfunc = LuaAPI.xlua_tointeger(L, 4);
                    
                        int gen_ret = XLua.LuaDLL.Lua.lua_pcall( _L, _nArgs, _nResults, _errfunc );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_tonumber_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        double gen_ret = XLua.LuaDLL.Lua.lua_tonumber( _L, _index );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_tointeger_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = XLua.LuaDLL.Lua.xlua_tointeger( _L, _index );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_touint_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        uint gen_ret = XLua.LuaDLL.Lua.xlua_touint( _L, _index );
                        LuaAPI.xlua_pushuint(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_toboolean_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.lua_toboolean( _L, _index );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_topointer_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        System.IntPtr gen_ret = XLua.LuaDLL.Lua.lua_topointer( _L, _index );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_tolstring_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    System.IntPtr _strLen;
                    
                        System.IntPtr gen_ret = XLua.LuaDLL.Lua.lua_tolstring( _L, _index, out _strLen );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    LuaAPI.lua_pushlightuserdata(L, _strLen);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_tostring_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        string gen_ret = XLua.LuaDLL.Lua.lua_tostring( _L, _index );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_atpanic_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    XLua.LuaDLL.lua_CSFunction _panicf = translator.GetDelegate<XLua.LuaDLL.lua_CSFunction>(L, 2);
                    
                        System.IntPtr gen_ret = XLua.LuaDLL.Lua.lua_atpanic( _L, _panicf );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_pushnumber_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    double _number = LuaAPI.lua_tonumber(L, 2);
                    
                    XLua.LuaDLL.Lua.lua_pushnumber( _L, _number );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_pushboolean_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    bool _value = LuaAPI.lua_toboolean(L, 2);
                    
                    XLua.LuaDLL.Lua.lua_pushboolean( _L, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_pushinteger_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _value = LuaAPI.xlua_tointeger(L, 2);
                    
                    XLua.LuaDLL.Lua.xlua_pushinteger( _L, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_pushuint_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    uint _value = LuaAPI.xlua_touint(L, 2);
                    
                    XLua.LuaDLL.Lua.xlua_pushuint( _L, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_pushstring_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    string _str = LuaAPI.lua_tostring(L, 2);
                    
                    XLua.LuaDLL.Lua.lua_pushstring( _L, _str );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    byte[] _str = LuaAPI.lua_tobytes(L, 2);
                    
                    XLua.LuaDLL.Lua.lua_pushstring( _L, _str );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to XLua.LuaDLL.Lua.lua_pushstring!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_pushlstring_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    byte[] _str = LuaAPI.lua_tobytes(L, 2);
                    int _size = LuaAPI.xlua_tointeger(L, 3);
                    
                    XLua.LuaDLL.Lua.xlua_pushlstring( _L, _str, _size );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_pushasciistring_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    string _str = LuaAPI.lua_tostring(L, 2);
                    
                    XLua.LuaDLL.Lua.xlua_pushasciistring( _L, _str );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_tobytes_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        byte[] gen_ret = XLua.LuaDLL.Lua.lua_tobytes( _L, _index );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_luaL_newmetatable_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    string _meta = LuaAPI.lua_tostring(L, 2);
                    
                        int gen_ret = XLua.LuaDLL.Lua.luaL_newmetatable( _L, _meta );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_pgettable_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _idx = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = XLua.LuaDLL.Lua.xlua_pgettable( _L, _idx );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_psettable_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _idx = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = XLua.LuaDLL.Lua.xlua_psettable( _L, _idx );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_luaL_getmetatable_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    string _meta = LuaAPI.lua_tostring(L, 2);
                    
                    XLua.LuaDLL.Lua.luaL_getmetatable( _L, _meta );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xluaL_loadbuffer_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    byte[] _buff = LuaAPI.lua_tobytes(L, 2);
                    int _size = LuaAPI.xlua_tointeger(L, 3);
                    string _name = LuaAPI.lua_tostring(L, 4);
                    
                        int gen_ret = XLua.LuaDLL.Lua.xluaL_loadbuffer( _L, _buff, _size, _name );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_luaL_loadbuffer_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    string _buff = LuaAPI.lua_tostring(L, 2);
                    string _name = LuaAPI.lua_tostring(L, 3);
                    
                        int gen_ret = XLua.LuaDLL.Lua.luaL_loadbuffer( _L, _buff, _name );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_tocsobj_safe_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _obj = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = XLua.LuaDLL.Lua.xlua_tocsobj_safe( _L, _obj );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_tocsobj_fast_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _obj = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = XLua.LuaDLL.Lua.xlua_tocsobj_fast( _L, _obj );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_error_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                        int gen_ret = XLua.LuaDLL.Lua.lua_error( _L );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_checkstack_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _extra = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.lua_checkstack( _L, _extra );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_next_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = XLua.LuaDLL.Lua.lua_next( _L, _index );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_pushlightuserdata_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _udata = LuaAPI.lua_touserdata(L, 2);
                    
                    XLua.LuaDLL.Lua.lua_pushlightuserdata( _L, _udata );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_tag_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        System.IntPtr gen_ret = XLua.LuaDLL.Lua.xlua_tag(  );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_luaL_where_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _level = LuaAPI.xlua_tointeger(L, 2);
                    
                    XLua.LuaDLL.Lua.luaL_where( _L, _level );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_tryget_cachedud_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _key = LuaAPI.xlua_tointeger(L, 2);
                    int _cache_ref = LuaAPI.xlua_tointeger(L, 3);
                    
                        int gen_ret = XLua.LuaDLL.Lua.xlua_tryget_cachedud( _L, _key, _cache_ref );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_pushcsobj_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _key = LuaAPI.xlua_tointeger(L, 2);
                    int _meta_ref = LuaAPI.xlua_tointeger(L, 3);
                    bool _need_cache = LuaAPI.lua_toboolean(L, 4);
                    int _cache_ref = LuaAPI.xlua_tointeger(L, 5);
                    
                    XLua.LuaDLL.Lua.xlua_pushcsobj( _L, _key, _meta_ref, _need_cache, _cache_ref );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_gen_obj_indexer_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                        int gen_ret = XLua.LuaDLL.Lua.gen_obj_indexer( _L );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_gen_obj_newindexer_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                        int gen_ret = XLua.LuaDLL.Lua.gen_obj_newindexer( _L );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_gen_cls_indexer_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                        int gen_ret = XLua.LuaDLL.Lua.gen_cls_indexer( _L );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_gen_cls_newindexer_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                        int gen_ret = XLua.LuaDLL.Lua.gen_cls_newindexer( _L );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_get_error_func_ref_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                        int gen_ret = XLua.LuaDLL.Lua.get_error_func_ref( _L );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_load_error_func_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _Ref = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = XLua.LuaDLL.Lua.load_error_func( _L, _Ref );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_luaopen_i64lib_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                        int gen_ret = XLua.LuaDLL.Lua.luaopen_i64lib( _L );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_luaopen_socket_core_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                        int gen_ret = XLua.LuaDLL.Lua.luaopen_socket_core( _L );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_pushint64_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    long _n = LuaAPI.lua_toint64(L, 2);
                    
                    XLua.LuaDLL.Lua.lua_pushint64( _L, _n );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_pushuint64_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    ulong _n = LuaAPI.lua_touint64(L, 2);
                    
                    XLua.LuaDLL.Lua.lua_pushuint64( _L, _n );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_isint64_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _idx = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.lua_isint64( _L, _idx );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_isuint64_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _idx = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.lua_isuint64( _L, _idx );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_toint64_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _idx = LuaAPI.xlua_tointeger(L, 2);
                    
                        long gen_ret = XLua.LuaDLL.Lua.lua_toint64( _L, _idx );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_touint64_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _idx = LuaAPI.xlua_tointeger(L, 2);
                    
                        ulong gen_ret = XLua.LuaDLL.Lua.lua_touint64( _L, _idx );
                        LuaAPI.lua_pushuint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_push_csharp_function_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    System.IntPtr _fn = LuaAPI.lua_touserdata(L, 2);
                    int _n = LuaAPI.xlua_tointeger(L, 3);
                    
                    XLua.LuaDLL.Lua.xlua_push_csharp_function( _L, _fn, _n );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_csharp_str_error_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    string _message = LuaAPI.lua_tostring(L, 2);
                    
                        int gen_ret = XLua.LuaDLL.Lua.xlua_csharp_str_error( _L, _message );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_csharp_error_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                        int gen_ret = XLua.LuaDLL.Lua.xlua_csharp_error( _L );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_pack_int8_t_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    byte _field = (byte)LuaAPI.xlua_tointeger(L, 3);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_pack_int8_t( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_unpack_int8_t_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    byte _field;
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_unpack_int8_t( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.xlua_pushinteger(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_pack_int16_t_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    short _field = (short)LuaAPI.xlua_tointeger(L, 3);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_pack_int16_t( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_unpack_int16_t_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    short _field;
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_unpack_int16_t( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.xlua_pushinteger(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_pack_int32_t_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    int _field = LuaAPI.xlua_tointeger(L, 3);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_pack_int32_t( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_unpack_int32_t_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    int _field;
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_unpack_int32_t( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.xlua_pushinteger(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_pack_int64_t_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    long _field = LuaAPI.lua_toint64(L, 3);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_pack_int64_t( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_unpack_int64_t_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    long _field;
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_unpack_int64_t( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.lua_pushint64(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_pack_float_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    float _field = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_pack_float( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_unpack_float_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    float _field;
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_unpack_float( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.lua_pushnumber(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_pack_double_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    double _field = LuaAPI.lua_tonumber(L, 3);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_pack_double( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_unpack_double_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    double _field;
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_unpack_double( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.lua_pushnumber(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_pushstruct_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    uint _size = LuaAPI.xlua_touint(L, 2);
                    int _meta_ref = LuaAPI.xlua_tointeger(L, 3);
                    
                        System.IntPtr gen_ret = XLua.LuaDLL.Lua.xlua_pushstruct( _L, _size, _meta_ref );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_pushcstable_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    uint _field_count = LuaAPI.xlua_touint(L, 2);
                    int _meta_ref = LuaAPI.xlua_tointeger(L, 3);
                    
                    XLua.LuaDLL.Lua.xlua_pushcstable( _L, _field_count, _meta_ref );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_lua_touserdata_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _idx = LuaAPI.xlua_tointeger(L, 2);
                    
                        System.IntPtr gen_ret = XLua.LuaDLL.Lua.lua_touserdata( _L, _idx );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_gettypeid_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _idx = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = XLua.LuaDLL.Lua.xlua_gettypeid( _L, _idx );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_get_registry_index_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        int gen_ret = XLua.LuaDLL.Lua.xlua_get_registry_index(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_pgettable_bypath_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _idx = LuaAPI.xlua_tointeger(L, 2);
                    string _path = LuaAPI.lua_tostring(L, 3);
                    
                        int gen_ret = XLua.LuaDLL.Lua.xlua_pgettable_bypath( _L, _idx, _path );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_psettable_bypath_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _idx = LuaAPI.xlua_tointeger(L, 2);
                    string _path = LuaAPI.lua_tostring(L, 3);
                    
                        int gen_ret = XLua.LuaDLL.Lua.xlua_psettable_bypath( _L, _idx, _path );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_pack_float2_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    float _f1 = (float)LuaAPI.lua_tonumber(L, 3);
                    float _f2 = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_pack_float2( _buff, _offset, _f1, _f2 );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_unpack_float2_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    float _f1;
                    float _f2;
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_unpack_float2( _buff, _offset, out _f1, out _f2 );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.lua_pushnumber(L, _f1);
                        
                    LuaAPI.lua_pushnumber(L, _f2);
                        
                    
                    
                    
                    return 3;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_pack_float3_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    float _f1 = (float)LuaAPI.lua_tonumber(L, 3);
                    float _f2 = (float)LuaAPI.lua_tonumber(L, 4);
                    float _f3 = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_pack_float3( _buff, _offset, _f1, _f2, _f3 );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_unpack_float3_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    float _f1;
                    float _f2;
                    float _f3;
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_unpack_float3( _buff, _offset, out _f1, out _f2, out _f3 );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.lua_pushnumber(L, _f1);
                        
                    LuaAPI.lua_pushnumber(L, _f2);
                        
                    LuaAPI.lua_pushnumber(L, _f3);
                        
                    
                    
                    
                    return 4;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_pack_float4_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    float _f1 = (float)LuaAPI.lua_tonumber(L, 3);
                    float _f2 = (float)LuaAPI.lua_tonumber(L, 4);
                    float _f3 = (float)LuaAPI.lua_tonumber(L, 5);
                    float _f4 = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_pack_float4( _buff, _offset, _f1, _f2, _f3, _f4 );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_unpack_float4_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    float _f1;
                    float _f2;
                    float _f3;
                    float _f4;
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_unpack_float4( _buff, _offset, out _f1, out _f2, out _f3, out _f4 );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.lua_pushnumber(L, _f1);
                        
                    LuaAPI.lua_pushnumber(L, _f2);
                        
                    LuaAPI.lua_pushnumber(L, _f3);
                        
                    LuaAPI.lua_pushnumber(L, _f4);
                        
                    
                    
                    
                    return 5;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_pack_float5_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    float _f1 = (float)LuaAPI.lua_tonumber(L, 3);
                    float _f2 = (float)LuaAPI.lua_tonumber(L, 4);
                    float _f3 = (float)LuaAPI.lua_tonumber(L, 5);
                    float _f4 = (float)LuaAPI.lua_tonumber(L, 6);
                    float _f5 = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_pack_float5( _buff, _offset, _f1, _f2, _f3, _f4, _f5 );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_unpack_float5_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    float _f1;
                    float _f2;
                    float _f3;
                    float _f4;
                    float _f5;
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_unpack_float5( _buff, _offset, out _f1, out _f2, out _f3, out _f4, out _f5 );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.lua_pushnumber(L, _f1);
                        
                    LuaAPI.lua_pushnumber(L, _f2);
                        
                    LuaAPI.lua_pushnumber(L, _f3);
                        
                    LuaAPI.lua_pushnumber(L, _f4);
                        
                    LuaAPI.lua_pushnumber(L, _f5);
                        
                    
                    
                    
                    return 6;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_pack_float6_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    float _f1 = (float)LuaAPI.lua_tonumber(L, 3);
                    float _f2 = (float)LuaAPI.lua_tonumber(L, 4);
                    float _f3 = (float)LuaAPI.lua_tonumber(L, 5);
                    float _f4 = (float)LuaAPI.lua_tonumber(L, 6);
                    float _f5 = (float)LuaAPI.lua_tonumber(L, 7);
                    float _f6 = (float)LuaAPI.lua_tonumber(L, 8);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_pack_float6( _buff, _offset, _f1, _f2, _f3, _f4, _f5, _f6 );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_unpack_float6_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    float _f1;
                    float _f2;
                    float _f3;
                    float _f4;
                    float _f5;
                    float _f6;
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_unpack_float6( _buff, _offset, out _f1, out _f2, out _f3, out _f4, out _f5, out _f6 );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.lua_pushnumber(L, _f1);
                        
                    LuaAPI.lua_pushnumber(L, _f2);
                        
                    LuaAPI.lua_pushnumber(L, _f3);
                        
                    LuaAPI.lua_pushnumber(L, _f4);
                        
                    LuaAPI.lua_pushnumber(L, _f5);
                        
                    LuaAPI.lua_pushnumber(L, _f6);
                        
                    
                    
                    
                    return 7;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_pack_decimal_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    decimal _dec;translator.Get(L, 3, out _dec);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_pack_decimal( _buff, _offset, ref _dec );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.PushDecimal(L, _dec);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_unpack_decimal_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    byte _scale;
                    byte _sign;
                    int _hi32;
                    ulong _lo64;
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_unpack_decimal( _buff, _offset, out _scale, out _sign, out _hi32, out _lo64 );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.xlua_pushinteger(L, _scale);
                        
                    LuaAPI.xlua_pushinteger(L, _sign);
                        
                    LuaAPI.xlua_pushinteger(L, _hi32);
                        
                    LuaAPI.lua_pushuint64(L, _lo64);
                        
                    
                    
                    
                    return 5;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_is_eq_str_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    string _str = LuaAPI.lua_tostring(L, 3);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_is_eq_str( _L, _index, _str );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    string _str = LuaAPI.lua_tostring(L, 3);
                    int _str_len = LuaAPI.xlua_tointeger(L, 4);
                    
                        bool gen_ret = XLua.LuaDLL.Lua.xlua_is_eq_str( _L, _index, _str, _str_len );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to XLua.LuaDLL.Lua.xlua_is_eq_str!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_xlua_gl_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 1);
                    
                        System.IntPtr gen_ret = XLua.LuaDLL.Lua.xlua_gl( _L );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
