using UnityEngine;

namespace ChildToCurrentChildWithMain
{
    public class ButtonSystem : MonoBehaviour
    {
        private Button[] _buttons;

        private void Start()
        {
            _buttons = GetComponentsInChildren<Button>();

            foreach (Button button in _buttons)
            {
                button.HasPressed += ReactOnButton;
            }
        }

        private void ReactOnButton(Button button)
        {
            button.GetComponent<IButtonCommand>()?.Execute();
        }
    }
}