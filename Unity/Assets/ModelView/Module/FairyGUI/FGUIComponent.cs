#if FAIRYGUI
using FairyGUI;

namespace ET
{
	[ObjectSystem]
	public class FGUIComponentAwakeSystem : AwakeSystem<FGUIComponent, Scene>
	{
		public override void Awake(FGUIComponent self,Scene scene)
		{
			self.Root = EntityFactory.Create<FGUI, GObject>(scene, GRoot.inst);
			self.Awake(scene);
		}
	}

    /// <summary>
    /// 管理所有顶层UI, 顶层UI都是GRoot的孩子
    /// </summary>
    public class FGUIComponent: Entity
	{
		public FGUI Root;

        public void Awake(Scene scene)
        {
            for (int i = 0; i < (int)UILayer.All; i++)
            {
				GComponent com = new GComponent();
				com.name = ((UILayer)i).ToString();
				com.SetSize(GRoot.inst.width, GRoot.inst.height);
				com.SetXY(0, 0);
#if UNITY_EDITOR
				com.displayObject.gameObject.name = com.name;
#endif
				FGUI layer = EntityFactory.Create<FGUI, GObject>(scene, com);
				Root.Add(layer, true);
			}
            //Root.GObject.asCom.AddChild(ui.GObject);
        }
        public override void Dispose()
		{
			if (IsDisposed)
			{
				return;
			}

			base.Dispose();

            Root?.Dispose();
            Root = null;
		}

		public void Add(FGUI ui,UILayer layer = UILayer.Mid ,bool asChildGObject = true)
		{
			var layerUI = Root?.Get(layer.ToString());
            if (layerUI != null)
            {
				layerUI.Add(ui, asChildGObject);
            }
		}

		public void Remove(string name, UILayer layer = UILayer.All)
		{
			if (layer == UILayer.All)
			{
				for (int i = 0; i < (int)UILayer.All; i++)
				{
					Remove(name, (UILayer)i);
				}
			}
			else
            {
				var UIlayer = Root?.Get(layer.ToString());
				UIlayer?.Remove(name);
			}
		}

		public FGUI Get(string name, UILayer layer = UILayer.All)
		{
			if (layer == UILayer.All)
			{
				for (int i = 0; i < (int)UILayer.All; i++)
				{
					var l = Get(name, (UILayer)i);
					if (l != null)
					{
						return l;
					}
				}
			}
			else
			{
				var UIlayer = Root?.Get(layer.ToString());
				return UIlayer?.Get(name);
			}
			return null;
		}

        /*public FGUI[] GetAll()
        {
            return 
        }*/
		
		public void Clear(UILayer layer = UILayer.All)
        {
            if (layer == UILayer.All)
            {
                for (int i = 0; i < (int)UILayer.All; i++)
                {
					Clear((UILayer)i);
                }
            }
            else
            {
				Root?.Get(layer.ToString()).RemoveChildren();
            }
        }
	}
}
#endif