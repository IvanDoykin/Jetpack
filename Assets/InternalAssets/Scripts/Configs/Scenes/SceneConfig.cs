using System;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

[Serializable]
public class SceneConfig
{
    [SerializeField] private Level _level;
    public Level Level => _level;
    
    [OnChangedCall(Scenes.UpdateMethodName)]
    [SerializeField] private Object _sceneAsset;
    
    [ReadOnly] [SerializeField] private string _path;
    public string Path => _path;

    public void UpdatePath()
    {
        if (_sceneAsset != null)
        {
            _path = AssetDatabase.GetAssetPath(_sceneAsset);
        }
        else
        {
            _path = "";
        }
    }
}