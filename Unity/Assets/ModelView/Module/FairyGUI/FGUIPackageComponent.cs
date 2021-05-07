#if FAIRYGUI
using FairyGUI;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
	/// <summary>
	/// 管理所有UI Package
	/// </summary>
	public class FGUIPackageComponent : Entity
    {
        public const string FGUI_PACKAGE_DIR = "Assets/Bundles/FGUI";

        private readonly Dictionary<string, int> packages = new Dictionary<string, int>();
		
		private bool AddPackageRef(string type)
        {
			int refCount = 0;
			packages.TryGetValue(type, out refCount);
			refCount++;
			packages[type] = refCount;
			return refCount == 1;
        }

		private bool RemovePackageRef(string type)
        {
			if (packages.TryGetValue(type, out int refCount))
			{
				refCount--;
				packages[type] = refCount;
				if (refCount <= 0)
				{
					packages.Remove(type);
					return true;
				}
			}
			return false;
        }
		public void AddPackage(string type)
		{
			if (Define.IsEditorMode)
			{
                if (AddPackageRef(type))
                {
					UIPackage.AddPackage($"{FGUI_PACKAGE_DIR}/{type}");
				}
				//UIPackage uiPackage = UIPackage.AddPackage($"{FGUI_PACKAGE_DIR}/{type}");
				//packages.Add(type, uiPackage);
			}
			else
			{
				if (AddPackageRef(type))
				{
					string uiBundleDesName = AssetBundleHelper.StringToAB($"{type}_fui");
					string uiBundleResName = AssetBundleHelper.StringToAB(type);
					ResourcesComponent resourcesComponent = Game.Scene.GetComponent<ResourcesComponent>();
					resourcesComponent.LoadBundle(uiBundleDesName);
					resourcesComponent.LoadBundle(uiBundleResName);

					AssetBundle desAssetBundle = resourcesComponent.GetAssetBundle(uiBundleDesName);
					AssetBundle resAssetBundle = resourcesComponent.GetAssetBundle(uiBundleResName);

					UIPackage.AddPackage(desAssetBundle, resAssetBundle);
				}
                //UIPackage uiPackage = UIPackage.AddPackage(desAssetBundle, resAssetBundle);
				//packages.Add(type, uiPackage);
			}
		}
        
		public async ETTask AddPackageAsync(string type)
		{
			if (Define.IsEditorMode)
			{
				await ETTask.CompletedTask;
				if (AddPackageRef(type))
                {
					UIPackage.AddPackage($"{FGUI_PACKAGE_DIR}/{type}");
				}
				//UIPackage uiPackage = UIPackage.AddPackage($"{FGUI_PACKAGE_DIR}/{type}");

				//packages.Add(type, uiPackage);
			}
			else
			{
				if (AddPackageRef(type))
				{
					string uiBundleDesName = AssetBundleHelper.StringToAB($"{type}_fui");
					string uiBundleResName = AssetBundleHelper.StringToAB(type);
					ResourcesComponent resourcesComponent = Game.Scene.GetComponent<ResourcesComponent>();
					await resourcesComponent.LoadBundleAsync(uiBundleDesName);
					await resourcesComponent.LoadBundleAsync(uiBundleResName);

					AssetBundle desAssetBundle = resourcesComponent.GetAssetBundle(uiBundleDesName);
					AssetBundle resAssetBundle = resourcesComponent.GetAssetBundle(uiBundleResName);
					UIPackage.AddPackage(desAssetBundle, resAssetBundle);
				}
				//UIPackage uiPackage = UIPackage.AddPackage(desAssetBundle, resAssetBundle);

				//packages.Add(type, uiPackage);
			}
		}

		public void RemovePackage(string type)
		{
            if (RemovePackageRef(type))
            {
                var p = UIPackage.GetByName(type);

                if (p != null)
                {
                    UIPackage.RemovePackage(type);
                }
            }
            /*UIPackage package;

            if(packages.TryGetValue(type, out package))
            {
                var p = UIPackage.GetByName(package.name);

                if (p != null)
                {
                    UIPackage.RemovePackage(package.name);
                }

                packages.Remove(package.name);
            }*/

			if (!Define.IsEditorMode)
			{
				string uiBundleDesName = AssetBundleHelper.StringToAB($"{type}_fui");
				string uiBundleResName = AssetBundleHelper.StringToAB(type);
				Game.Scene.GetComponent<ResourcesComponent>().UnloadBundle(uiBundleDesName);
				Game.Scene.GetComponent<ResourcesComponent>().UnloadBundle(uiBundleResName);
			}
		}
	}
}
#endif