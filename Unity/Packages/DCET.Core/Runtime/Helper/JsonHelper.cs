using LitJson;

namespace DCET.Runtime
{
	public static class JsonHelper
	{
		public static string ToJson(object obj)
		{
			return JsonMapper.ToJson(obj);
		}

		public static T FromJson<T>(string str)
		{
			T t = JsonMapper.ToObject<T>(str);

			return t;
		}
	}
}