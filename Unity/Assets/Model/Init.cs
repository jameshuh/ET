using System;
using System.Threading;
using UnityEngine;

namespace DCET.Model
{
	public class Init : MonoBehaviour
	{
		private void Awake()
		{
			try
			{
				SynchronizationContext.SetSynchronizationContext(OneThreadSynchronizationContext.Instance);

				DontDestroyOnLoad(gameObject);

				DownloadBundle();

				GameLoop.onAwake?.Invoke();
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private void DownloadBundle()
		{

		}

		private void Start()
		{
			try
			{
				GameLoop.onStart?.Invoke();
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private void OnEnable()
		{
			try
			{
				GameLoop.onEnable?.Invoke();
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private void OnDisable()
		{
			try
			{
				GameLoop.onDisable?.Invoke();
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private void Update()
		{
			try
			{
				OneThreadSynchronizationContext.Instance.Update();
				GameLoop.onUpdate?.Invoke();
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private void LateUpdate()
		{
			try
			{
				GameLoop.onLateUpdate?.Invoke();
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private void FixedUpdate()
		{
			try
			{
				GameLoop.onFixedUpdate?.Invoke();
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private void OnDestroy()
		{
			try
			{
				GameLoop.onDestroy?.Invoke();
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private void OnApplicationPause(bool isPause)
		{
			try
			{
				GameLoop.onApplicationPause?.Invoke(isPause);
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private void OnApplicationFocus(bool isFocus)
		{
			try
			{
				GameLoop.onApplicationFocus?.Invoke(isFocus);
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}

		private void OnApplicationQuit()
		{
			try
			{
				GameLoop.onApplicationQuit?.Invoke();
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}
	}
}