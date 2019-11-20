using DCET.Model;
using System.IO;
using UnityEditor;

namespace DCET.Editor
{
	[InitializeOnLoad]
    public static class CopyCoreHotfixDll
	{
        private const string ScriptAssembliesDir = "Library/ScriptAssemblies";
        private const string CodeDir = "Assets/Res/Code/";

		static CopyCoreHotfixDll()
		{
			Copy("Unity.DCET.Core.Hotfix");
		}

		public static void Copy(string dllName)
		{
			File.Copy(Path.Combine(ScriptAssembliesDir, $"{dllName}.dll"), Path.Combine(CodeDir, $"{dllName}.dll.bytes"), true);
			File.Copy(Path.Combine(ScriptAssembliesDir, $"{dllName}.pdb"), Path.Combine(CodeDir, $"{dllName}.pdb.bytes"), true);
			Log.Info($"复制{dllName}.dll, {dllName}.pdb到Res/Code完成");
			AssetDatabase.Refresh();
		}
    }
}