/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;

namespace ET
{
    [ObjectSystem]
    public class FGUITitleButtonAwakeSystem : AwakeSystem<FGUITitleButton, GObject>
    {
        public override void Awake(FGUITitleButton self, GObject go)
        {
            self.Awake(go);
        }
    }

    public sealed class FGUITitleButton : FGUI
    {
        public const string UIPackageName = "Hotfix";
        public const string UIResName = "TitleButton";

        /// <summary>
        /// TitleButton的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
        public GButton self;

        public GImage bg;

        public static FGUITitleButton CreateInstance(Scene domain)
        {
            return Create(domain, UIHelper.CreateGObject(domain,UIPackageName,UIResName));
        }

        public static async ETTask<FGUITitleButton> CreateInstanceAsync(Scene domain)
        {
            var go = await UIHelper.CreateGObjectAsync(domain,UIPackageName, UIResName);
            return Create(domain, go);
        }

        public static FGUITitleButton Create(Entity domain, GObject go)
        {
            return EntityFactory.Create<FGUITitleButton, GObject>(domain, go);
        }

        /// <summary>
        /// 通过此方法获取的FGUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
        /// </summary>
        public static FGUITitleButton GetFormPool(Entity domain, GObject go)
        {
            var fgui = go.Get<FGUITitleButton>();

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

            self = (GButton)go;

            self.Add(this);

            var com = go.asCom;

            if(com != null)
            {
                bg = (GImage)com.GetChild("bg");
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
        }

    }
}