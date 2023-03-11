using UnityEngine;
using UnityEditor;

namespace ChildToCurrentChildWithMain
{
    public class PingAnotherButton : MonoBehaviour, IButtonCommand
    {
        [SerializeField] private Button _anotherButton;

        public void Execute()
        {
            EditorGUIUtility.PingObject(_anotherButton.gameObject);
        }
    }
}