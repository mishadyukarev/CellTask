using Cell.Model.Entity;
using Cell.Model.Interface;
using Cell.Model.Values;
using UnityEngine;

namespace Cell.Model.System
{
    public sealed partial class SystemsModel : IUpdate
    {
        readonly EntitiesModel _eM;

        public SystemsModel(in EntitiesModel eM)
        {
            _eM = eM;
        }

        public void Update()
        {
            for (var idxCurLetter = 0; idxCurLetter < ValuesGame.MAX_X_AND_Y; idxCurLetter++)
            {
                if (_eM.LetterE(idxCurLetter).PositionForShifting != default)
                {
                    _eM.LetterE(idxCurLetter).LocalPosition = Vector3.MoveTowards(_eM.LetterE(idxCurLetter).LocalPosition, _eM.LetterE(idxCurLetter).PositionForShifting, ValuesGame.SPEED_SHIFTING_LETTERS * Time.deltaTime);

                    if ((_eM.LetterE(idxCurLetter).PositionForShifting - _eM.LetterE(idxCurLetter).LocalPosition).magnitude <= 0)
                    {
                        _eM.LetterE(idxCurLetter).PositionForShifting = default;
                    }

                    //Тут можно не всё обновлять, а только те клетки, что перемещяются
                    _eM.NeedUpdateView = true;
                    //
                }
            }
        }  
    }
}