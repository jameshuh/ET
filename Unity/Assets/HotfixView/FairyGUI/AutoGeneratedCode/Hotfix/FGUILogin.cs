/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;

namespace ET
{
    [ObjectSystem]
    public class FGUILoginAwakeSystem : AwakeSystem<FGUILogin, GObject>
    {
        public override void Awake(FGUILogin self, GObject go)
        {
            self.Awake(go);
        }
    }

    public sealed class FGUILogin : FGUI
    {
        public const string UIPackageName = "Hotfix";
        public const string UIResName = "Login";

        /// <summary>
        /// Login的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
        public GComponent self;

        public GImage bg;
        public GImage contentBG;
        public GImage accountBg;
        public GTextInput accountInput;
        public GImage passwordBg;
        public GTextInput passwordInput;
        public FGUITitleButton loginButton;
        public GGroup content;

        public static FGUILogin CreateInstance(Scene domain)
        {
            return Create(domain, UIHelper.CreateGObject(domain,UIPackageName,UIResName));
        }

        public static async ETTask<FGUILogin> CreateInstanceAsync(Scene domain)
        {
            var go = await UIHelper.CreateGObjectAsync(domain,UIPackageName, UIResName);
            return Create(domain, go);
        }

        public static FGUILogin Create(Entity domain, GObject go)
        {
            return EntityFactory.Create<FGUILogin, GObject>(domain, go);
        }

        /// <summary>
        /// 通过此方法获取的FGUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
        /// </summary>
        public static FGUILogin GetFormPool(Entity domain, GObject go)
        {
            var fgui = go.Get<FGUILogin>();

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
                contentBG = (GImage)com.GetChild("contentBG");
                accountBg = (GImage)com.GetChild("accountBg");
                accountInput = (GTextInput)com.GetChild("accountInput");
                passwordBg = (GImage)com.GetChild("passwordBg");
                passwordInput = (GTextInput)com.GetChild("passwordInput");
                loginButton = FGUITitleButton.Create(domain, com.GetChild("loginButton"));
                content = (GGroup)com.GetChild("content");
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
            contentBG = null;
            accountBg = null;
            accountInput = null;
            passwordBg = null;
            passwordInput = null;
            loginButton.Dispose();
            loginButton = null;
            content = null;
        }

    }
}