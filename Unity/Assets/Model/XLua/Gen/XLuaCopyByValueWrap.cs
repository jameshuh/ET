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
    public class XLuaCopyByValueWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(XLua.CopyByValue);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 4, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Pack", _m_Pack_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UnPack", _m_UnPack_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsStruct", _m_IsStruct_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "XLua.CopyByValue does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Pack_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    byte _field = (byte)LuaAPI.xlua_tointeger(L, 3);
                    
                        bool gen_ret = XLua.CopyByValue.Pack( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    sbyte _field = (sbyte)LuaAPI.xlua_tointeger(L, 3);
                    
                        bool gen_ret = XLua.CopyByValue.Pack( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    short _field = (short)LuaAPI.xlua_tointeger(L, 3);
                    
                        bool gen_ret = XLua.CopyByValue.Pack( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    ushort _field = (ushort)LuaAPI.xlua_tointeger(L, 3);
                    
                        bool gen_ret = XLua.CopyByValue.Pack( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    int _field = LuaAPI.xlua_tointeger(L, 3);
                    
                        bool gen_ret = XLua.CopyByValue.Pack( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    uint _field = LuaAPI.xlua_touint(L, 3);
                    
                        bool gen_ret = XLua.CopyByValue.Pack( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) || LuaAPI.lua_isint64(L, 3))) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    long _field = LuaAPI.lua_toint64(L, 3);
                    
                        bool gen_ret = XLua.CopyByValue.Pack( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) || LuaAPI.lua_isuint64(L, 3))) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    ulong _field = LuaAPI.lua_touint64(L, 3);
                    
                        bool gen_ret = XLua.CopyByValue.Pack( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    float _field = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        bool gen_ret = XLua.CopyByValue.Pack( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    double _field = LuaAPI.lua_tonumber(L, 3);
                    
                        bool gen_ret = XLua.CopyByValue.Pack( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) || translator.IsDecimal(L, 3))) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    decimal _field;translator.Get(L, 3, out _field);
                    
                        bool gen_ret = XLua.CopyByValue.Pack( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector2 _field;translator.Get(L, 3, out _field);
                    
                        bool gen_ret = XLua.CopyByValue.Pack( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector3 _field;translator.Get(L, 3, out _field);
                    
                        bool gen_ret = XLua.CopyByValue.Pack( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector4>(L, 3)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector4 _field;translator.Get(L, 3, out _field);
                    
                        bool gen_ret = XLua.CopyByValue.Pack( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Color>(L, 3)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Color _field;translator.Get(L, 3, out _field);
                    
                        bool gen_ret = XLua.CopyByValue.Pack( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Quaternion _field;translator.Get(L, 3, out _field);
                    
                        bool gen_ret = XLua.CopyByValue.Pack( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Ray>(L, 3)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Ray _field;translator.Get(L, 3, out _field);
                    
                        bool gen_ret = XLua.CopyByValue.Pack( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Bounds>(L, 3)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Bounds _field;translator.Get(L, 3, out _field);
                    
                        bool gen_ret = XLua.CopyByValue.Pack( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Ray2D>(L, 3)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Ray2D _field;translator.Get(L, 3, out _field);
                    
                        bool gen_ret = XLua.CopyByValue.Pack( _buff, _offset, _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to XLua.CopyByValue.Pack!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnPack_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    byte _field;
                    
                        bool gen_ret = XLua.CopyByValue.UnPack( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.xlua_pushinteger(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    sbyte _field;
                    
                        bool gen_ret = XLua.CopyByValue.UnPack( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.xlua_pushinteger(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    short _field;
                    
                        bool gen_ret = XLua.CopyByValue.UnPack( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.xlua_pushinteger(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    ushort _field;
                    
                        bool gen_ret = XLua.CopyByValue.UnPack( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.xlua_pushinteger(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    int _field;
                    
                        bool gen_ret = XLua.CopyByValue.UnPack( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.xlua_pushinteger(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    uint _field;
                    
                        bool gen_ret = XLua.CopyByValue.UnPack( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.xlua_pushuint(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    long _field;
                    
                        bool gen_ret = XLua.CopyByValue.UnPack( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.lua_pushint64(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    ulong _field;
                    
                        bool gen_ret = XLua.CopyByValue.UnPack( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.lua_pushuint64(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    float _field;
                    
                        bool gen_ret = XLua.CopyByValue.UnPack( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.lua_pushnumber(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    double _field;
                    
                        bool gen_ret = XLua.CopyByValue.UnPack( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.lua_pushnumber(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    decimal _field;
                    
                        bool gen_ret = XLua.CopyByValue.UnPack( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.PushDecimal(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector2 _field;
                    
                        bool gen_ret = XLua.CopyByValue.UnPack( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.PushUnityEngineVector2(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector3 _field;
                    
                        bool gen_ret = XLua.CopyByValue.UnPack( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.PushUnityEngineVector3(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector4 _field;
                    
                        bool gen_ret = XLua.CopyByValue.UnPack( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.PushUnityEngineVector4(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Color _field;
                    
                        bool gen_ret = XLua.CopyByValue.UnPack( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.PushUnityEngineColor(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Quaternion _field;
                    
                        bool gen_ret = XLua.CopyByValue.UnPack( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.PushUnityEngineQuaternion(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Ray _field;
                    
                        bool gen_ret = XLua.CopyByValue.UnPack( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.PushUnityEngineRay(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Bounds _field;
                    
                        bool gen_ret = XLua.CopyByValue.UnPack( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.PushUnityEngineBounds(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    System.IntPtr _buff = LuaAPI.lua_touserdata(L, 1);
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Ray2D _field;
                    
                        bool gen_ret = XLua.CopyByValue.UnPack( _buff, _offset, out _field );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.PushUnityEngineRay2D(L, _field);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 3&& translator.Assignable<XLua.ObjectTranslator>(L, 1)&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    XLua.ObjectTranslator _translator = (XLua.ObjectTranslator)translator.GetObject(L, 1, typeof(XLua.ObjectTranslator));
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _idx = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Vector2 _val;
                    
                    XLua.CopyByValue.UnPack( _translator, _L, _idx, out _val );
                    translator.PushUnityEngineVector2(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<XLua.ObjectTranslator>(L, 1)&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    XLua.ObjectTranslator _translator = (XLua.ObjectTranslator)translator.GetObject(L, 1, typeof(XLua.ObjectTranslator));
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _idx = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Vector3 _val;
                    
                    XLua.CopyByValue.UnPack( _translator, _L, _idx, out _val );
                    translator.PushUnityEngineVector3(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<XLua.ObjectTranslator>(L, 1)&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    XLua.ObjectTranslator _translator = (XLua.ObjectTranslator)translator.GetObject(L, 1, typeof(XLua.ObjectTranslator));
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _idx = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Vector4 _val;
                    
                    XLua.CopyByValue.UnPack( _translator, _L, _idx, out _val );
                    translator.PushUnityEngineVector4(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<XLua.ObjectTranslator>(L, 1)&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    XLua.ObjectTranslator _translator = (XLua.ObjectTranslator)translator.GetObject(L, 1, typeof(XLua.ObjectTranslator));
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _idx = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Color _val;
                    
                    XLua.CopyByValue.UnPack( _translator, _L, _idx, out _val );
                    translator.PushUnityEngineColor(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<XLua.ObjectTranslator>(L, 1)&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    XLua.ObjectTranslator _translator = (XLua.ObjectTranslator)translator.GetObject(L, 1, typeof(XLua.ObjectTranslator));
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _idx = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Quaternion _val;
                    
                    XLua.CopyByValue.UnPack( _translator, _L, _idx, out _val );
                    translator.PushUnityEngineQuaternion(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<XLua.ObjectTranslator>(L, 1)&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    XLua.ObjectTranslator _translator = (XLua.ObjectTranslator)translator.GetObject(L, 1, typeof(XLua.ObjectTranslator));
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _idx = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Ray _val;
                    
                    XLua.CopyByValue.UnPack( _translator, _L, _idx, out _val );
                    translator.PushUnityEngineRay(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<XLua.ObjectTranslator>(L, 1)&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    XLua.ObjectTranslator _translator = (XLua.ObjectTranslator)translator.GetObject(L, 1, typeof(XLua.ObjectTranslator));
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _idx = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Bounds _val;
                    
                    XLua.CopyByValue.UnPack( _translator, _L, _idx, out _val );
                    translator.PushUnityEngineBounds(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<XLua.ObjectTranslator>(L, 1)&& LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    XLua.ObjectTranslator _translator = (XLua.ObjectTranslator)translator.GetObject(L, 1, typeof(XLua.ObjectTranslator));
                    System.IntPtr _L = LuaAPI.lua_touserdata(L, 2);
                    int _idx = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Ray2D _val;
                    
                    XLua.CopyByValue.UnPack( _translator, _L, _idx, out _val );
                    translator.PushUnityEngineRay2D(L, _val);
                        
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to XLua.CopyByValue.UnPack!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsStruct_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 1, typeof(System.Type));
                    
                        bool gen_ret = XLua.CopyByValue.IsStruct( _type );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
