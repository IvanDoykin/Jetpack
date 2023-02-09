using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Scenes", menuName = "Configs/Scenes", order = 1)]
public class Scenes : Config
{
    public const string UpdateMethodName = nameof(UpdatePaths);

    [SerializeField] [NonReorderable]
    private List<SceneConfig> _scenes;

    public void UpdatePaths()
    {
        foreach (var scene in _scenes)
        {
            scene.UpdatePath();
        }
    }

    public string GetScenePath(Level level)
    {
        string scenePath = _scenes.FirstOrDefault(scene => scene.Level == level).Path;
        if (scenePath == "")
        {
            throw new Exception("Get scene exception");
        }

        return scenePath;
    }
}
