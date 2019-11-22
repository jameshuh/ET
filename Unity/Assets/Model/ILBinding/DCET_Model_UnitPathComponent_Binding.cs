using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class DCET_Model_UnitPathComponent_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(DCET.Model.UnitPathComponent);
            args = new Type[]{typeof(DCET.Model.M2C_PathfindingResult)};
            method = type.GetMethod("StartMove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartMove_0);


        }


        static StackObject* StartMove_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            DCET.Model.M2C_PathfindingResult @message = (DCET.Model.M2C_PathfindingResult)typeof(DCET.Model.M2C_PathfindingResult).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            DCET.Model.UnitPathComponent instance_of_this_method = (DCET.Model.UnitPathComponent)typeof(DCET.Model.UnitPathComponent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.StartMove(@message);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



    }
}
