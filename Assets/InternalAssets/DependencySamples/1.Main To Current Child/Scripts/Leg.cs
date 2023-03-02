using UnityEngine;

namespace MainToCurrentChild
{
    public class Leg : MonoBehaviour, ILeg
    {
        public void Kick()
        {
            Debug.Log("Kick by leg");
        }
    }
}