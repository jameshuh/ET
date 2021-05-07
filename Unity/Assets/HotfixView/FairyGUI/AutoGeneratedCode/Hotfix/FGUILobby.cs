/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;

namespace ET
{
    [ObjectSystem]
    public class FGUILobbyAwakeSystem : AwakeSystem<FGUILobby, GObject>
    {
        public override void Awake(FGUILobby self, GObject go)
        {
            self.Awake(go);
        }
    }

    public sealed class FGUILobby : FGUI
    {
        public const string UIPackageName = "Hotfix";
        public const string UIResName = "Lobby";

        /// <summary>
        /// Lobby的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
        public GComponent self;

        public GImage bg;
        public FGUITitleButton enterButton;

        public static FGUILobby CreateInstance(Scene domain)
        {
            return Create(domain, UIHelper.CreateGObject(domain,UIPackageName,UIResName));
        }

        public static async ETTask<FGUILobby> CreateInstanceAsync(Scene domain)
        {
            var go = await UIHelper.CreateGObjectAsync(domain,UIPackageName, UIResName);
            return Create(domain, go);
        }

        public static FGUILobby Create(Entity domain, GObject go)
        {
            return EntityFactory.Create<FGUILobby, GObject>(domain, go);
        }

        /// <summary>
        /// 通过此方法获取的FGUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
        /// </summary>
        public static FGUILobby GetFormPool(Entity domain, GObject go)
        {
            var fgui = go.Get<FGUILobby>();

            if(fgui == null)
            {
                fgui = Create(domain, go);
            }

            fgui.isFromFGUIPool = true;

            return fgui;
        }

        public void Awake(GObject go)
        {
            if(go == null)
            {
                return;
            }

            GObject = go;   

            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = Id.ToString();
            }

            self = (GComponent)go;

            self.Add(this);

            var com = go.asCom;

            if(com != null)
            {
                bg = (GImage)com.GetChild("bg");
                enterButton = FGUITitleButton.Create(domain, com.GetChild("enterButton"));
            }
        }

        public override void Dispose()
        {
            if(IsDisposed)
            {
                return;
            }

            base.Dispose();

            self.Remove();
            self = null;
            bg = null;
            enterButton.Dispose();
            enterButton = null;
        }

    }
}