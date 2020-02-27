using FairyGUI;
using System;

namespace DCET.Runtime
{
	public class FUIPackage : IDisposable
	{
		private UIPackage uiPackage;

		public FUIPackage(string resPath)
		{
			uiPackage = UIPackage.AddPackage(resPath);
		}

		public void Dispose()
		{
			if(uiPackage != null)
			{
				UIPackage.RemovePackage(uiPackage.name);
			}
		}
	}
}
