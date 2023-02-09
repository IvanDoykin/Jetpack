using System;
using System.Collections.Generic;
using InternalAssets.Scripts;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class App : MonoBehaviour
{
    private const float _spaceHeight = 20f;
    public static App Instance { get; private set; }
    
    [Header("Startup settings")]
    [SerializeField] private Level _startLevel;
    
    [Space(_spaceHeight)]
    
    [NonReorderable]
    [SerializeField] private List<Config> _configs = new();
    
    private ILevelLoader _loader;

    private void Awake()
    {
        if (Instance != null)
        {
            throw new Exception("App initialization exception");
        }
        
        Instance = this;
    }

    private void Start()
    {
        SetGlobalSettings();
        InitializeCoreModules();
        
        _loader.Load(_startLevel);
    }

    private T GetConfig<T>() where T : Config
    {
        return (T)_configs.Find(config => config.GetType() == typeof(T));
    } 

    private void SetGlobalSettings()
    {
        DebugManager.instance.enableRuntimeUI = false;
    }
    
    private void InitializeCoreModules()
    {
        _loader = new LevelLoader(GetConfig<Scenes>());
    }
}
