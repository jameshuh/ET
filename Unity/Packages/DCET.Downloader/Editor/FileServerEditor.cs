using DCET.Runtime;
using UnityEditor;

namespace DCET.Editor
{
	public static class FileServerEditor
	{

		[MenuItem("Tools/web资源服务器")]
		public static void OpenFileServer()
		{
			ProcessHelper.Run("dotnet", "FileServer.dll", "../FileServer/");
		}
	}
}
