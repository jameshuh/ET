using CSharpLua;
using LuaInterface;
using System;
using System.IO;
using UnityEngine;

namespace DCET.Model
{
	public class LuaLoader : LuaFileUtils
	{
		public const string manifestFileName = "manifest.lua";
		private const string luaExtensionName = ".lua";
		private const string txtExtensionName = ".txt";
		private const string luaTxtExtensionName = ".lua.txt";
		private const string luaDir = "Res/Lua/";
		private const string luaSuffixName = "/lua";
		private const char dot = '.';
		private const char backSlash = '/';

		public LuaLoader()
		{
			instance = this;
			beZip = false;
		}

		public override byte[] ReadFile(string fileName)
		{
			var buffer = base.ReadFile(fileName);

			if (buffer == null)
			{
				if (Define.IsEditorMode)
				{
					return EditorLoader(fileName);
				}
				else
				{
					return AssetBundleLoader(fileName);
				}
			}

			return buffer;
		}

		private byte[] EditorLoader(string filepath)
		{
			if (!string.IsNullOrWhiteSpace(filepath))
			{
				var splits = filepath.Split(dot);

				if (splits != null)
				{
					if (filepath.EndsWith(luaExtensionName))
					{
						var path = Path.Combine(Application.dataPath, luaDir + filepath.Replace(dot, backSlash).Replace(luaSuffixName, luaExtensionName) + txtExtensionName);

						if (File.Exists(path))
						{
							return File.ReadAllBytes(path);
						}
					}
					else
					{
						var path = Path.Combine(Application.dataPath, luaDir + filepath.Replace(dot, backSlash) + luaTxtExtensionName);

						if (File.Exists(path))
						{
							return File.ReadAllBytes(path);
						}
					}
				}
			}

			return null;
		}

		private static byte[] AssetBundleLoader(string filepath)
		{
			if (!string.IsNullOrWhiteSpace(filepath))
			{
				var splits = filepath.Split(dot);

				if (splits != null)
				{
					var l = splits.Length;

					if (filepath.EndsWith(luaExtensionName) && splits.Length > 2)
					{
						var textAsset = AssetBundles.Default.LoadAsset(AssetBundleHelper.BundleNameToLower($"{splits[0]}_lua.unity3d"), $"{splits[l - 2]}.{splits[l - 1]}");

						if (textAsset != null && textAsset is TextAsset)
						{
							return (textAsset as TextAsset).bytes;
						}
					}
					else if (splits.Length > 1)
					{
						var textAsset = AssetBundles.Default.LoadAsset(AssetBundleHelper.BundleNameToLower($"{splits[0]}_lua.unity3d"), $"{splits[l - 1]}{luaExtensionName}");

						if (textAsset != null && textAsset is TextAsset)
						{
							return (textAsset as TextAsset).bytes;
						}
					}
				}
			}

			return null;
		}

	}

	public class Lua : IDisposable
	{
		public static Lua Default
		{
			get
			{
				if (defaultLua == null)
				{
					defaultLua = new Lua();
				}

				return defaultLua;
			}
		}

		private static Lua defaultLua = null;

		public CSharpLuaClient LuaEnv
		{
			get
			{
				if(luaEnv == null)
				{
					luaEnv = GameObject.Find("Game").AddComponent<CSharpLuaClient>();
				}

				return luaEnv;
			}
		}

		private CSharpLuaClient luaEnv;

		public void Dispose()
		{
			UnityEngine.Object.Destroy(luaEnv);
			luaEnv = null;
		}
	}
	
	public static class LuaHelper
	{
		public static void StartHotfix()
		{
			Lua.Default.LuaEnv.Start();
		}
	}
}
