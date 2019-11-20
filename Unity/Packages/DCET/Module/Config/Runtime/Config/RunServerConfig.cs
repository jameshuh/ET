using MongoDB.Bson.Serialization.Attributes;

namespace DCET.Model
{
	[BsonIgnoreExtraElements]
	public class RunServerConfig: AConfigComponent
	{
		public string IP = "";
	}
}