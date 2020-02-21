using System.Text;

namespace DCET.Runtime
{
	public static class ByteHelper
	{
		public static string ToHex(this byte[] bytes, string format)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in bytes)
			{
				stringBuilder.Append(b.ToString(format));
			}
			return stringBuilder.ToString();
		}
	}
}
