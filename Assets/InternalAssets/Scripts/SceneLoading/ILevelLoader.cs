using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace InternalAssets.Scripts
{
    public interface ILevelLoader
    {
        public void Load(Level level);
        public void Reload();
    }
}