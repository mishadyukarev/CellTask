using TMPro;

namespace Cell.View.UI.Component
{
    public readonly struct TMP_InputFieldUIC
    {
        public readonly TMP_InputField TMP_InputField;

        public string Text
        {
            get => TMP_InputField.text;
            set => TMP_InputField.text = value;
        }

        internal TMP_InputFieldUIC(in TMP_InputField tMP_InputField)
        {
            TMP_InputField = tMP_InputField;
        }
    }
}