namespace DCET.Hotfix
{
	public interface ISupportInitialize
	{
		void BeginInit();
		void EndInit();
	}

	public abstract class Object: ISupportInitialize
	{
		public virtual void BeginInit()
		{
		}

		public virtual void EndInit()
		{
		}
	}
}