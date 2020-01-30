using System;

namespace DCET.Hotfix
{
	public interface IMHandler
	{
		void Handle(Session session, object message);
		Type GetMessageType();
	}
}