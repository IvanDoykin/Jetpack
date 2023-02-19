using UnityEngine;
using SceneLoading;
using UnityEngine.SceneManagement;

public class SceneLoaderSample : MonoBehaviour
{
    [SerializeField] private SceneReference sceneToLoad;

    private void Start()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
