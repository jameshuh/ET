namespace ET
{
    public class AfterCreateZoneScene_AddComponent: AEvent<EventType.AfterCreateZoneScene>
    {
        protected override async ETTask Run(EventType.AfterCreateZoneScene args)
        {
            Scene zoneScene = args.ZoneScene;
#if FAIRYGUI
            zoneScene.AddComponent<FGUIPackageComponent>();
            zoneScene.AddComponent<FGUIComponent,Scene>(zoneScene);
#else
            zoneScene.AddComponent<UIEventComponent>();
            zoneScene.AddComponent<UIComponent>();
#endif
            await ETTask.CompletedTask;
        }
    }
}