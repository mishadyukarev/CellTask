using Cell.Model.Component;
using Cell.Model.Values;
using UnityEngine;
using Random = System.Random;

namespace Cell.Model.Entity
{
    public sealed class EntitiesModel
    {
        #region Variables

        readonly LetterE[] _letterEs = new LetterE[ValuesGame.MAX_X_AND_Y];


        #region NeedToPutInEntities
        //Тут я уже устал всё по Entities и компонентам раскидывать

        readonly int[,] _idxsletters = new int[ValuesGame.MAX_X, ValuesGame.MAX_Y];
        public bool NeedUpdateView;
        public readonly Random Random = new Random();

        public ActivatedLettersC ActivatedLettersC;
        public readonly DataFromViewToModelC DataFromViewToModelC;

        #endregion

        #endregion


        #region Properties

        public bool IsGeneratedLetters { get; internal set; }
        public Vector3 LocalScaleParentGrind { get; internal set; }

        public int AmountActivatedLettersByX
        {
            get => ActivatedLettersC.AmountLettersByX;
            internal set => ActivatedLettersC.AmountLettersByX = value;
        }
        public int AmountActivatedLettersByY
        {
            get => ActivatedLettersC.CurrentYLetters;
            internal set => ActivatedLettersC.CurrentYLetters = value;
        }
        public int AmountActivatedLetters => ActivatedLettersC.AmountActivatedLetters;

        public ref LetterE LetterE(in int idxLetter) => ref _letterEs[idxLetter];
        public int GetIdxByXyLetter(in int x, in int y) => _idxsletters[x, y];

        #endregion


        public EntitiesModel(in DataFromViewToModelC dataFromViewToModelC)
        {
            DataFromViewToModelC = dataFromViewToModelC;

            var currentIdxLetter = 0;
            for (var currentIdxX = 0; currentIdxX < ValuesGame.MAX_X; currentIdxX++)
            {
                for (var currentIdxY = 0; currentIdxY < ValuesGame.MAX_Y; currentIdxY++)
                {
                    var xy = new[] { currentIdxX, currentIdxY };

                    _letterEs[currentIdxLetter] = new LetterE(new XyC(xy), new IndexC(currentIdxLetter), new LocalPositionC(dataFromViewToModelC.PositionsLetters[currentIdxLetter]));

                    _idxsletters[currentIdxX, currentIdxY] = currentIdxLetter;

                    currentIdxLetter++;
                }
            }

            NeedUpdateView = true;
        }
    }
}