#if ILRuntime
using DCET.Model;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public static class ILRuntimeCLRBinding
{
	private const string OutputPath = "Assets/Model/ILBinding";

	[MenuItem("Tools/ILRuntime/Generate CLR Binding Code by Analysis")]
    static void GenerateCLRBindingByAnalysis()
	{
		List<Type> types = new List<Type>();
		types.Add(typeof(int));
		types.Add(typeof(float));
		types.Add(typeof(long));
		types.Add(typeof(object));
		types.Add(typeof(string));
		types.Add(typeof(Array));
		types.Add(typeof(Vector2));
		types.Add(typeof(Vector3));
		types.Add(typeof(Quaternion));
		types.Add(typeof(GameObject));
		types.Add(typeof(UnityEngine.Object));
		types.Add(typeof(Transform));
		types.Add(typeof(RectTransform));
		types.Add(typeof(Time));
		types.Add(typeof(Debug));

		//所有DLL内的类型的真实C#类型都是ILTypeInstance
		types.Add(typeof(List<ILRuntime.Runtime.Intepreter.ILTypeInstance>));

		ILRuntime.Runtime.CLRBinding.BindingCodeGenerator.GenerateBindingCode(types, OutputPath);

		AssetDatabase.Refresh();

		//用新的分析热更dll调用引用来生成绑定代码
		ILRuntime.Runtime.Enviorment.AppDomain domain = new ILRuntime.Runtime.Enviorment.AppDomain();

		//Crossbind Adapter is needed to generate the correct binding code
		ILHelper.InitILRuntime(domain);

		LoadAssembly(domain, HotfixAssembly.CoreDllAssetBytes);
		LoadAssembly(domain, HotfixAssembly.ConfigDllAssetBytes);
		LoadAssembly(domain, HotfixAssembly.MessageDllAssetBytes);
		LoadAssembly(domain, HotfixAssembly.BehaviorTreeDllAssetBytes);
		LoadAssembly(domain, HotfixAssembly.FairyGUIDllAssetBytes);
		LoadAssembly(domain, HotfixAssembly.HotfixDllAssetBytes);

		ILRuntime.Runtime.CLRBinding.BindingCodeGenerator.GenerateBindingCode(domain, OutputPath);

		AssetDatabase.Refresh();
	}

	private static void LoadAssembly(ILRuntime.Runtime.Enviorment.AppDomain domain, string inputPath)
	{
		domain.LoadAssembly(new FileStream(inputPath, FileMode.Open, FileAccess.Read));
	}
}
#endif
