using Cell.View.UI.Component;

namespace Cell.View.UI.Entity
{
    internal readonly struct GenerateLettersButtonUIE
    {
        internal readonly ButtonUIC ButtonC;
        internal readonly TextMeshProUGUIC TextC;

        internal GenerateLettersButtonUIE(in ButtonUIC buttonUIC, in TextMeshProUGUIC textC)
        {
            ButtonC = buttonUIC;
            TextC = textC;
        }
    }
}