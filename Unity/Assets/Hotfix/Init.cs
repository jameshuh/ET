using BehaviorDesigner.Runtime;
using DCET.Model;
using System;

namespace DCET.Hotfix
{
	public static class Init
	{
		public async static void Start()
		{
			try
			{
				// 注册热更层回调
				//Model.Game.Hotfix.Update = () => { Update(); };
				//Model.Game.Hotfix.LateUpdate = () => { LateUpdate(); };
				//Model.Game.Hotfix.OnApplicationQuit = () => { OnApplicationQuit(); };

				Game.Scene.AddComponent<OpcodeTypeComponent>();
				Game.Scene.AddComponent<MessageDispatcherComponent>();

				// 加载热更配置
				//Model.Game.Scene.GetComponent<ResourcesComponent>().LoadBundle("config.unity3d");
				Game.Scene.AddComponent<ConfigComponent>();
				//Model.Game.Scene.GetComponent<ResourcesComponent>().UnloadBundle("config.unity3d");

				// 演示行为树用法
				TestBehaviorTree();

				// 演示FGUI用法
				Game.Scene.AddComponent<FUIComponent>();
				await Game.Scene.AddComponent<FUIInitComponent>().Init();
				Game.EventSystem.Run(EventIdType.InitSceneStart);
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		/// <summary>
		/// 演示行为树用法，使用时可以删除
		/// </summary>
		private static void TestBehaviorTree()
		{
			// 全局共享变量用法
			Game.Scene.AddComponent<BehaviorTreeVariableComponent>().SetVariable("全局变量", 1);

			var runtimeBehaivorTree = UnityEngine.GameObject.Find("Cube").GetComponent<BehaviorDesigner.Runtime.BehaviorTree>();

			if (runtimeBehaivorTree)
			{
				//建议在资源预加载时进行初始化，以免游戏对局中反序列化GC卡顿
				BehaviorTreeHelper.Init(runtimeBehaivorTree.gameObject);

				//动态加载外部行为树用法
				//UnityEngine.Object externalBehavior = 加载("外部行为树资源");
				//BehaviorTreeHelper.Init(externalBehavior);
				//runtimeBehaivorTree.Ensure<BehaviorTreeController>().SetExternalBehavior(externalBehavior);

				runtimeBehaivorTree.Ensure<BehaviorTreeController>().Init();
			}

			var behaviorTree = BehaviorTreeFactory.Create(Game.Scene, runtimeBehaivorTree);

			// 新增行为树共享变量用法
			var p1 = behaviorTree.GetComponent<BehaviorTreeVariableComponent>().GetVariable<int>("变量1");

			Log.Info($"行为树变量：{p1}");

			behaviorTree.GetComponent<BehaviorTreeVariableComponent>().SetVariable("变量1", 2);

			p1 = behaviorTree.GetComponent<BehaviorTreeVariableComponent>().GetVariable<int>("变量1");

			Log.Info($"行为树变量：{p1}");

			behaviorTree.GetComponent<BehaviorTreeVariableComponent>().SetVariable("变量2", "");
			behaviorTree.GetComponent<BehaviorTreeVariableComponent>().SetVariable("变量3", behaviorTree);
			behaviorTree.GetComponent<BehaviorTreeVariableComponent>().SetVariable("变量4", runtimeBehaivorTree);
		}

		public static void Update()
		{
			try
			{
				Game.EventSystem.Update();
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		public static void LateUpdate()
		{
			try
			{
				Game.EventSystem.LateUpdate();
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		public static void OnApplicationQuit()
		{
			Game.Close();
		}
	}
}