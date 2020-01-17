using System;
using UnityEngine;

namespace DCET.Model
{
	[ObjectSystem]
	public class GlobalConfigComponentAwakeSystem : AwakeSystem<GlobalConfigComponent>
	{
		public override void Awake(GlobalConfigComponent t)
		{
			t.Awake();
		}
	}

	public class GlobalConfigComponent : Entity
	{
		public static GlobalConfigComponent Instance;
		public GlobalProto GlobalProto;

		public void Awake()
		{
			Instance = this;
			string configStr = GetGlobal();
			this.GlobalProto = JsonHelper.FromJson<GlobalProto>(configStr);
		}
		public static string GetGlobal()
		{
			try
			{
				GameObject config = (GameObject)ResourcesHelper.Load("KV");
				string configStr = config.Get<TextAsset>("GlobalProto").text;
				return configStr;
			}
			catch (Exception e)
			{
				throw new Exception($"load global config file fail", e);
			}
		}

	}
}