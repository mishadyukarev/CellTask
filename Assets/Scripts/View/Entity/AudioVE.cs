using Cell.View.Component;

namespace Cell.View.Entity
{
    public readonly struct AudioVE
    {
        public readonly AudioSourceVC AfterClickJumbleASVC;
        public readonly AudioSourceVC AfterClickGenerateASVC;

        internal AudioVE(in AudioSourceVC afterClickJumbleASC, AudioSourceVC afterClickGenerateASVC)
        {
            AfterClickJumbleASVC = afterClickJumbleASC;
            AfterClickGenerateASVC = afterClickGenerateASVC;
        }
    }
}