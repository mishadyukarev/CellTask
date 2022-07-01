using Cell.Model.Interface;
using UnityEngine;

namespace Cell.Model.System
{
    public sealed partial class SystemsModel : IUpdate
    {
        public void GenerateLetters(in string textFromInputX, in string textFromInputY)
        {
            _eM.AmountActivatedLettersByX = int.Parse(textFromInputX);
            _eM.AmountActivatedLettersByY = int.Parse(textFromInputY);

            var xyForGrind = 1f;
            var reductionRatio = 0.14f;

            var amountMaxActivatedLetters = _eM.AmountActivatedLettersByX >= _eM.AmountActivatedLettersByY ? _eM.AmountActivatedLettersByX : _eM.AmountActivatedLettersByY;
            xyForGrind /= amountMaxActivatedLetters * reductionRatio;

            _eM.LocalScaleParentGrind = new Vector3(xyForGrind, xyForGrind);


            for (var XcurrentIdx = 0; XcurrentIdx < _eM.AmountActivatedLettersByX; XcurrentIdx++)
            {
                for (var YcurrentIdx = 0; YcurrentIdx < _eM.AmountActivatedLettersByY; YcurrentIdx++)
                {
                    var idxCurrentLetter = _eM.GetIdxByXyLetter(XcurrentIdx, YcurrentIdx);

                    var letterTextChar = (char)_eM.Random.Next('A', 'Z' + 1);
                    _eM.LetterE(idxCurrentLetter).TextC.Text = letterTextChar.ToString();
                }
            }



            _eM.IsGeneratedLetters = true;

            _eM.NeedUpdateView = true;
        }
    }
}