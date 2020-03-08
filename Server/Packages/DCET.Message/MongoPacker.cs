using System;
using System.IO;

namespace DCET
{
	public class MongoPacker: IMessagePacker
	{
		public byte[] SerializeTo(object obj)
		{
			return Runtime.MongoHelper.ToBson(obj);
		}

		public void SerializeTo(object obj, MemoryStream stream)
		{
			Runtime.MongoHelper.ToBson(obj, stream);
		}

		public object DeserializeFrom(Type type, byte[] bytes, int index, int count)
		{
			return Runtime.MongoHelper.FromBson(type, bytes, index, count);
		}

		public object DeserializeFrom(object instance, byte[] bytes, int index, int count)
		{
			return Runtime.MongoHelper.FromBson(instance, bytes, index, count);
		}

		public object DeserializeFrom(Type type, MemoryStream stream)
		{
			return Runtime.MongoHelper.FromStream(type, stream);
		}

		public object DeserializeFrom(object instance, MemoryStream stream)
		{
			return Runtime.MongoHelper.FromBson(instance, stream);
		}
	}
}
