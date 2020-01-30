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