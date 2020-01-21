using System;

namespace DCET.Hotfix
{
	public static class Log
	{
		public static void Warning(string msg)
		{
			Model.Log.Warning(msg);
		}

		public static void Info(string msg)
		{
			Model.Log.Info(msg);
		}

		public static void Error(Exception e)
		{
			Model.Log.Error(e.ToStr());
		}

		public static void Error(string msg)
		{
			Model.Log.Error(msg);
		}

		public static void Debug(string msg)
		{
			Model.Log.Debug(msg);
		}

		public static void Msg(object msg)
		{
			Debug(Dumper.DumpAsString(msg));
		}
	}
}