using System;
using UnityEngine;

namespace DCETRuntime
{
	public static class GameObjectHelper
	{
		public static object Get(this GameObject gameObject, string key)
		{
			try
			{
				return gameObject.GetComponent<ReferenceCollector>().GetObject(key);
			}
			catch (Exception e)
			{
				throw new Exception($"获取{gameObject.name}的ReferenceCollector key失败, key: {key}", e);
			}
		}

		public static TextAsset GetTextAsset(this GameObject gameObject, string key)
		{
			var obj = gameObject.Get(key);

			if (obj is TextAsset)
			{
				return obj as TextAsset;
			}

			return null;
		}

		public static GameObject GetGameObject(this GameObject gameObject, string key)
		{
			var obj = gameObject.Get(key);

			if (obj is GameObject)
			{
				return obj as GameObject;
			}

			return null;
		}

		public static Component Ensure(this GameObject gameObject, Type component)
		{
			if (gameObject && component != null && component.IsSubclassOf(typeof(Component)))
			{
				var t = gameObject.GetComponent(component);

				if (!t)
				{
					t = gameObject.AddComponent(component);
				}

				return t;
			}

			return null;
		}
	}
}