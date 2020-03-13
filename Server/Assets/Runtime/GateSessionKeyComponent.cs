using System.Collections.Generic;

namespace DCET
{
	public class GateSessionKeyComponent : Entity
	{
		private readonly Dictionary<string, string> sessionKey = new Dictionary<string, string>();
		
		public void Add(string key, string account)
		{
			this.sessionKey.Add(key, account);
			this.TimeoutRemoveKey(key);
		}

		public string Get(string key)
		{
			string account = null;
			this.sessionKey.TryGetValue(key, out account);
			return account;
		}

		public void Remove(string key)
		{
			this.sessionKey.Remove(key);
		}

		private async void TimeoutRemoveKey(string key)
		{
			await Game.Scene.GetComponent<TimerComponent>().WaitAsync(20000);
			this.sessionKey.Remove(key);
		}
	}
}
