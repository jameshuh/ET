using System;
using UnityEngine;

namespace DCET.Model
{
	public static class ConfigHelper
	{
		public static string GetText(string key)
		{
			try
			{
				GameObject config = (GameObject)Game.Scene.GetComponent<ResourcesComponent>().GetAsset("config.unity3d", "Config");
				string configStr = config.Get<TextAsset>(key).text;
				return configStr;
			}
			catch (Exception e)
			{
				throw new Exception($"load config file fail, key: {key}", e);
			}
		}
		
		public static T ToObject<T>(string str)
		{
			return JsonHelper.FromJson<T>(str);
		}
	}
}