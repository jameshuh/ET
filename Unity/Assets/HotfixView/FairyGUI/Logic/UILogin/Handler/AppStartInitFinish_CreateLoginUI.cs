

namespace ET
{
	public class AppStartInitFinish_RemoveLoginUI: AEvent<EventType.AppStartInitFinish>
	{
		protected override async ETTask Run(EventType.AppStartInitFinish args)
		{
            var fui = await FGUILogin.CreateInstanceAsync(args.ZoneScene);

            //默认将会以Id为Name，也可以自定义Name，方便查询和管理
            fui.Name = FGUILogin.UIResName;
            fui.MakeFullScreen();
            fui.AddComponent<FGUILoginComponent>();

			args.ZoneScene.GetComponent<FGUIComponent>().Add(fui);
			//await UIHelper.Create(args.ZoneScene, UIType.UILogin);
		}
	}
}
