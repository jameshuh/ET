using System;

namespace DCET.Model
{
	[AttributeUsage(AttributeTargets.Class)]
	public class ConfigAttribute: BaseAttribute
	{
		public AppType Type { get; }

		public ConfigAttribute(int type)
		{
			this.Type = (AppType)type;
		}
	}
}