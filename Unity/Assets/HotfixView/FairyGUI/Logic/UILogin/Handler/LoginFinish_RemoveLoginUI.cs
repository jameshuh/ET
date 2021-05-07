

namespace ET
{
	public class LoginFinish_RemoveLoginUI: AEvent<EventType.LoginFinish>
	{
		protected override async ETTask Run(EventType.LoginFinish args)
		{

			args.ZoneScene.GetComponent<FGUIComponent>().Remove(FGUILogin.UIResName);
			await ETTask.CompletedTask;
			//await UIHelper.Remove(args.ZoneScene, UIType.UILogin);
		}
	}
}
