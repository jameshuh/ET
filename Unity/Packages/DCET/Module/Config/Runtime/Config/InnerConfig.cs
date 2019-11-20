using System.Net;
using MongoDB.Bson.Serialization.Attributes;

namespace DCET.Model
{
	[NoObjectPool]
	[BsonIgnoreExtraElements]
	public class InnerConfig: AConfigComponent
	{
		public string Address { get; set; }
	}
}