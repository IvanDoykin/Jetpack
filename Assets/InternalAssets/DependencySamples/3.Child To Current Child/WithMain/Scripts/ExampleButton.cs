using System;
using UnityEngine;

namespace ChildToCurrentChildWithMain
{
    public class ExampleButton : Button
    {
        [ContextMenu("Press")]
        public override void Press()
        {
            HasPressed?.Invoke(this);
        }
    }
}