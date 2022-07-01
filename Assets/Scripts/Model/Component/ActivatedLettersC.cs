namespace Cell.Model.Component
{
    public struct ActivatedLettersC
    {
        public int AmountLettersByX { get; internal set; }
        public int CurrentYLetters { get; internal set; }

        public int AmountActivatedLetters => AmountLettersByX * CurrentYLetters;
    }
}