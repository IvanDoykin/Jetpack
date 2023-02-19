using UnityEngine;
using SceneLoading;
using UnityEngine.SceneManagement;

public class SceneLoaderSample : MonoBehaviour
{
    [SerializeField] private SceneReference sceneToLoad;

    [ContextMenu("LoadSelectedLevel")]
    private void Load()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
