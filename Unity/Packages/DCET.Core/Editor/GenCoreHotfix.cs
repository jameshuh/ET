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

		static GenCoreHotfix()
		{
			if (CopyDll("Unity.DCET.Core.Hotfix") && Define.IsLua)
			{
				CompileLua("Unity.DCET.Core.Hotfix", "./Packages/DCET.Core/Hotfix", "Core");
			}
		}
		
		public static bool CopyDll(string dllName)
		{
			var result = FileHelper.CopyFile(Path.Combine(ScriptAssembliesDir, $"{dllName}.dll"), Path.Combine(CodeDir, $"{dllName}.dll.bytes"), true);
			
			result = result || FileHelper.CopyFile(Path.Combine(ScriptAssembliesDir, $"{dllName}.pdb"), Path.Combine(CodeDir, $"{dllName}.pdb.bytes"), true);

			if (result)
			{
				Log.Info($"复制{dllName}.dll, {dllName}.pdb到Res/Code完成");
				AssetDatabase.Refresh();
			}

			return result;
		}

		public static void CompileLua(string dllName, string dllDir, string outDirName)
		{
			LuaCompiler.Compile(dllName, dllDir, outDirName);
			FileHelper.AppendSuffixName(LuaCompiler.outDir + outDirName, LuaExtensionName, LuaSuffixName);
			AssetDatabase.Refresh();
		}

		[MenuItem("XLua/Append the all lua file of the selected folder with \".txt\"")]
		public static void AppendSelectedFolder()
		{
			var assetGUIDs = Selection.assetGUIDs;

			foreach (var guid in assetGUIDs)
			{
				var assetPath = AssetDatabase.GUIDToAssetPath(guid);

				if (Directory.Exists(assetPath))
				{
					var outDirName = assetPath.Substring(assetPath.LastIndexOf("/") + 1);

					FileHelper.AppendSuffixName(LuaCompiler.outDir + outDirName, LuaExtensionName, LuaSuffixName);
				}
			}

			AssetDatabase.Refresh();
		}
	}
}