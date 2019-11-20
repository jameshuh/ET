using DCET.Model;

namespace DCET.Hotfix
{
	[MessageHandler]
	public class G2C_TestHotfixMessageHandler : AMHandler<G2C_TestHotfixMessage>
	{
		protected override async ETTask Run(DCET.Model.Session session, G2C_TestHotfixMessage message)
		{
			Log.Debug(message.Info);
			await ETTask.CompletedTask;
		}
	}
}