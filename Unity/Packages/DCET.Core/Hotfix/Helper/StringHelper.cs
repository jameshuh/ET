using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DCET.Hotfix
{
	public static class StringHelper
	{
		public static string MessageToStr(object message)
		{
#if SERVER
			return MongoHelper.ToJson(message);
#else
			return Dumper.DumpAsString(message);
#endif
		}
	}
}