using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace InternalAssets.Scripts
{
    public class SingleplayerLevelLoader : LevelLoader
    {
        private Coroutine _loadingCoroutine;
        private readonly Scenes _scenes;
        
        public SingleplayerLevelLoader(Scenes scenes) : base(scenes)
        {
            _scenes = scenes;
        }

        public override void Load(Level level)
        {
            string scenePath = _scenes.GetScenePath(level);

            if (_loadingCoroutine != null)
            {
                throw new Exception("Exception of loading while loading");
            }
            
            _loadingCoroutine = App.Instance.StartCoroutine(LoadScene(scenePath));
        }

        public override void Reload()
        {
            if (_loadingCoroutine != null)
            {
                throw new Exception("Exception of reloading while loading");
            }
            
            _loadingCoroutine = App.Instance.StartCoroutine(ReloadScene());
        }

        private IEnumerator ReloadScene()
        {
            Scene reloadingScene = SceneManager.GetActiveScene();
            if (reloadingScene == App.Instance.gameObject.scene)
            {
                _loadingCoroutine = null;
                yield break;
            }
            
            yield return App.Instance.StartCoroutine(LoadScene(reloadingScene.path));
            _loadingCoroutine = null;
        }
        
        private IEnumerator UnloadOldScene(Scene oldScene)
        {
            AsyncOperation levelUnloading = SceneManager.UnloadSceneAsync(oldScene.path);
            while (!levelUnloading.isDone)
            {
                yield return null;
            }
        }
        
        private IEnumerator LoadScene(string scenePath)
        {
            Scene oldScene = SceneManager.GetActiveScene();

            if (oldScene != App.Instance.gameObject.scene)
            {
                Coroutine unloading = App.Instance.StartCoroutine(UnloadOldScene(oldScene));
                yield return unloading;
            }

            AsyncOperation levelLoading = SceneManager.LoadSceneAsync(scenePath, LoadSceneMode.Additive);
            while (!levelLoading.isDone)
            {
                yield return null;
            }
            
            Scene newScene = SceneManager.GetSceneByPath(scenePath);
            SceneManager.SetActiveScene(newScene);

            _loadingCoroutine = null;
        }
    }
}