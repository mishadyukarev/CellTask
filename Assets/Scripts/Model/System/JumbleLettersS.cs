using Cell.Model.Interface;
using Cell.Model.Values;
using UnityEngine;

namespace Cell.Model.System
{
    public sealed partial class SystemsModel : IUpdate
    {
        const int MAX_NUMBER_FOR_FINDING_DIRECT_LETTER = 200;
        const int INDEX_FIRST_LETTER = 0;

        public void Jumble()
        {
            for (var idxCurLetter = 0; idxCurLetter < ValuesGame.MAX_X_AND_Y; idxCurLetter++)
            {
                if (_eM.LetterE(idxCurLetter).TextC.Text != default)
                {
                    if (_eM.LetterE(idxCurLetter).PositionForShifting == default)
                    {
                        for (var i = 0; i < MAX_NUMBER_FOR_FINDING_DIRECT_LETTER; i++)
                        {
                            var directedIdxLetter = Random.Range(INDEX_FIRST_LETTER, ValuesGame.MAX_X_AND_Y);

                            if (_eM.LetterE(directedIdxLetter).TextC.Text != default)
                            {
                                if (_eM.LetterE(directedIdxLetter).PositionForShifting == default)
                                {
                                    _eM.LetterE(idxCurLetter).PositionForShifting = _eM.LetterE(directedIdxLetter).LocalPosition;
                                    _eM.LetterE(directedIdxLetter).PositionForShifting = _eM.LetterE(idxCurLetter).LocalPosition;

                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}