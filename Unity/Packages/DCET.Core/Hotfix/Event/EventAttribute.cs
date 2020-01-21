using System;

namespace DCET.Hotfix
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public class EventAttribute: BaseAttribute
	{
		public string Type { get; }

		public EventAttribute(string type)
		{
			this.Type = type;
		}
	}
}