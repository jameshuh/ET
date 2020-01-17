using MongoDB.Bson.Serialization.Attributes;

namespace DCET.Model
{
	[BsonIgnoreExtraElements]
	public class DBConfig : AConfigComponent
	{
		public string ConnectionString { get; set; }
		public string DBName { get; set; }
	}
}