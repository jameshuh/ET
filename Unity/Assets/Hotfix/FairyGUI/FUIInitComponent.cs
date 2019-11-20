using DCET.Model;
using System.Threading.Tasks;

namespace DCET.Hotfix
{
	public class FUIInitComponent : Entity
	{
        public async Task Init()
        {
            await Model.Game.Scene.GetComponent<FUIPackageComponent>().AddPackageAsync(FUIPackage.Common);
        }

        public override void Dispose()
		{
			if (IsDisposed)
			{
				return;
			}

			base.Dispose();

			Model.Game.Scene.GetComponent<FUIPackageComponent>().RemovePackage(FUIPackage.Common);
        }
    }
}