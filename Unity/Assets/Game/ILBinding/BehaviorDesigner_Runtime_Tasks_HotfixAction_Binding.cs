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
    unsafe class BehaviorDesigner_Runtime_Tasks_HotfixAction_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(BehaviorDesigner.Runtime.Tasks.HotfixAction);

            field = type.GetField("behaviorTreeConfigID", flag);
            app.RegisterCLRFieldGetter(field, get_behaviorTreeConfigID_0);
            app.RegisterCLRFieldSetter(field, set_behaviorTreeConfigID_0);
            field = type.GetField("onTick", flag);
            app.RegisterCLRFieldGetter(field, get_onTick_1);
            app.RegisterCLRFieldSetter(field, set_onTick_1);


        }



        static object get_behaviorTreeConfigID_0(ref object o)
        {
            return ((BehaviorDesigner.Runtime.Tasks.HotfixAction)o).behaviorTreeConfigID;
        }
        static void set_behaviorTreeConfigID_0(ref object o, object v)
        {
            ((BehaviorDesigner.Runtime.Tasks.HotfixAction)o).behaviorTreeConfigID = (System.Int32)v;
        }
        static object get_onTick_1(ref object o)
        {
            return ((BehaviorDesigner.Runtime.Tasks.HotfixAction)o).onTick;
        }
        static void set_onTick_1(ref object o, object v)
        {
            ((BehaviorDesigner.Runtime.Tasks.HotfixAction)o).onTick = (System.Func<BehaviorDesigner.Runtime.Tasks.TaskStatus>)v;
        }


    }
}
