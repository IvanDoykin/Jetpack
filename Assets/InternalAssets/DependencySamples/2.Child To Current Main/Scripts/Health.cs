using UnityEngine;

namespace ChildToCurrentMain
{
    public class Health : MonoBehaviour
    {
        private IDamageReceiver[] _receivers;

        private void Start()
        {
            _receivers = GetComponentsInChildren<IDamageReceiver>();

            foreach (var receiver in _receivers)
            {
                receiver.OnDamage += GetDamage;
            }
        }

        private void GetDamage(int damage)
        {
            Debug.Log("Get " + damage + " damage.");
        }
    }
}