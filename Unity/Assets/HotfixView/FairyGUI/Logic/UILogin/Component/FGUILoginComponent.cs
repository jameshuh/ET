namespace ET
{
	[ObjectSystem]
	public class FGUILoginComponentAwakeSystem : AwakeSystem<FGUILoginComponent>
	{
		public override void Awake(FGUILoginComponent self)
		{
			self.Awake();
		}
	}

	public class FGUILoginComponent : Entity
	{
		private FGUILogin fuiLogin;

		public void Awake()
		{
			fuiLogin = GetParent<FGUILogin>();
			fuiLogin.loginButton.self.onClick.Set(OnClickLogin);
		}

		public override void Dispose()
		{
			if (IsDisposed)
			{
				return;
			}

			base.Dispose();

			fuiLogin.loginButton.self.onClick.Clear();
		}

		public void OnClickLogin()
		{
			LoginHelper.Login(fuiLogin.DomainScene(), "127.0.0.1:10002", fuiLogin.accountInput.text).Coroutine();
			//LoginHelper.OnLoginAsync(fuiLogin.accountInput.text);
        }
    }
}
