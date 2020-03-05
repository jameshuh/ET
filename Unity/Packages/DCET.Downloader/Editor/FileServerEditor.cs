using DCET.Runtime;
using UnityEditor;

namespace DCET.Editor
{
	public static class FileServerEditor
	{

		[MenuItem("Tools/Start Asset Server")]
		public static void OpenFileServer()
		{
			ProcessHelper.Run("dotnet", "FileServer.dll", "../FileServer/");
		}
	}
}
