using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
#if !ILRuntime
using System.Reflection;
#endif

namespace ETModel
{
	public sealed class Hotfix : Object
	{
#if ILRuntime
		public ILRuntime.Runtime.Enviorment.AppDomain appDomain = new ILRuntime.Runtime.Enviorment.AppDomain();
		private MemoryStream dllStream;
		private MemoryStream pdbStream;
#else
		private Assembly assembly;
#endif

		private IStaticMethod start;
		private List<Type> hotfixTypes;

		public Action Update;
		public Action LateUpdate;
		public Action OnApplicationQuit;

		public void GotoHotfix()
		{
#if ILRuntime
			Log.Debug($"当前使用的是ILRuntime模式");
			this.start = new ILStaticMethod(this.appDomain, "ETHotfix.Init", "Start", 0);
			this.hotfixTypes = this.appDomain.LoadedTypes.Values.Select(x => x.ReflectionType).ToList();
#else
			Type hotfixInit = this.assembly.GetType("ETHotfix.Init");
			this.start = new MonoStaticMethod(hotfixInit, "Start");
#endif

			this.start.Run();
		}

		public List<Type> GetHotfixTypes()
		{
			return this.hotfixTypes;
		}

		public void LoadHotfixAssembly(byte[] assBytes, byte[] pdbBytes)
		{			
#if ILRuntime
			this.dllStream = new MemoryStream(assBytes);
			this.pdbStream = new MemoryStream(pdbBytes);
			this.appDomain.LoadAssembly(this.dllStream, this.pdbStream, new Mono.Cecil.Pdb.PdbReaderProvider());
#else
			Log.Debug($"当前使用的是Mono模式");

			this.assembly = Assembly.Load(assBytes, pdbBytes);
#endif
		}
	}
}