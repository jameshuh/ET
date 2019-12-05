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
    public class DCETModelEventIdTypeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DCET.Model.EventIdType);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 21, 0, 0);
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RecvHotfixMessage", DCET.Model.EventIdType.RecvHotfixMessage);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BehaviorTreeRunTreeEvent", DCET.Model.EventIdType.BehaviorTreeRunTreeEvent);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BehaviorTreeOpenEditor", DCET.Model.EventIdType.BehaviorTreeOpenEditor);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BehaviorTreeClickNode", DCET.Model.EventIdType.BehaviorTreeClickNode);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BehaviorTreeAfterChangeNodeType", DCET.Model.EventIdType.BehaviorTreeAfterChangeNodeType);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BehaviorTreeCreateNode", DCET.Model.EventIdType.BehaviorTreeCreateNode);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BehaviorTreePropertyDesignerNewCreateClick", DCET.Model.EventIdType.BehaviorTreePropertyDesignerNewCreateClick);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BehaviorTreeMouseInNode", DCET.Model.EventIdType.BehaviorTreeMouseInNode);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BehaviorTreeConnectState", DCET.Model.EventIdType.BehaviorTreeConnectState);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BehaviorTreeReplaceClick", DCET.Model.EventIdType.BehaviorTreeReplaceClick);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BehaviorTreeRightDesignerDrag", DCET.Model.EventIdType.BehaviorTreeRightDesignerDrag);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SessionRecvMessage", DCET.Model.EventIdType.SessionRecvMessage);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NumbericChange", DCET.Model.EventIdType.NumbericChange);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MessageDeserializeFinish", DCET.Model.EventIdType.MessageDeserializeFinish);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SceneChange", DCET.Model.EventIdType.SceneChange);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FrameUpdate", DCET.Model.EventIdType.FrameUpdate);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LoadingBegin", DCET.Model.EventIdType.LoadingBegin);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LoadingFinish", DCET.Model.EventIdType.LoadingFinish);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TestHotfixSubscribMonoEvent", DCET.Model.EventIdType.TestHotfixSubscribMonoEvent);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MaxModelEvent", DCET.Model.EventIdType.MaxModelEvent);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "DCET.Model.EventIdType does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        
        
        
        
        
		
		
		
		
    }
}
