using DCET.Runtime;
using UnityEditor;
using UnityEngine;

namespace DCET.Editor
{
	public static class GenProtocol
	{		
		private static readonly string protogenDir = $"{Application.dataPath}/../../Proto/";
		private static readonly string protogenPath = $"{protogenDir}protogen.bat";

		[MenuItem("Tools/生成协议")]
		public static void Start()
		{
			ProcessHelper.Run(protogenPath, string.Empty, protogenDir);
		}
	}
}
