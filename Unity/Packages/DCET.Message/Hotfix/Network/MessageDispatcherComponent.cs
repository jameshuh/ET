using DCET.Model;
using System;
using System.Collections.Generic;

namespace DCET.Hotfix
{
	[ObjectSystem]
	public class MessageDispatcherComponentAwakeSystem : AwakeSystem<MessageDispatcherComponent>
	{
		public override void Awake(MessageDispatcherComponent self)
		{
			self.Awake();
		}
	}

	[ObjectSystem]
	public class MessageDispatcherComponentLoadSystem : LoadSystem<MessageDispatcherComponent>
	{
		public override void Load(MessageDispatcherComponent self)
		{
			self.Load();
		}
	}

	/// <summary>
	/// 消息分发组件
	/// </summary>
	public class MessageDispatcherComponent : Entity
	{
		private readonly Dictionary<ushort, List<IMHandler>> handlers = new Dictionary<ushort, List<IMHandler>>();

		public void Awake()
		{
			this.Load();
		}

		public void Load()
		{
			this.handlers.Clear();

			Model.MessageDispatcherComponent messageDispatcherComponent = Model.Game.Scene.GetComponent<Model.MessageDispatcherComponent>();
			Model.OpcodeTypeComponent opcodeTypeComponent = Model.Game.Scene.GetComponent<Model.OpcodeTypeComponent>();

			List<Type> types = Game.EventSystem.GetTypes();

			foreach (Type type in types)
			{
				object[] attrs = type.GetCustomAttributes(typeof(MessageHandlerAttribute), false);
				if (attrs.Length == 0)
				{
					continue;
				}

				IMHandler iMHandler = Activator.CreateInstance(type) as IMHandler;
				if (iMHandler == null)
				{
					Log.Error($"message handle {type.Name} 需要继承 IMHandler");
					continue;
				}
				
				Type messageType = iMHandler.GetMessageType();
				ushort opcode = this.Parent.GetComponent<OpcodeTypeComponent>().GetOpcode(messageType);
				if (opcode != 0)
				{
					this.RegisterHandler(opcode, iMHandler);
				}

				// 尝试注册到mono层
				if (messageDispatcherComponent != null && opcodeTypeComponent != null)
				{
					ushort monoOpcode = opcodeTypeComponent.GetOpcode(messageType);
					if (monoOpcode == 0)
					{
						continue;
					}

					MessageProxy messageProxy = new MessageProxy(messageType, (session, o) => { iMHandler.Handle(session, o); });
					messageDispatcherComponent.RegisterHandler(monoOpcode, messageProxy);
				}
			}
		}

		public void RegisterHandler(ushort opcode, IMHandler handler)
		{
			if (!this.handlers.ContainsKey(opcode))
			{
				this.handlers.Add(opcode, new List<IMHandler>());
			}
			this.handlers[opcode].Add(handler);
		}

		public void Handle(Model.Session session, MessageInfo messageInfo)
		{
			List<IMHandler> actions;
			if (!this.handlers.TryGetValue(messageInfo.Opcode, out actions))
			{
				Log.Error($"消息 {messageInfo.Message.GetType().FullName} 没有处理");
				return;
			}
			
			foreach (IMHandler ev in actions)
			{
				try
				{
					ev.Handle(session, messageInfo.Message);
				}
				catch (Exception e)
				{
					Log.Error(e);
				}
			}
		}

		public override void Dispose()
		{
			if (this.IsDisposed)
			{
				return;
			}

			base.Dispose();
		}
	}
}