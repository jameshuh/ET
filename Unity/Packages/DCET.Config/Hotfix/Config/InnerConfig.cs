using System.Net;
using DCET.Model;
using MongoDB.Bson.Serialization.Attributes;

namespace DCET.Hotfix
{
	[BsonIgnoreExtraElements]
	public class InnerConfig: AConfigComponent
	{
		[BsonIgnore]
		public IPEndPoint IPEndPoint { get; private set; }
		
		public string Address { get; set; }

		public override void EndInit()
		{
			this.IPEndPoint = NetworkHelper.ToIPEndPoint(this.Address);
		}
	}
}