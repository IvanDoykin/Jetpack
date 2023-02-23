using System;
using UnityEngine;
using SceneLoading;
using UnityEngine.SceneManagement;

public class SceneLoaderSample : MonoBehaviour
{
    [SerializeField] private SceneReference sceneToLoad;

    private void Start()
    {
        Instantiate(this.gameObject);
        DestroyImmediate(gameObject);
    }

    [ContextMenu("LoadSelectedLevel")]
    private void Load()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
