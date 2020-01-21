using System.Net;
using MongoDB.Bson.Serialization.Attributes;

namespace DCET.Hotfix
{
	public class ClientConfig: AConfigComponent
	{
		public string Address { get; set; }
	}
}