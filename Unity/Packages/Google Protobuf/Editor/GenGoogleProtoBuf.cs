using DCET.Runtime;
using UnityEditor;

namespace DCET.Editor
{
	[InitializeOnLoad]
	public class GenGoogleProtoBuf
	{
		public const string DllName = "Unity.ProtoBuf.Runtime";
		private const string DllDir = "./Packages/Google Protobuf/Runtime";
		private const string OutDirName = "Google Protobuf";

		static GenGoogleProtoBuf()
		{
			if (GenCoreHotfix.CopyDll(DllName) && Define.IsLua)
			{
				GenCoreHotfix.CompileLua(DllName, DllDir, OutDirName, null, true);
			}
		}
	}
}
