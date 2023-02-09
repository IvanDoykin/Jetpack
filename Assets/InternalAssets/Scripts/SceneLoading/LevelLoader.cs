using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace InternalAssets.Scripts
{
    public abstract class LevelLoader
    {
        protected LevelLoader(Scenes scenes)
        {
            
        }
        
        public abstract void Load(Level level);
        public abstract void Reload();
    }
}