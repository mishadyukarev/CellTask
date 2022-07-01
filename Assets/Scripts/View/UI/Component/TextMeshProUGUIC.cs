using TMPro;
using UnityEngine;

namespace Cell.View.UI.Component
{
    readonly struct TextMeshProUGUIC
    {
        internal readonly TextMeshProUGUI TextMP;

        internal string Text
        {
            get => TextMP.text;
            set => TextMP.text = value;
        }
        internal Transform Transform => TextMP.transform;
        internal Vector3 LocalPosition
        {
            get => Transform.localPosition;
            set => Transform.localPosition = value;
        }

        internal TextMeshProUGUIC(in TextMeshProUGUI textMP)
        {
            TextMP = textMP;
        }
    }
}