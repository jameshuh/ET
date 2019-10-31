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
    unsafe class BehaviorDesigner_Runtime_Behavior_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(BehaviorDesigner.Runtime.Behavior);
            args = new Type[]{};
            method = type.GetMethod("EnableBehavior", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EnableBehavior_0);
            args = new Type[]{};
            method = type.GetMethod("DisableBehavior", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DisableBehavior_1);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_StartWhenEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_StartWhenEnabled_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_ResetValuesOnRestart", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ResetValuesOnRestart_3);


        }


        static StackObject* EnableBehavior_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            BehaviorDesigner.Runtime.Behavior instance_of_this_method = (BehaviorDesigner.Runtime.Behavior)typeof(BehaviorDesigner.Runtime.Behavior).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.EnableBehavior();

            return __ret;
        }

        static StackObject* DisableBehavior_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            BehaviorDesigner.Runtime.Behavior instance_of_this_method = (BehaviorDesigner.Runtime.Behavior)typeof(BehaviorDesigner.Runtime.Behavior).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DisableBehavior();

            return __ret;
        }

        static StackObject* set_StartWhenEnabled_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            BehaviorDesigner.Runtime.Behavior instance_of_this_method = (BehaviorDesigner.Runtime.Behavior)typeof(BehaviorDesigner.Runtime.Behavior).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StartWhenEnabled = value;

            return __ret;
        }

        static StackObject* set_ResetValuesOnRestart_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            BehaviorDesigner.Runtime.Behavior instance_of_this_method = (BehaviorDesigner.Runtime.Behavior)typeof(BehaviorDesigner.Runtime.Behavior).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ResetValuesOnRestart = value;

            return __ret;
        }



    }
}
