namespace DCET
{
	[ObjectSystem]
	public class FUILoginComponentAwakeSystem : AwakeSystem<FUILoginComponent>
	{
		public override void Awake(FUILoginComponent self)
		{
			self.Awake();
		}
	}

	public class FUILoginComponent : Entity
	{
		private FUILogin fuiLogin;

		public void Awake()
		{
			fuiLogin = GetParent<FUILogin>();
			fuiLogin.loginButton.self.onClick.Set(OnClickLogin);
		}

		public void OnClickLogin()
		{
			LoginHelper.OnLoginAsync(fuiLogin.accountInput.text);
		}
	}
}
