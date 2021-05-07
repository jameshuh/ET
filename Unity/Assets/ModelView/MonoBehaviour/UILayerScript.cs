using UnityEngine;

namespace ET
{
#if !FAIRYGUI
    public enum UILayer
    {
        Hidden = 0,
        Low = 10,
        Mid = 20,
        High = 30,
    }
    
    public class UILayerScript: MonoBehaviour
    {
        public UILayer UILayer;
    }
#else
    public enum UILayer
    {
        Hidden = 0,
        Low,
        Mid,
        High,
        //Float,
        All
    }
#endif
}