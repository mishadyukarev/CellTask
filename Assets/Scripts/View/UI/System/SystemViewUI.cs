using Cell.Model.Entity;
using Cell.Model.Interface;
using Cell.Model.Values;
using Cell.View.UI.Entity;

namespace Cell.View.UI.System
{
    public sealed class SystemViewUI : IUpdate
    {
        readonly EntitiesViewUI _eUI;
        readonly EntitiesModel _eM;

        public SystemViewUI(in EntitiesViewUI eUI, in EntitiesModel eM)
        {
            _eUI = eUI;
            _eM = eM;
        }

        public void Update()
        {
            if (_eM.NeedUpdateView)
            {
                _eUI.GridE.ParentTransformC.Transform.localScale = _eM.LocalScaleParentGrind;
                _eUI.GenerateLettersButtonE.TextC.Text = _eM.IsGeneratedLetters ? "Restart" : "Generate";
                _eUI.CanvasE.JumbleButtonC.Button.gameObject.SetActive(_eM.IsGeneratedLetters);

                for (var idxCurrentLetter = 0; idxCurrentLetter < ValuesGame.MAX_X_AND_Y; idxCurrentLetter++)
                {
                    var previousText = _eUI.LetterE(idxCurrentLetter).TextC.Text;

                    _eUI.LetterE(idxCurrentLetter).TextC.Text = _eM.LetterE(idxCurrentLetter).TextC.Text;
                    _eUI.LetterE(idxCurrentLetter).TextC.LocalPosition = _eM.LetterE(idxCurrentLetter).LocalPosition;

                    if (previousText != _eUI.LetterE(idxCurrentLetter).TextC.Text)
                    {
                        //Это можно как Action кинуть в Model в начале игры и от туда запускать
                        _eUI.LetterE(idxCurrentLetter).AnimationC.Play();
                        //
                    }
                }

                _eM.NeedUpdateView = false;
            }
        }
    }
}