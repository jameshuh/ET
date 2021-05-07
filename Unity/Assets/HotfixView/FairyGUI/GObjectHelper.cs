using FairyGUI;
using System.Collections.Generic;

namespace ET
{
	public static class GObjectHelper
    {
        private static Dictionary<GObject, FGUI> keyValuePairs = new Dictionary<GObject, FGUI>();

        public static T Get<T>(this GObject self) where T : FGUI
        {
            if (self != null && keyValuePairs.ContainsKey(self))
            {
                return keyValuePairs[self] as T;
            }

            return default(T);
        }

        public static void Add(this GObject self, FGUI fui)
        {
            if (self != null && fui != null)
            {
                keyValuePairs[self] = fui;
            }
        }

        public static FGUI Remove(this GObject self)
        {
            if (self != null && keyValuePairs.ContainsKey(self))
            {
                var result = keyValuePairs[self];
                keyValuePairs.Remove(self);
                return result;
            }

            return null;
        }
    }
}