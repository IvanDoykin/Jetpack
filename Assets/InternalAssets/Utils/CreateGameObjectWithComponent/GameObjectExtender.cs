using UnityEngine;

namespace InternalAssets.Scripts
{
    public static class GameObjectExtender
    {
        public static T Create<T>(this GameObject gameObject) where T : MonoBehaviour
        {
            var newObject = new GameObject
            {
                name = typeof(T).Name
            };

            var component = newObject.AddComponent<T>();
            return component;
        }
    }
}