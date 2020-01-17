using DCET.Model;
using System.IO;
using UnityEditor;

namespace DCET.Editor
{
	[InitializeOnLoad]
    public static class GenCoreHotfix
	{
		public const string LuaDir = "./Lua/";
		public const string LuaSuffixName = ".txt";
		public const string LuaExtensionName = ".lua";

		private const string ScriptAssembliesDir = "Library/ScriptAssemblies";
        private const string CodeDir = "Assets/Res/Code/";
		private const string MetaExtensionName = ".meta";

		static GenCoreHotfix()
		{
			CopyDll();
		}

		[MenuItem("CSharpLua/Compile CoreHotfix")]
		public static void CompileLua()
		{
			CompileLua("Unity.DCET.Core.Hotfix", "./Packages/DCET/Core/Hotfix", "Core");
		}

		public static void CopyDll()
		{
			CopyDll("Unity.DCET.Core.Hotfix");
		}

		public static void CopyDll(string dllName)
		{
			File.Copy(Path.Combine(ScriptAssembliesDir, $"{dllName}.dll"), Path.Combine(CodeDir, $"{dllName}.dll.bytes"), true);
			File.Copy(Path.Combine(ScriptAssembliesDir, $"{dllName}.pdb"), Path.Combine(CodeDir, $"{dllName}.pdb.bytes"), true);
			Log.Info($"复制{dllName}.dll, {dllName}.pdb到Res/Code完成");
			AssetDatabase.Refresh();
		}

		public static void CompileLua(string dllName, string dllDir, string outDirName)
		{
			LuaCompiler.Compile(dllName, dllDir, outDirName);
			FileHelper.CopyDirectory(LuaCompiler.outDir + outDirName, LuaDir + outDirName);
			FileHelper.RenameAllFileSuffix(LuaCompiler.outDir + outDirName, LuaExtensionName, LuaSuffixName);
			AssetDatabase.Refresh();
		}

		[MenuItem("CSharpLua/Rename All Files In Selected Folder")]
		public static void RenameSelectedFolder()
		{
			var assetGUIDs = Selection.assetGUIDs;

			foreach (var guid in assetGUIDs)
			{
				var assetPath = AssetDatabase.GUIDToAssetPath(guid);

				if (Directory.Exists(assetPath))
				{
					var outDirName = assetPath.Substring(assetPath.LastIndexOf("/") + 1);

					FileHelper.CleanDirectory(LuaDir + outDirName);
					FileHelper.CopyDirectory(LuaCompiler.outDir + outDirName, LuaDir + outDirName);
					FileHelper.CleanDirectory(LuaDir + outDirName, MetaExtensionName);
					FileHelper.RenameAllFileSuffix(LuaCompiler.outDir + outDirName, LuaExtensionName, LuaSuffixName);
				}
			}

			AssetDatabase.Refresh();
		}
	}
}