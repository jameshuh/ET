using System;
using System.Threading;
using UnityEngine;

namespace DCET.Model
{
	public class Init : MonoBehaviour
	{
		private void Start()
		{
			StartAsync();
		}
		
		private void StartAsync()
		{
			try
			{
				SynchronizationContext.SetSynchronizationContext(OneThreadSynchronizationContext.Instance);

				DontDestroyOnLoad(gameObject);
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private void Update()
		{
			OneThreadSynchronizationContext.Instance.Update();
			//Game.Hotfix.Update?.Invoke();
			//Game.EventSystem.Update();
		}

		private void LateUpdate()
		{
			//Game.Hotfix.LateUpdate?.Invoke();
			//Game.EventSystem.LateUpdate();
		}

		private void OnApplicationQuit()
		{
			//Game.Hotfix.OnApplicationQuit?.Invoke();
			//Game.Close();
		}
	}
}