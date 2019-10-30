using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using CommandLine;
using NLog;

namespace ETModel
{
	internal static class Program
	{
		private static void Main(string[] args)
		{
			// 异步方法全部会回掉到主线程
			SynchronizationContext.SetSynchronizationContext(OneThreadSynchronizationContext.Instance);
			
			try
			{		
				Game.EventSystem.Add(DLLType.Model, typeof(Game).Assembly);
				Game.EventSystem.Add(DLLType.Hotfix, DllHelper.GetHotfixAssembly());
				
				MongoHelper.Init();
				
				// 命令行参数
				Parser.Default.ParseArguments<Options>(args)
						.WithNotParsed(error => throw new Exception($"命令行格式错误!"))
						.WithParsed(o => { Game.Options = o; });

				IdGenerater.AppId = Game.Options.Id;
				
				// 启动配置
				StartConfig allConfig = MongoHelper.FromJson<StartConfig>(File.ReadAllText(Path.Combine("../Config/StartConfig/", Game.Options.Config)));

				StartConfig startConfig = allConfig.Get(Game.Options.Id);
				Game.Scene = EntityFactory.CreateScene(0, "Process", SceneType.Process);
				
				LogManager.Configuration.Variables["appIdFormat"] = $"{Game.Scene.Id:0000}";
				
				Game.Scene.AddComponent<StartConfigComponent, StartConfig, long>(allConfig, startConfig.Id);

				Log.Info($"server start........................ {Game.Scene.Id}");

				Game.Scene.AddComponent<TimerComponent>();
				Game.Scene.AddComponent<OpcodeTypeComponent>();
				Game.Scene.AddComponent<MessageDispatcherComponent>();
				Game.Scene.AddComponent<ConfigComponent>();
				Game.Scene.AddComponent<CoroutineLockComponent>();
				// 发送普通actor消息
				Game.Scene.AddComponent<ActorMessageSenderComponent>();
				// 发送location actor消息
				Game.Scene.AddComponent<ActorLocationSenderComponent>();
				// 访问location server的组件
				Game.Scene.AddComponent<LocationProxyComponent>();
				Game.Scene.AddComponent<ActorMessageDispatcherComponent>();
				// 数值订阅组件
				Game.Scene.AddComponent<NumericWatcherComponent>();
				// 控制台组件
				Game.Scene.AddComponent<ConsoleComponent>();


                OuterConfig outerConfig = startConfig.GetComponent<OuterConfig>();
				if (outerConfig != null)
				{
					// 外网消息组件
					Game.Scene.AddComponent<NetOuterComponent, string>(outerConfig.Address);
				}
				
				InnerConfig innerConfig = startConfig.GetComponent<InnerConfig>();
				if (innerConfig != null)
				{
<<<<<<< HEAD
					case AppType.Manager:
						Game.Scene.AddComponent<AppManagerComponent>();
						Game.Scene.AddComponent<NetInnerComponent, string>(innerConfig.Address);
						Game.Scene.AddComponent<NetOuterComponent, string>(outerConfig.Address);
						break;
					case AppType.Realm:
						Game.Scene.AddComponent<MailboxDispatcherComponent>();
						Game.Scene.AddComponent<ActorMessageDispatcherComponent>();
						Game.Scene.AddComponent<NetInnerComponent, string>(innerConfig.Address);
						Game.Scene.AddComponent<NetOuterComponent, string>(outerConfig.Address);
						Game.Scene.AddComponent<LocationProxyComponent>();
						Game.Scene.AddComponent<RealmGateAddressComponent>();
						break;
					case AppType.Gate:
						Game.Scene.AddComponent<PlayerComponent>();
						Game.Scene.AddComponent<MailboxDispatcherComponent>();
						Game.Scene.AddComponent<ActorMessageDispatcherComponent>();
						Game.Scene.AddComponent<NetInnerComponent, string>(innerConfig.Address);
						Game.Scene.AddComponent<NetOuterComponent, string>(outerConfig.Address);
						Game.Scene.AddComponent<LocationProxyComponent>();
						Game.Scene.AddComponent<ActorMessageSenderComponent>();
						Game.Scene.AddComponent<ActorLocationSenderComponent>();
						Game.Scene.AddComponent<GateSessionKeyComponent>();
						break;
					case AppType.Location:
						Game.Scene.AddComponent<NetInnerComponent, string>(innerConfig.Address);
						Game.Scene.AddComponent<LocationComponent>();
						break;
					case AppType.Map:
						Game.Scene.AddComponent<NetInnerComponent, string>(innerConfig.Address);
						Game.Scene.AddComponent<UnitComponent>();
						Game.Scene.AddComponent<LocationProxyComponent>();
						Game.Scene.AddComponent<ActorMessageSenderComponent>();
						Game.Scene.AddComponent<ActorLocationSenderComponent>();
						Game.Scene.AddComponent<MailboxDispatcherComponent>();
						Game.Scene.AddComponent<ActorMessageDispatcherComponent>();
						Game.Scene.AddComponent<PathfindingComponent>();
						break;
					case AppType.AllServer:
						// 发送普通actor消息
						Game.Scene.AddComponent<ActorMessageSenderComponent>();
						
						// 发送location actor消息
						Game.Scene.AddComponent<ActorLocationSenderComponent>();
						
						//Game.Scene.AddComponent<DBComponent>();
						//Game.Scene.AddComponent<DBProxyComponent>();
						
						// location server需要的组件
						Game.Scene.AddComponent<LocationComponent>();
						
						// 访问location server的组件
						Game.Scene.AddComponent<LocationProxyComponent>();
						
						// 这两个组件是处理actor消息使用的
						Game.Scene.AddComponent<MailboxDispatcherComponent>();
						Game.Scene.AddComponent<ActorMessageDispatcherComponent>();
						
						// 内网消息组件
						Game.Scene.AddComponent<NetInnerComponent, string>(innerConfig.Address);
						
						// 外网消息组件
						Game.Scene.AddComponent<NetOuterComponent, string>(outerConfig.Address);
						
						// manager server组件，用来管理其它进程使用
						Game.Scene.AddComponent<AppManagerComponent>();
						Game.Scene.AddComponent<RealmGateAddressComponent>();
						Game.Scene.AddComponent<GateSessionKeyComponent>();
						
						// 配置管理
						Game.Scene.AddComponent<ConfigComponent>();

                        // 行为树Demo
                        Game.Scene.AddComponent<BehaviorManagerComponent>();
                        Game.Scene.AddComponent<BehaviorTreeVariableComponent>();
						Game.EventSystem.Run(EventIdType.TestBehavior, "Demo");

                        // recast寻路组件
                        Game.Scene.AddComponent<PathfindingComponent>();
						
						Game.Scene.AddComponent<PlayerComponent>();
						Game.Scene.AddComponent<UnitComponent>();

						Game.Scene.AddComponent<ConsoleComponent>();
                        // Game.Scene.AddComponent<HttpComponent>();
						break;
					case AppType.Benchmark:
						Game.Scene.AddComponent<NetOuterComponent>();
						Game.Scene.AddComponent<BenchmarkComponent, string>(clientConfig.Address);
						break;
					case AppType.BenchmarkWebsocketServer:
						Game.Scene.AddComponent<NetOuterComponent, string>(outerConfig.Address);
						break;
					case AppType.BenchmarkWebsocketClient:
						Game.Scene.AddComponent<NetOuterComponent>();
						Game.Scene.AddComponent<WebSocketBenchmarkComponent, string>(clientConfig.Address);
						break;
					default:
						throw new Exception($"命令行参数没有设置正确的AppType: {startConfig.AppType}");
=======
					// 内网消息组件
					Game.Scene.AddComponent<NetInnerComponent, string>(innerConfig.Address);
				}

				DBConfig dbConfig = startConfig.GetComponent<DBConfig>();
				if (dbConfig != null)
				{
					Game.Scene.AddComponent<DBComponent, DBConfig>(dbConfig);
>>>>>>> eec84eba36304f1236eac278a21297ade88df465
				}
				
				// 先加这里，后面删掉
				Game.EventSystem.Run(EventIdType.AfterScenesAdd);
				
				while (true)
				{
					try
					{
						Thread.Sleep(1);
						OneThreadSynchronizationContext.Instance.Update();
						Game.EventSystem.Update();
					}
					catch (Exception e)
					{
						Log.Error(e);
					}
				}
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}
	}
}
