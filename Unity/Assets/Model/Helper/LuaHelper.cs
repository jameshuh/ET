using System;
using UnityEngine;
using XLua;

namespace DCET.Model
{
	public static class LuaHelper
	{
		public const string XLua = "XLua";
		public const string CSharpLua = "CSharpLua";
		public const string Core = "Core";
		public const string Message = "Message";
		public const string Config = "Config";
		public const string BehaviorTree = "BehaviorTree";
		public const string FairyGUI = "FairyGUI";
		public const string Hotfix = "Hotfix";

		public static string XLuaAssetName = $"{XLua}_lua.unity3d";
		public static string CSharpLuaAssetName = $"{CSharpLua}_lua.unity3d";
		public static string CoreAssetName = $"{Core}_lua.unity3d";
		public static string MessageAssetName = $"{Message}_lua.unity3d";
		public static string ConfigAssetName = $"{Config}_lua.unity3d";
		public static string BehaviorTreeAssetName = $"{BehaviorTree}_lua.unity3d";
		public static string FairyGUIAssetName = $"{FairyGUI}_lua.unity3d";
		public static string HotfixAssetName = $"{Hotfix}_lua.unity3d";

		public const string manifestFileName = "manifest.lua";
		private const string luaExtensionName = ".lua";

		public static void StartHotfix()
		{
			var luaEnv = new LuaEnv();

			luaEnv.AddLoader(Loader);

			LoadLuaBundle(XLuaAssetName);
			LoadLuaBundle(CSharpLuaAssetName);
			LoadLuaBundle(CoreAssetName);
			LoadLuaBundle(MessageAssetName);
			LoadLuaBundle(ConfigAssetName);
			LoadLuaBundle(BehaviorTreeAssetName);
			LoadLuaBundle(FairyGUIAssetName);
			LoadLuaBundle(HotfixAssetName);

			luaEnv.DoString("require 'CSharpLua.Main.lua'");
		}

		private static byte[] Loader(ref string filepath)
		{
			if (!string.IsNullOrWhiteSpace(filepath))
			{
				var splits = filepath.Split('.');

				if(splits != null)
				{
					var l = splits.Length;

					if (filepath.EndsWith(luaExtensionName) && splits.Length > 2)
					{
						var textAsset = Game.Scene.GetComponent<ResourcesComponent>().GetAsset($"{splits[0]}_lua.unity3d", $"{splits[l - 2]}.{splits[l - 1]}");

						if (textAsset != null && textAsset is TextAsset)
						{
							filepath = filepath.Replace('.', '/').Replace("/lua", luaExtensionName);
							return (textAsset as TextAsset).bytes;
						}
					}
					else if(splits.Length > 1)
					{
						var textAsset = Game.Scene.GetComponent<ResourcesComponent>().GetAsset($"{splits[0]}_lua.unity3d", $"{splits[l - 1]}{luaExtensionName}");

						if (textAsset != null && textAsset is TextAsset)
						{
							filepath = filepath.Replace('.', '/') + luaExtensionName;
							return (textAsset as TextAsset).bytes;
						}
					}
				}
			}

			return null;
		}

		private static void LoadLuaBundle(string assetName)
		{
			Game.Scene.GetComponent<ResourcesComponent>().LoadBundle(assetName);
		}
	}
}
