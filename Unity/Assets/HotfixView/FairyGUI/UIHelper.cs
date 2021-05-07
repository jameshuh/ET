using FairyGUI;

namespace ET
{
    public static class UIHelper
    {
        public static GObject CreateGObject(Scene scene,string packageName,string resName)
        {
            scene.GetComponent<FGUIPackageComponent>().AddPackage(packageName);
            return UIPackage.CreateObject(packageName, resName);
        }

        public static async ETTask<GObject> CreateGObjectAsync(Scene scene,string packageName, string resName)
        {
            await scene.GetComponent<FGUIPackageComponent>().AddPackageAsync(packageName);
            ETTask<GObject> tcs = ETTask<GObject>.Create(true);
            UIPackage.CreateObjectAsync(packageName, resName, (go) => { tcs.SetResult(go); });
            return await tcs;
        }
        /*
        public static async ETTask<FGUI> Create(Scene scene, string uiType)
        {
            return await scene.GetComponent<FGUIComponent>().Create(uiType);
        }
        
        public static async ETTask Remove(Scene scene, string uiType)
        {
            scene.GetComponent<FGUIComponent>().Remove(uiType);
            await ETTask.CompletedTask;
        }*/
    }
}