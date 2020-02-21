using System.Text;

namespace DCET.Runtime
{
	public static class StringHelper
	{
		public static byte[] ToByteArray(this string str)
		{
			return Encoding.Default.GetBytes(str);
		}
	}
}
