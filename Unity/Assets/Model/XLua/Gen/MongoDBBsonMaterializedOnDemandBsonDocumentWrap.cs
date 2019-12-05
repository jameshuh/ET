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
    public class MongoDBBsonMaterializedOnDemandBsonDocumentWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MongoDB.Bson.MaterializedOnDemandBsonDocument);
			Utils.BeginObjectRegister(type, L, translator, 0, 25, 6, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "get_Item", _m_get_Item);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "set_Item", _m_set_Item);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Add", _m_Add);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddRange", _m_AddRange);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clone", _m_Clone);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CompareTo", _m_CompareTo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Contains", _m_Contains);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ContainsValue", _m_ContainsValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DeepClone", _m_DeepClone);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", _m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetElement", _m_GetElement);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEnumerator", _m_GetEnumerator);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", _m_GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetValue", _m_GetValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InsertAt", _m_InsertAt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Merge", _m_Merge);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Remove", _m_Remove);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveAt", _m_RemoveAt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveElement", _m_RemoveElement);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Set", _m_Set);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetElement", _m_SetElement);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetElement", _m_TryGetElement);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetValue", _m_TryGetValue);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ElementCount", _g_get_ElementCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Elements", _g_get_Elements);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsDisposed", _g_get_IsDisposed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsMaterialized", _g_get_IsMaterialized);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Names", _g_get_Names);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Values", _g_get_Values);
            
			
			
			Utils.EndObjectRegister(type, L, translator, __CSIndexer, __NewIndexer,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "MongoDB.Bson.MaterializedOnDemandBsonDocument does not have a constructor!");
        }
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __CSIndexer(RealStatePtr L)
        {
			try {
			    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				
				if (translator.Assignable<MongoDB.Bson.MaterializedOnDemandBsonDocument>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					
					MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
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
				
				if (translator.Assignable<MongoDB.Bson.MaterializedOnDemandBsonDocument>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && translator.Assignable<MongoDB.Bson.BsonValue>(L, 3))
				{
					
					MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
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
        static int _m_get_Item(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
					string key = LuaAPI.lua_tostring(L, 2);
					translator.Push(L, gen_to_be_invoked[key]);
					
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_set_Item(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
					string key = LuaAPI.lua_tostring(L, 2);
					gen_to_be_invoked[key] = (MongoDB.Bson.BsonValue)translator.GetObject(L, 3, typeof(MongoDB.Bson.BsonValue));
                    
                    
                    
                    return 0;
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
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<MongoDB.Bson.BsonElement>(L, 2)) 
                {
                    MongoDB.Bson.BsonElement _element;translator.Get(L, 2, out _element);
                    
                        MongoDB.Bson.BsonDocument gen_ret = gen_to_be_invoked.Add( _element );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<MongoDB.Bson.BsonValue>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    MongoDB.Bson.BsonValue _value = (MongoDB.Bson.BsonValue)translator.GetObject(L, 3, typeof(MongoDB.Bson.BsonValue));
                    
                        MongoDB.Bson.BsonDocument gen_ret = gen_to_be_invoked.Add( _name, _value );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<MongoDB.Bson.BsonValue>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    MongoDB.Bson.BsonValue _value = (MongoDB.Bson.BsonValue)translator.GetObject(L, 3, typeof(MongoDB.Bson.BsonValue));
                    bool _condition = LuaAPI.lua_toboolean(L, 4);
                    
                        MongoDB.Bson.BsonDocument gen_ret = gen_to_be_invoked.Add( _name, _value, _condition );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Func<MongoDB.Bson.BsonValue>>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Func<MongoDB.Bson.BsonValue> _valueFactory = translator.GetDelegate<System.Func<MongoDB.Bson.BsonValue>>(L, 3);
                    bool _condition = LuaAPI.lua_toboolean(L, 4);
                    
                        MongoDB.Bson.BsonDocument gen_ret = gen_to_be_invoked.Add( _name, _valueFactory, _condition );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.MaterializedOnDemandBsonDocument.Add!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddRange(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.Dictionary<string, object>>(L, 2)) 
                {
                    System.Collections.Generic.Dictionary<string, object> _dictionary = (System.Collections.Generic.Dictionary<string, object>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<string, object>));
                    
                        MongoDB.Bson.BsonDocument gen_ret = gen_to_be_invoked.AddRange( _dictionary );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.IDictionary>(L, 2)) 
                {
                    System.Collections.IDictionary _dictionary = (System.Collections.IDictionary)translator.GetObject(L, 2, typeof(System.Collections.IDictionary));
                    
                        MongoDB.Bson.BsonDocument gen_ret = gen_to_be_invoked.AddRange( _dictionary );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.IEnumerable<MongoDB.Bson.BsonElement>>(L, 2)) 
                {
                    System.Collections.Generic.IEnumerable<MongoDB.Bson.BsonElement> _elements = (System.Collections.Generic.IEnumerable<MongoDB.Bson.BsonElement>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<MongoDB.Bson.BsonElement>));
                    
                        MongoDB.Bson.BsonDocument gen_ret = gen_to_be_invoked.AddRange( _elements );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>>(L, 2)) 
                {
                    System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>> _dictionary = (System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>));
                    
                        MongoDB.Bson.BsonDocument gen_ret = gen_to_be_invoked.AddRange( _dictionary );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.MaterializedOnDemandBsonDocument.AddRange!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clone(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_CompareTo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<MongoDB.Bson.BsonDocument>(L, 2)) 
                {
                    MongoDB.Bson.BsonDocument _other = (MongoDB.Bson.BsonDocument)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonDocument));
                    
                        int gen_ret = gen_to_be_invoked.CompareTo( _other );
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
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.MaterializedOnDemandBsonDocument.CompareTo!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Contains(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        bool gen_ret = gen_to_be_invoked.Contains( _name );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ContainsValue(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.BsonValue _value = (MongoDB.Bson.BsonValue)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonValue));
                    
                        bool gen_ret = gen_to_be_invoked.ContainsValue( _value );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
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
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
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
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    object _obj = translator.GetObject(L, 2, typeof(object));
                    
                        bool gen_ret = gen_to_be_invoked.Equals( _obj );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetElement(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        MongoDB.Bson.BsonElement gen_ret = gen_to_be_invoked.GetElement( _index );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        MongoDB.Bson.BsonElement gen_ret = gen_to_be_invoked.GetElement( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.MaterializedOnDemandBsonDocument.GetElement!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEnumerator(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        System.Collections.Generic.IEnumerator<MongoDB.Bson.BsonElement> gen_ret = gen_to_be_invoked.GetEnumerator(  );
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
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_GetValue(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        MongoDB.Bson.BsonValue gen_ret = gen_to_be_invoked.GetValue( _index );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        MongoDB.Bson.BsonValue gen_ret = gen_to_be_invoked.GetValue( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<MongoDB.Bson.BsonValue>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    MongoDB.Bson.BsonValue _defaultValue = (MongoDB.Bson.BsonValue)translator.GetObject(L, 3, typeof(MongoDB.Bson.BsonValue));
                    
                        MongoDB.Bson.BsonValue gen_ret = gen_to_be_invoked.GetValue( _name, _defaultValue );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.MaterializedOnDemandBsonDocument.GetValue!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InsertAt(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    MongoDB.Bson.BsonElement _element;translator.Get(L, 3, out _element);
                    
                    gen_to_be_invoked.InsertAt( _index, _element );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Merge(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<MongoDB.Bson.BsonDocument>(L, 2)) 
                {
                    MongoDB.Bson.BsonDocument _document = (MongoDB.Bson.BsonDocument)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonDocument));
                    
                        MongoDB.Bson.BsonDocument gen_ret = gen_to_be_invoked.Merge( _document );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<MongoDB.Bson.BsonDocument>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    MongoDB.Bson.BsonDocument _document = (MongoDB.Bson.BsonDocument)translator.GetObject(L, 2, typeof(MongoDB.Bson.BsonDocument));
                    bool _overwriteExistingElements = LuaAPI.lua_toboolean(L, 3);
                    
                        MongoDB.Bson.BsonDocument gen_ret = gen_to_be_invoked.Merge( _document, _overwriteExistingElements );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.MaterializedOnDemandBsonDocument.Merge!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Remove(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.Remove( _name );
                    
                    
                    
                    return 0;
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
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_RemoveElement(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    MongoDB.Bson.BsonElement _element;translator.Get(L, 2, out _element);
                    
                    gen_to_be_invoked.RemoveElement( _element );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Set(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<MongoDB.Bson.BsonValue>(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    MongoDB.Bson.BsonValue _value = (MongoDB.Bson.BsonValue)translator.GetObject(L, 3, typeof(MongoDB.Bson.BsonValue));
                    
                        MongoDB.Bson.BsonDocument gen_ret = gen_to_be_invoked.Set( _index, _value );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<MongoDB.Bson.BsonValue>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    MongoDB.Bson.BsonValue _value = (MongoDB.Bson.BsonValue)translator.GetObject(L, 3, typeof(MongoDB.Bson.BsonValue));
                    
                        MongoDB.Bson.BsonDocument gen_ret = gen_to_be_invoked.Set( _name, _value );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.MaterializedOnDemandBsonDocument.Set!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetElement(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<MongoDB.Bson.BsonElement>(L, 2)) 
                {
                    MongoDB.Bson.BsonElement _element;translator.Get(L, 2, out _element);
                    
                        MongoDB.Bson.BsonDocument gen_ret = gen_to_be_invoked.SetElement( _element );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<MongoDB.Bson.BsonElement>(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    MongoDB.Bson.BsonElement _element;translator.Get(L, 3, out _element);
                    
                        MongoDB.Bson.BsonDocument gen_ret = gen_to_be_invoked.SetElement( _index, _element );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to MongoDB.Bson.MaterializedOnDemandBsonDocument.SetElement!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetElement(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    MongoDB.Bson.BsonElement _value;
                    
                        bool gen_ret = gen_to_be_invoked.TryGetElement( _name, out _value );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _value);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetValue(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    MongoDB.Bson.BsonValue _value;
                    
                        bool gen_ret = gen_to_be_invoked.TryGetValue( _name, out _value );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _value);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ElementCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.ElementCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Elements(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.Elements);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsDisposed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsDisposed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsMaterialized(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsMaterialized);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Names(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.Names);
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
			
                MongoDB.Bson.MaterializedOnDemandBsonDocument gen_to_be_invoked = (MongoDB.Bson.MaterializedOnDemandBsonDocument)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.Values);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
