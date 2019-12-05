using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace DCET.Editor
{
	public static class GenConfig
	{
		public static List<string> assemblyNames = new List<string>()
		{
			"Unity.BehaviorDesigner.Runtime.dll",
			"Unity.DCET.AssetsBundle.Runtime.dll",
			"Unity.DCET.Config.Runtime.dll",
			"Unity.DCET.Core.Runtime.dll",
			"Unity.DCET.CoroutineLock.Runtime.dll",
			"Unity.DCET.FairyGUI.Runtime.dll",
			"Unity.DCET.Message.Runtime.dll",
			"Unity.DCET.Model.dll",
			"Unity.DCET.Numeric.Runtime.dll",
			"Unity.DCET.Pathfinding.Runtime.dll",
			"Unity.DCET.Tool.Runtime.dll",
			"Unity.FairyGUI.Runtime.dll",
			"Unity.LitJson.Runtime.dll",
			"Unity.MongoDB.Runtime.dll",
			"Unity.ProtoBuf.Runtime.dll",
		};

		[LuaCallCSharp]
		public static List<Type> assemblyTypes
		{
			get
			{
				var assemblys = AppDomain.CurrentDomain.GetAssemblies();
				var list = new List<Type>();

				if (assemblys != null)
				{
					foreach (var assembly in assemblys)
					{
						if (assembly == null || assembly.ManifestModule == null)
						{
							continue;
						}

						if (string.IsNullOrWhiteSpace(assembly.ManifestModule.Name))
						{
							continue;
						}

						if (assemblyNames.Contains(assembly.ManifestModule.Name))
						{
							var types = assembly.GetTypes();

							if (types != null)
							{
								foreach (var item in types)
								{
									if (!list.Contains(item))
									{
										list.Add(item);
									}
								}
							}
						}
					}
				}

				return list;
			}
		}

		//lua中要使用到C#库的配置，比如C#标准库，或者Unity API，第三方库等。
		[LuaCallCSharp]
		public static List<Type> LuaCallCSharp = new List<Type>() {
				typeof(System.Object),
				typeof(UnityEngine.Object),
				typeof(Vector2),
				typeof(Vector3),
				typeof(Vector4),
				typeof(Quaternion),
				typeof(Color),
				typeof(Ray),
				typeof(Bounds),
				typeof(Ray2D),
				typeof(Time),
				typeof(GameObject),
				typeof(Component),
				typeof(Behaviour),
				typeof(Transform),
				typeof(Resources),
				typeof(TextAsset),
				typeof(Keyframe),
				typeof(AnimationCurve),
				typeof(AnimationClip),
				typeof(MonoBehaviour),
				typeof(ParticleSystem),
				typeof(SkinnedMeshRenderer),
				typeof(Renderer),
				typeof(Light),
				typeof(Mathf),
				typeof(List<int>),
				typeof(Action<string>),
				typeof(Debug),
				typeof(Model.MultiMapSet<string, string>)
			};

		//C#静态调用Lua的配置（包括事件的原型），仅可以配delegate，interface
		[CSharpCallLua]
		public static List<Type> CSharpCallLua = new List<Type>() {
				typeof(Action),
				typeof(Func<double, double, double>),
				typeof(Action<string>),
				typeof(Action<double>),
				typeof(UnityEngine.Events.UnityAction),
				typeof(System.Collections.IEnumerator)
			};

		//黑名单
		[BlackList]
		public static List<List<string>> BlackList = new List<List<string>>()  {
				new List<string>(){"System.Xml.XmlNodeList", "ItemOf"},
				new List<string>(){"UnityEngine.WWW", "movie"},
    #if UNITY_WEBGL
                new List<string>(){"UnityEngine.WWW", "threadPriority"},
    #endif
                new List<string>(){"UnityEngine.Texture2D", "alphaIsTransparency"},
				new List<string>(){"UnityEngine.Security", "GetChainOfTrustValue"},
				new List<string>(){"UnityEngine.CanvasRenderer", "onRequestRebuild"},
				new List<string>(){"UnityEngine.Light", "areaSize"},
				new List<string>(){"UnityEngine.Light", "lightmapBakeType"},
				new List<string>(){"UnityEngine.WWW", "MovieTexture"},
				new List<string>(){"UnityEngine.WWW", "GetMovieTexture"},
				new List<string>(){"UnityEngine.AnimatorOverrideController", "PerformOverrideClipListCleanup"},
    #if !UNITY_WEBPLAYER
                new List<string>(){"UnityEngine.Application", "ExternalEval"},
    #endif
                new List<string>(){"UnityEngine.GameObject", "networkView"}, //4.6.2 not support
                new List<string>(){"UnityEngine.Component", "networkView"},  //4.6.2 not support
                new List<string>(){"System.IO.FileInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
				new List<string>(){"System.IO.FileInfo", "SetAccessControl", "System.Security.AccessControl.FileSecurity"},
				new List<string>(){"System.IO.DirectoryInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
				new List<string>(){"System.IO.DirectoryInfo", "SetAccessControl", "System.Security.AccessControl.DirectorySecurity"},
				new List<string>(){"System.IO.DirectoryInfo", "CreateSubdirectory", "System.String", "System.Security.AccessControl.DirectorySecurity"},
				new List<string>(){"System.IO.DirectoryInfo", "Create", "System.Security.AccessControl.DirectorySecurity"},
				new List<string>(){"UnityEngine.MonoBehaviour", "runInEditMode"},
			};
	}
}
