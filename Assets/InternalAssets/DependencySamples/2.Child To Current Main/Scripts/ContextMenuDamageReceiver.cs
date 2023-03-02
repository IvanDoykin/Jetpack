using System;
using UnityEngine;

namespace ChildToCurrentMain
{
    public class ContextMenuDamageReceiver : MonoBehaviour, IDamageReceiver
    {
        [SerializeField] private int _damage;

        public Action<int> OnDamage { get; set; }

        [ContextMenu("Get damage")]
        private void GetDamage()
        {
            OnDamage?.Invoke(_damage);
        }
    }
}