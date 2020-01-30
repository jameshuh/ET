using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DCET.Hotfix
{
    [ObjectSystem]
    public class SceneChangeComponentUpdateSystem: UpdateSystem<SceneChangeComponent>
    {
        public override void Update(SceneChangeComponent self)
        {
            if (self.loadMapOperation.isDone)
            {
                self.tcs.SetResult(true);
            }
           
        }
    }
	
    [ObjectSystem]
    public class SceneChangeComponentDestroySystem: DestroySystem<SceneChangeComponent>
    {
        public override void Destroy(SceneChangeComponent self)
        {
            self.loadMapOperation = null;
            self.tcs = null;
        }
    }

    public class SceneChangeComponent: Entity
    {
        public AsyncOperation loadMapOperation;
        public TaskCompletionSource<bool> tcs;

        public Task ChangeSceneAsync(string sceneName)
        {
            this.tcs = new TaskCompletionSource<bool>();
            // 加载map
            this.loadMapOperation = SceneManager.LoadSceneAsync(sceneName);
            //this.loadMapOperation.allowSceneActivation = false;
            return this.tcs.Task;
        }

        public int Process
        {
            get
            {
                if (this.loadMapOperation == null)
                {
                    return 0;
                }
                return (int)(this.loadMapOperation.progress * 100);
            }
        }

        public void Finish()
        {
            this.tcs.SetResult(true);
        }
    }
}