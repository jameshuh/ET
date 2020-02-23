namespace DCET
{
	[ObjectSystem]
	public class SessionComponentAwakeSystem : AwakeSystem<SessionComponent>
	{
		public override void Awake(SessionComponent self)
		{
			self.Awake();
		}
	}

	public class SessionComponent: Entity
	{
		public static SessionComponent Instance;

		private Session session;

		public Session Session
		{
			get
			{
				return this.session;
			}
			set
			{
				if(this.session != null && !this.session.IsDisposed)
				{
					this.session.Dispose();
				}

				this.session = value;
			}
		}

		public void Awake()
		{
			Instance = this;
		}

		public override void Dispose()
		{
			if (this.IsDisposed)
			{
				return;
			}

			base.Dispose();

			this.Session.Dispose();
			this.Session = null;
			Instance = null;
		}
	}
}
