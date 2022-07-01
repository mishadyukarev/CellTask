using Cell.View.Component;
using Cell.View.UI.Component;

namespace Cell.View.UI.Entity
{
    readonly struct CanvasUIE
    {
        internal readonly CanvasUIC CanvasC;
        internal readonly ButtonUIC JumbleButtonC;
        internal readonly TMP_InputFieldUIC InputXC;
        internal readonly TMP_InputFieldUIC InputYC;

        internal CanvasUIE(in (CanvasUIC, ButtonUIC, TMP_InputFieldUIC, TMP_InputFieldUIC) canvas)
        {
            CanvasC = canvas.Item1;
            JumbleButtonC = canvas.Item2;
            InputXC = canvas.Item3;
            InputYC = canvas.Item4;
        }
    }
}