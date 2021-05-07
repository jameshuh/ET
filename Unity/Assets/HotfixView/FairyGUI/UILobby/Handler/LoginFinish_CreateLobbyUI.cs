

namespace ET
{
	public class LoginFinish_CreateLobbyUI: AEvent<EventType.LoginFinish>
	{
		protected override async ETTask Run(EventType.LoginFinish args)
		{
            var fui = await FGUILobby.CreateInstanceAsync(args.ZoneScene);

            //默认将会以Id为Name，也可以自定义Name，方便查询和管理
            fui.Name = FGUILobby.UIResName;
            fui.MakeFullScreen();
            fui.AddComponent<FUILobbyComponent>();
            args.ZoneScene.GetComponent<FGUIComponent>().Add(fui);
        }
	}
}
