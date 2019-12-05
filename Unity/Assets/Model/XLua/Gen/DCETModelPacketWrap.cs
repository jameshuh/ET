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
    public class DCETModelPacketWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DCET.Model.Packet);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 6, 0, 0);
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PacketSizeLength2", DCET.Model.Packet.PacketSizeLength2);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PacketSizeLength4", DCET.Model.Packet.PacketSizeLength4);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MinPacketSize", DCET.Model.Packet.MinPacketSize);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OpcodeIndex", DCET.Model.Packet.OpcodeIndex);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MessageIndex", DCET.Model.Packet.MessageIndex);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "DCET.Model.Packet does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        
        
        
        
        
		
		
		
		
    }
}
