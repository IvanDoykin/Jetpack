using UnityEngine;

namespace MainToCurrentChild
{
    // Main
    public class Legs : MonoBehaviour
    {
        private ILeg[] _legs;

        private void Start()
        {
            _legs = GetComponentsInChildren<ILeg>();
        }

        [ContextMenu("First leg kick")]
        private void Kick()
        {
            // We can check state with using pattern State Machine (it will be in later samples)
            _legs[0]?.Kick();
        }
    }
}