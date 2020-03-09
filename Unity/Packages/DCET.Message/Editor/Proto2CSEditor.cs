using DCETRuntime;
using System.Diagnostics;
using UnityEditor;

namespace DCETEditor
{
	internal class OpcodeInfo
	{
		public string Name;
		public int Opcode;
	}

	public class Proto2CSEditor : EditorWindow
	{
		[MenuItem("Tools/Gen Proto")]
		public static void AllProto2CS()
		{
			ProcessHelper.Run("dotnet", "Proto2CS.dll", "../Proto/", false);
			ProcessHelper.Run("protogen.bat", null, "../Proto/", false);
			AssetDatabase.Refresh();
		}
	}
}
