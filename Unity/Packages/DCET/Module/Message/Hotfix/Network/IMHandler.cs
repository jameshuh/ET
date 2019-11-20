using DCET.Model;
using System;

namespace DCET.Hotfix
{
#if ILRuntime
	public interface IMHandler
	{
		ETVoid Handle(Model.Session session, object message);
		Type GetMessageType();
	}
#else
	public interface IMHandler : Model.IMHandler
	{
	}
#endif
}