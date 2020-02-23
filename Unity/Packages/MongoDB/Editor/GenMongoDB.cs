using DCET.Runtime;
using UnityEditor;

namespace DCET.Editor
{
	[InitializeOnLoad]
	public class GenMongoDB
	{
		public const string DllName = "Unity.MongoDB.Runtime";
		private const string DllDir = "./Packages/MongoDB/Runtime";
		private const string OutDirName = "MongoDB";

		static GenMongoDB()
		{
			if (GenCoreHotfix.CopyDll(DllName) && Define.IsLua)
			{
				GenCoreHotfix.CompileLua(DllName, DllDir, OutDirName, null, true);
			}
		}
	}
}
