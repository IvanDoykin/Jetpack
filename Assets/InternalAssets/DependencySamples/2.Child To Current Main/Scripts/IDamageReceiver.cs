using System;
using UnityEngine;

namespace ChildToCurrentMain
{
    public interface IDamageReceiver
    {
        public Action<int> OnDamage { get; set; }
    }
}