using ProtoBuf.Meta;
using System;
using System.IO;

namespace DCET
{
	public static class ProtobufHelper
	{
		public static byte[] ToBytes(object message)
		{
			using (MemoryStream memoryStream = new MemoryStream())
			{
				RuntimeTypeModel.Default.Serialize(memoryStream, message);

				return memoryStream.ToArray();
			}
		}
		
		public static void ToStream(object message, MemoryStream memoryStream)
		{
			RuntimeTypeModel.Default.Serialize(memoryStream, message);
		}
		
		public static object FromBytes(Type type, byte[] bytes, int index, int count)
		{
			using (MemoryStream s = new MemoryStream(bytes, index, count))
			{
				return RuntimeTypeModel.Default.Deserialize(s, null, type);
			}
		}
		
		public static object FromBytes(object instance, byte[] bytes, int index, int count)
		{
			if(instance != null)
			{
				return FromBytes(instance.GetType(), bytes, index, count);
			}

			return null;
		}
		
		public static object FromStream(Type type, MemoryStream stream)
		{
			return RuntimeTypeModel.Default.Deserialize(stream, null, type);
		}
		
		public static object FromStream(object message, MemoryStream stream)
		{
			if(message != null)
			{
				return FromStream(message.GetType(), stream);
			}

			return null;
		}
	}
}