using UnityEngine;

namespace ET
{
    public class GlobalComponent: Entity
    {
        public static GlobalComponent Instance;
        
        public Transform Global;
        public Transform Unit;
#if !FAIRYGUI
        public Transform UI;
#endif
    }
}