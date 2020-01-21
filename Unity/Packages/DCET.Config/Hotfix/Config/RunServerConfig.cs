using MongoDB.Bson.Serialization.Attributes;

namespace DCET.Hotfix
{
	[BsonIgnoreExtraElements]
	public class RunServerConfig: AConfigComponent
	{
		public string IP = "";
	}
}