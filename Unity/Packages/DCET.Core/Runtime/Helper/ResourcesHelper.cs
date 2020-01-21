using UnityEngine;

namespace DCET.Model
{
	public static class ResourcesHelper
	{
		public static Object Load(string path)
		{
			return Resources.Load(path);
		}
	}
}
