using UnityEngine.Events;
using UnityEngine.UI;

namespace Cell.View.UI.Component
{
    readonly struct ButtonUIC
    {
        internal readonly Button Button;

        internal ButtonUIC(in Button button) => Button = button;

        internal void AddListener(in UnityAction uA) => Button.onClick.AddListener(uA);
    }
}