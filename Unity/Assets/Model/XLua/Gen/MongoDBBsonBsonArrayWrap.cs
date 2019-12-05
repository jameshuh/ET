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
    public class MongoDBBsonBsonArrayWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.BsonArray);
			Utils.BeginObjectRegister(type, L, translator, 1, 18, 5, 1);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__eq", __EqMeta);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Add", _m_Add);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddRange", _m_AddRange);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clone", _m_Clone);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CompareTo", _m_CompareTo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Contains", _m_Contains);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CopyTo", _m_CopyTo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DeepClone", _m_DeepClone);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", _m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEnumerator", _m_GetEnumerator);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", _m_GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IndexOf", _m_IndexOf);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Insert", _m_Insert);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Remove", _m_Remove);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveAt", _m_RemoveAt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToArray", _m_ToArray);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToList", _m_ToList);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", _m_ToString);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "BsonType", _g_get_BsonType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Capacity", _g_get_Capacity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Count", _g_get_Count);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsReadOnly", _g_get_IsReadOnly);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Values", _g_get_Values);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Capacity", _s_set_Capacity);
            
			
			Utils.EndObjectRegister(type, L, translator, __CSIndexer, __NewIndexer,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Create", _m_Create_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					MongoDB.Bson.BsonArray gen_ret = new MongoDB.Bson.BsonArray();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Collections.Generic.IEnumerable<bool>>(L, 2))
				{
					System.Collections.Generic.IEnumerable<bool> _values = (System.Collections.Generic.IEnumerable<bool>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<bool>));
					
					MongoDB.Bson.BsonArray gen_ret = new MongoDB.Bson.BsonArray(_values);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Collections.Generic.IEnumerable<MongoDB.Bson.BsonValue>>(L, 2))
				{
					System.Collections.Generic.IEnumerable<MongoDB.Bson.BsonValue> _values = (System.Collections.Generic.IEnumerable<MongoDB.Bson.BsonValue>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<MongoDB.Bson.BsonValue>));
					
					MongoDB.Bson.BsonArray gen_ret = new MongoDB.Bson.BsonArray(_values);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Collections.Generic.IEnumerable<System.DateTime>>(L, 2))
				{
					System.Collections.Generic.IEnumerable<System.DateTime> _values = (System.Collections.Generic.IEnumerable<System.DateTime>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<System.DateTime>));
					
					MongoDB.Bson.BsonArray gen_ret = new MongoDB.Bson.BsonArray(_values);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Collections.Generic.IEnumerable<double>>(L, 2))
				{
					System.Collections.Generic.IEnumerable<double> _values = (System.Collections.Generic.IEnumerable<double>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<double>));
					
					MongoDB.Bson.BsonArray gen_ret = new MongoDB.Bson.BsonArray(_values);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Collections.Generic.IEnumerable<int>>(L, 2))
				{
					System.Collections.Generic.IEnumerable<int> _values = (System.Collections.Generic.IEnumerable<int>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<int>));
					
					MongoDB.Bson.BsonArray gen_ret = new MongoDB.Bson.BsonArray(_values);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Collections.Generic.IEnumerable<long>>(L, 2))
				{
					System.Collections.Generic.IEnumerable<long> _values = (System.Collections.Generic.IEnumerable<long>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<long>));
					
					MongoDB.Bson.BsonArray gen_ret = new MongoDB.Bson.BsonArray(_values);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Collections.Generic.IEnumerable<MongoDB.Bson.ObjectId>>(L, 2))
				{
					System.Collections.Generic.IEnumerable<MongoDB.Bson.ObjectId> _values = (System.Collections.Generic.IEnumerable<MongoDB.Bson.ObjectId>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<MongoDB.Bson.ObjectId>));
					
					MongoDB.Bson.BsonArray gen_ret = new MongoDB.Bson.BsonArray(_values);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Collections.Generic.IEnumerable<string>>(L, 2))
				{
					System.Collections.Generic.IEnumerable<string> _values = (System.Collections.Generic.IEnumerable<string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<string>));
					
					MongoDB.Bson.BsonArray gen_ret = new MongoDB.Bson.BsonArray(_values);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Collections.IEnumerable>(L, 2))
				{
					System.Collections.IEnumerable _values = (System.Collections.IEnumerable)translator.GetObject(L, 2, typeof(System.Collections.IEnumerable));
					
					MongoDB.Bson.BsonArray gen_ret = new MongoDB.Bson.BsonArray(_values);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					int _capacity = LuaAPI.xlua_tointeger(L, 2);
					
					MongoDB.Bson.BsonArray gen_ret = new MongoDB.Bson.BsonArray(_capacity);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.BsonArray constructor!");
            
        }
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __CSIndexer(RealStatePtr L)
        {
			try {
			    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				
				if (translator.Assignable<MongoDB.Bson.BsonArray>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					
					MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
					int index = LuaAPI.xlua_tointeger(L, 2);
					LuaAPI.lua_pushboolean(L, true);
					translator.Push(L, gen_to_be_invoked[index]);
					return 2;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			
            LuaAPI.lua_pushboolean(L, false);
			return 1;
        }
		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __NewIndexer(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
			try {
				
				if (translator.Assignable<MongoDB.Bson.BsonArray>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && translator.Assignable<MongoDB.Bson.BsonValue>(L, 3))
				{
					
					MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
					int key = LuaAPI.xlua_tointeger(L, 2);
					gen_to_be_invoked[key] = (MongoDB.Bson.BsonValue)translator.GetObject(L, 3, typeof(MongoDB.Bson.BsonValue));
					LuaAPI.lua_pushboolean(L, true);
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			
			LuaAPI.lua_pushboolean(L, false);
            return 1;
        }
		
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __EqMeta(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			
				if (translator.Assignable<MongoDB.Bson.BsonArray>(L, 1) && translator.Assignable<MongoDB.Bson.BsonArray>(L, 2))
				{
					MongoDB.Bson.BsonArray leftside = (MongoDB.Bson.BsonArray)translator.GetObject(L, 1, typeof(MongoDB.Bson.BsonArray));
					MongoDB.Bson.BsonArray rightside = (MongoDB.Bson.BsonArray)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonArray));
					
					LuaAPI.lua_pushboolean(L, leftside == rightside);
					
					return 1;
				}
            
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of == operator, need MongoDB.Bson.BsonArray!");
            
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Create_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    object _value = translator.GetObject(L, 1, typeof(object));
                    
                        MongoDB.Bson.BsonArray gen_ret = MongoDB.Bson.BsonArray.Create( _value );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Add(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.BsonValue _value = (MongoDB.Bson.BsonValue)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonValue));
                    
                        MongoDB.Bson.BsonArray gen_ret = gen_to_be_invoked.Add( _value );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddRange(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.IEnumerable<bool>>(L, 2)) 
                {
                    System.Collections.Generic.IEnumerable<bool> _values = (System.Collections.Generic.IEnumerable<bool>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<bool>));
                    
                        MongoDB.Bson.BsonArray gen_ret = gen_to_be_invoked.AddRange( _values );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.IEnumerable<MongoDB.Bson.BsonValue>>(L, 2)) 
                {
                    System.Collections.Generic.IEnumerable<MongoDB.Bson.BsonValue> _values = (System.Collections.Generic.IEnumerable<MongoDB.Bson.BsonValue>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<MongoDB.Bson.BsonValue>));
                    
                        MongoDB.Bson.BsonArray gen_ret = gen_to_be_invoked.AddRange( _values );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.IEnumerable<System.DateTime>>(L, 2)) 
                {
                    System.Collections.Generic.IEnumerable<System.DateTime> _values = (System.Collections.Generic.IEnumerable<System.DateTime>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<System.DateTime>));
                    
                        MongoDB.Bson.BsonArray gen_ret = gen_to_be_invoked.AddRange( _values );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.IEnumerable<double>>(L, 2)) 
                {
                    System.Collections.Generic.IEnumerable<double> _values = (System.Collections.Generic.IEnumerable<double>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<double>));
                    
                        MongoDB.Bson.BsonArray gen_ret = gen_to_be_invoked.AddRange( _values );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.IEnumerable<int>>(L, 2)) 
                {
                    System.Collections.Generic.IEnumerable<int> _values = (System.Collections.Generic.IEnumerable<int>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<int>));
                    
                        MongoDB.Bson.BsonArray gen_ret = gen_to_be_invoked.AddRange( _values );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.IEnumerable<long>>(L, 2)) 
                {
                    System.Collections.Generic.IEnumerable<long> _values = (System.Collections.Generic.IEnumerable<long>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<long>));
                    
                        MongoDB.Bson.BsonArray gen_ret = gen_to_be_invoked.AddRange( _values );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.IEnumerable<MongoDB.Bson.ObjectId>>(L, 2)) 
                {
                    System.Collections.Generic.IEnumerable<MongoDB.Bson.ObjectId> _values = (System.Collections.Generic.IEnumerable<MongoDB.Bson.ObjectId>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<MongoDB.Bson.ObjectId>));
                    
                        MongoDB.Bson.BsonArray gen_ret = gen_to_be_invoked.AddRange( _values );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.IEnumerable<string>>(L, 2)) 
                {
                    System.Collections.Generic.IEnumerable<string> _values = (System.Collections.Generic.IEnumerable<string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<string>));
                    
                        MongoDB.Bson.BsonArray gen_ret = gen_to_be_invoked.AddRange( _values );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.IEnumerable>(L, 2)) 
                {
                    System.Collections.IEnumerable _values = (System.Collections.IEnumerable)translator.GetObject(L, 2, typeof(System.Collections.IEnumerable));
                    
                        MongoDB.Bson.BsonArray gen_ret = gen_to_be_invoked.AddRange( _values );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.BsonArray.AddRange!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clone(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        MongoDB.Bson.BsonValue gen_ret = gen_to_be_invoked.Clone(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CompareTo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<MongoDB.Bson.BsonArray>(L, 2)) 
                {
                    MongoDB.Bson.BsonArray _rhs = (MongoDB.Bson.BsonArray)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonArray));
                    
                        int gen_ret = gen_to_be_invoked.CompareTo( _rhs );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<MongoDB.Bson.BsonValue>(L, 2)) 
                {
                    MongoDB.Bson.BsonValue _other = (MongoDB.Bson.BsonValue)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonValue));
                    
                        int gen_ret = gen_to_be_invoked.CompareTo( _other );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.BsonArray.CompareTo!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Contains(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.BsonValue _value = (MongoDB.Bson.BsonValue)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonValue));
                    
                        bool gen_ret = gen_to_be_invoked.Contains( _value );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CopyTo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.BsonValue[] _array = (MongoDB.Bson.BsonValue[])translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonValue[]));
                    int _arrayIndex = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.CopyTo( _array, _arrayIndex );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DeepClone(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        MongoDB.Bson.BsonValue gen_ret = gen_to_be_invoked.DeepClone(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Equals(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<MongoDB.Bson.BsonArray>(L, 2)) 
                {
                    MongoDB.Bson.BsonArray _obj = (MongoDB.Bson.BsonArray)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonArray));
                    
                        bool gen_ret = gen_to_be_invoked.Equals( _obj );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object _obj = translator.GetObject(L, 2, typeof(object));
                    
                        bool gen_ret = gen_to_be_invoked.Equals( _obj );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.BsonArray.Equals!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEnumerator(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Collections.Generic.IEnumerator<MongoDB.Bson.BsonValue> gen_ret = gen_to_be_invoked.GetEnumerator(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHashCode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int gen_ret = gen_to_be_invoked.GetHashCode(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IndexOf(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<MongoDB.Bson.BsonValue>(L, 2)) 
                {
                    MongoDB.Bson.BsonValue _value = (MongoDB.Bson.BsonValue)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonValue));
                    
                        int gen_ret = gen_to_be_invoked.IndexOf( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<MongoDB.Bson.BsonValue>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    MongoDB.Bson.BsonValue _value = (MongoDB.Bson.BsonValue)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonValue));
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    
                        int gen_ret = gen_to_be_invoked.IndexOf( _value, _index );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<MongoDB.Bson.BsonValue>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    MongoDB.Bson.BsonValue _value = (MongoDB.Bson.BsonValue)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonValue));
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    int _count = LuaAPI.xlua_tointeger(L, 4);
                    
                        int gen_ret = gen_to_be_invoked.IndexOf( _value, _index, _count );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.BsonArray.IndexOf!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Insert(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    MongoDB.Bson.BsonValue _value = (MongoDB.Bson.BsonValue)translator.GetObject(L, 3, typeof(MongoDB.Bson.BsonValue));
                    
                    gen_to_be_invoked.Insert( _index, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Remove(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.BsonValue _value = (MongoDB.Bson.BsonValue)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonValue));
                    
                        bool gen_ret = gen_to_be_invoked.Remove( _value );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveAt(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.RemoveAt( _index );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToArray(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        MongoDB.Bson.BsonValue[] gen_ret = gen_to_be_invoked.ToArray(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToList(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Collections.Generic.List<MongoDB.Bson.BsonValue> gen_ret = gen_to_be_invoked.ToList(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToString(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string gen_ret = gen_to_be_invoked.ToString(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BsonType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
                translator.PushMongoDBBsonBsonType(L, gen_to_be_invoked.BsonType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Capacity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Capacity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Count(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Count);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsReadOnly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsReadOnly);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Values(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.Values);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Capacity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.BsonArray gen_to_be_invoked = (MongoDB.Bson.BsonArray)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Capacity = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
