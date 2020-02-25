using System;
using System.Collections;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace DCET
{
	public class Env
	{
		[BsonElement, BsonIgnoreIfNull]
		private Dictionary<EnvKey, object> values = new Dictionary<EnvKey, object>();

		public object this[EnvKey key]
		{
			get
			{
				return values[key];
			}
			set
			{
				if (values == null)
				{
					values = new Dictionary<EnvKey, object>();
				}
				values[key] = value;
			}
		}

		public T Get<T>(EnvKey key)
		{
			if (values == null || !values.ContainsKey(key))
			{
				return default(T);
			}
			object value = values[key];
			try
			{
				return (T) value;
			}
			catch (InvalidCastException e)
			{
				throw new Exception($"不能把{value.GetType()}转换为{typeof (T)}", e);
			}
		}

		public void Set(EnvKey key, object obj)
		{
			if (values == null)
			{
				values = new Dictionary<EnvKey, object>();
			}
			values[key] = obj;
		}

		public bool ContainKey(EnvKey key)
		{
			if (values == null)
			{
				return false;
			}
			return values.ContainsKey(key);
		}

		public void Remove(EnvKey key)
		{
			if (values == null)
			{
				return;
			}
			values.Remove(key);
			if (values.Count == 0)
			{
				values = null;
			}
		}

		public void Add(EnvKey key, object value)
		{
			if (values == null)
			{
				values = new Dictionary<EnvKey, object>();
			}
			values[key] = value;
		}

		public IEnumerator GetEnumerator()
		{
			return values.GetEnumerator();
		}
	}
}