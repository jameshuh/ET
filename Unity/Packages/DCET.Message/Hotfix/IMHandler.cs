using System;

namespace DCET.Hotfix
{
	public interface IMHandler
	{
		ETVoid Handle(Session session, object message);
		Type GetMessageType();
	}
}