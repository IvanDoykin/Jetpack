using UnityEngine;

namespace MainToChildWithoutStateMachine
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
            _legs[0]?.Kick();
        }
    }
}