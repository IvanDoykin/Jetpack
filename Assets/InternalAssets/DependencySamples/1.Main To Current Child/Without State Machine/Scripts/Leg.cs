using UnityEngine;

namespace MainToChildWithoutStateMachine
{
    public class Leg : MonoBehaviour, ILeg
    {
        public void Kick()
        {
            Debug.Log("Kick by leg");
        }
    }
}