using System;

namespace DCET.Model
{
	public interface IMHandler
	{
		ETVoid Handle(Session session, object message);
		Type GetMessageType();
	}
}