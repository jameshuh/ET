namespace ET
{
	[ObjectSystem]
	public class FUILobbyComponentAwakeSystem : AwakeSystem<FUILobbyComponent>
	{
		public override void Awake(FUILobbyComponent self)
		{
			self.Awake();
		}
	}

	public class FUILobbyComponent : Entity
	{
		private FGUILobby fuiLobby;

		public void Awake()
		{
			fuiLobby = GetParent<FGUILobby>();
			fuiLobby.enterButton.self.onClick.Set(OnClickEnter);
		}

		public void OnClickEnter()
		{
			MapHelper.EnterMapAsync(fuiLobby.ZoneScene(), "Map").Coroutine();
		}
	}
}
