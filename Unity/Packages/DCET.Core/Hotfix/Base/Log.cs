using System;

namespace DCET.Hotfix
{
	public static class Log
	{
		public static void Trace(string msg)
		{
			Model.Log.Trace(msg);
		}
		
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
		
		public static void Trace(string message, params object[] args)
		{
			Model.Log.Trace(message, args);
		}

		public static void Warning(string message, params object[] args)
		{
			Model.Log.Warning(message, args);
		}

		public static void Info(string message, params object[] args)
		{
			Model.Log.Info(message, args);
		}

		public static void Debug(string message, params object[] args)
		{
			Model.Log.Debug(message, args);
		}

		public static void Error(string message, params object[] args)
		{
			Model.Log.Error(message, args);
		}

		public static void Fatal(string message, params object[] args)
		{
			Model.Log.Fatal(message, args);
		}
		
		public static void Msg(object msg)
		{
			Debug(Dumper.DumpAsString(msg));
		}
	}
}