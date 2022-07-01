using Cell.View.Component;
using Cell.View.UI.Component;

namespace Cell.View.UI.Entity
{
    readonly struct LetterUIE
    {
        internal readonly TextMeshProUGUIC TextC;
        internal readonly AnimationVC AnimationC;

        internal LetterUIE(in TextMeshProUGUIC textC, in AnimationVC animationC)
        {
            TextC = textC;
            AnimationC = animationC;
        }
    }
}