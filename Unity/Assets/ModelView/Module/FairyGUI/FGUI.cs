#if FAIRYGUI
using FairyGUI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
	[ObjectSystem]
	public class FGUIAwakeSystem : AwakeSystem<FGUI, GObject>
	{
		public override void Awake(FGUI self, GObject gObject)
		{
			self.GObject = gObject;
		}
	}
	
	public class FGUI : Entity
	{
		public GObject GObject;

        public string Name
        {
            get
            {
                if(GObject == null)
                {
                    return string.Empty;
                }

                return GObject.name;
            }

            set
            {
                if (GObject == null)
                {
                    return;
                }

                GObject.name = value;
            }
        }
        
        public bool Visible
        {
            get
            {
                if (GObject == null)
                {
                    return false;
                }

                return GObject.visible;
            }
            set
            {
                if (GObject == null)
                {
                    return;
                }

                GObject.visible = value;
            }
        }

        public bool IsComponent
        {
            get
            {
                return GObject is GComponent;
            }
        }

        public bool IsRoot
        {
            get
            {
                return GObject is GRoot;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return GObject == null;
            }
        }

        private Dictionary<string, FGUI> fuiChildren = new Dictionary<string, FGUI>();

        protected bool isFromFGUIPool = false;
		
		public override void Dispose()
		{
			if (IsDisposed)
			{
				return;
			}
			
			base.Dispose();
			
			// 从父亲中删除自己
			GetParent<FGUI>()?.RemoveNoDispose(Name);

			// 删除所有的孩子
			foreach (FGUI ui in fuiChildren.Values.ToArray())
			{
				ui.Dispose();
			}

			fuiChildren.Clear();

            // 删除自己的UI
            if (!IsRoot && !isFromFGUIPool)
            {
                GObject.Dispose();
            }

            GObject = null;
            isFromFGUIPool = false;
        }

		public void Add(FGUI ui, bool asChildGObject)
		{
            if(ui == null || ui.IsEmpty)
            {
                throw new Exception($"ui can not be empty");
            }

            if (string.IsNullOrWhiteSpace(ui.Name))
            {
                throw new Exception($"ui.Name can not be empty");
            }
            
            if (fuiChildren.ContainsKey(ui.Name))
            {
                throw new Exception($"ui.Name({ui.Name}) already exist");
            }

            fuiChildren.Add(ui.Name, ui);

            if (IsComponent && asChildGObject)
            {
                GObject.asCom.AddChild(ui.GObject);
            }

            ui.Parent = this;
        }

        public void MakeFullScreen()
        {
            GObject?.asCom?.MakeFullScreen();
        }

        public void Remove(string name)
		{
			if (IsDisposed)
			{
				return;
			}

			FGUI ui;

			if (fuiChildren.TryGetValue(name, out ui))
            {
                fuiChildren.Remove(name);

                if (ui != null)
                {
                    if (IsComponent)
                    {
                        GObject.asCom.RemoveChild(ui.GObject, false);
                    }

                    ui.Dispose();
                }
            }
		}

        /// <summary>
        /// 一般情况不要使用此方法，如需使用，需要自行管理返回值的FGUI的释放。
        /// </summary>
        public FGUI RemoveNoDispose(string name)
        {
            if (IsDisposed)
            {
                return null;
            }

            FGUI ui;

            if (fuiChildren.TryGetValue(name, out ui))
            {
                fuiChildren.Remove(name);

                if (ui != null)
                {
                    if(IsComponent)
                    {
                        GObject.asCom.RemoveChild(ui.GObject, false);
                    }

                    ui.Parent = null;
                }
            }

            return ui;
        }

        public void RemoveChildren()
		{
			foreach (var child in fuiChildren.Values.ToArray())
			{
				child.Dispose();
			}

			fuiChildren.Clear();
		}

		public FGUI Get(string name)
		{
			FGUI child;

			if (fuiChildren.TryGetValue(name, out child))
			{
				return child;
			}
			
			return null;
		}

        public FGUI[] GetAll()
        {
            return fuiChildren.Values.ToArray();
        }
	}
}
#endif