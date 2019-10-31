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
    unsafe class BehaviorDesigner_Runtime_BehaviorTreeController_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(BehaviorDesigner.Runtime.BehaviorTreeController);
            args = new Type[]{};
            method = type.GetMethod("Init", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Init_0);

            field = type.GetField("hotfixActions", flag);
            app.RegisterCLRFieldGetter(field, get_hotfixActions_0);
            field = type.GetField("hotfixComposites", flag);
            app.RegisterCLRFieldGetter(field, get_hotfixComposites_1);
            field = type.GetField("hotfixConditionals", flag);
            app.RegisterCLRFieldGetter(field, get_hotfixConditionals_2);
            field = type.GetField("hotfixDecorators", flag);
            app.RegisterCLRFieldGetter(field, get_hotfixDecorators_3);


        }


        static StackObject* Init_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            BehaviorDesigner.Runtime.BehaviorTreeController instance_of_this_method = (BehaviorDesigner.Runtime.BehaviorTreeController)typeof(BehaviorDesigner.Runtime.BehaviorTreeController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Init();

            return __ret;
        }


        static object get_hotfixActions_0(ref object o)
        {
            return ((BehaviorDesigner.Runtime.BehaviorTreeController)o).hotfixActions;
        }
        static object get_hotfixComposites_1(ref object o)
        {
            return ((BehaviorDesigner.Runtime.BehaviorTreeController)o).hotfixComposites;
        }
        static object get_hotfixConditionals_2(ref object o)
        {
            return ((BehaviorDesigner.Runtime.BehaviorTreeController)o).hotfixConditionals;
        }
        static object get_hotfixDecorators_3(ref object o)
        {
            return ((BehaviorDesigner.Runtime.BehaviorTreeController)o).hotfixDecorators;
        }


    }
}
