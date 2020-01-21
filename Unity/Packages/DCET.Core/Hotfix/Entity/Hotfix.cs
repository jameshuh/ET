using System;
using System.Collections.Generic;

namespace DCET.Hotfix
{
	public sealed class Hotfix : Object
	{
		public Action Update;
		public Action LateUpdate;
		public Action OnApplicationQuit;

		private List<Type> hotfixTypes = new List<Type>();

		public List<Type> GetHotfixTypes()
		{
			return hotfixTypes;
		}

		public void AddHotfixType(Type type)
		{
			if (type != null && !hotfixTypes.Contains(type))
			{
				hotfixTypes.Add(type);
			}
		}
	}
}