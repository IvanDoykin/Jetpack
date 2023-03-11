using System;
using UnityEngine;

namespace ChildToCurrentChildWithMain
{
    public abstract class Button : MonoBehaviour
    {
        public Action<Button> HasPressed { get; set; }

        public abstract void Press();
    }
}