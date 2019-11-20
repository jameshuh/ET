using DCET.Hotfix.Common;
using DCET.Model;

namespace DCET.Hotfix
{
    [Event(EventIdType.InitSceneStart)]
	public class InitSceneStart_CreateLoadingUI : AEvent
	{
        public override void Run()
        {
            var fui = Common.FUILoading.CreateInstance(Game.Scene);

            //默认将会以Id为Name，也可以自定义Name，方便查询和管理
            fui.Name = Common.FUILoading.UIResName;

            fui.MakeFullScreen();
            Game.Scene.GetComponent<FUIComponent>().Add(fui, true);
        }
    }
}