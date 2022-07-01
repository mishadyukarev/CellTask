using Cell.Model.Component;
using Cell.Model.Values;
using Cell.View.Component;
using Cell.View.UI.Component;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cell.View.UI.Entity
{
    public sealed class EntitiesViewUI
    {
        readonly LetterUIE[] _letterUIEs = new LetterUIE[ValuesGame.MAX_X_AND_Y];
        internal readonly GenerateLettersButtonUIE GenerateLettersButtonE;
        internal readonly CanvasUIE CanvasE;
        internal readonly GridUIE GridE;

        internal LetterUIE LetterE(in int letterIdx) => _letterUIEs[letterIdx];


        public EntitiesViewUI(ref DataFromViewToModelC dataFromViewToModelC)
        {
            var canvas = GameObject.Find("Canvas+").GetComponent<Canvas>();

            var canvasT = canvas.transform;

            var generatButton = canvasT.Find("GenerationButton+");

            GenerateLettersButtonE = new GenerateLettersButtonUIE(new ButtonUIC(generatButton.GetComponent<Button>()), 
                new TextMeshProUGUIC(generatButton.Find("Text (TMP)").GetComponent<TextMeshProUGUI>()));


            var parentGrind = canvasT.Find("ParentGrind+");
            GridE = new GridUIE(new TransformVC(parentGrind), new GridLayoutGroupUIC(parentGrind.Find("GridLayoutGroup+").GetComponent<GridLayoutGroup>()));


            CanvasE = new CanvasUIE((new CanvasUIC(canvas), new ButtonUIC(canvasT.Find("JumbleButton+").GetComponent<Button>()),
                new TMP_InputFieldUIC(canvasT.Find("InputX+").GetComponent<TMP_InputField>()), new TMP_InputFieldUIC(canvasT.Find("InputY+").GetComponent<TMP_InputField>())));


            CanvasE.InputXC.Text = ValuesGame.StartXForUIBar.ToString();
            CanvasE.InputYC.Text = ValuesGame.StartYForUIBar.ToString();


            var posLetters = new Vector3[ValuesGame.MAX_X_AND_Y];

            var idxCurrentLetter = 0;

            for (var currentX = 0; currentX < ValuesGame.MAX_X; currentX++)
            {
                for (var currentY = 0; currentY < ValuesGame.MAX_Y; currentY++)
                {
                    var letterTMP = GridE.GridLayoutGroupC.Transform.Find("LetterTMP+ " + "(" + idxCurrentLetter + ")").GetComponent<TextMeshProUGUI>();


                    _letterUIEs[idxCurrentLetter] = new LetterUIE(new TextMeshProUGUIC(letterTMP), new AnimationVC(letterTMP.GetComponent<Animation>()));

                    posLetters[idxCurrentLetter] = letterTMP.transform.localPosition;

                    idxCurrentLetter++;
                }
            }


            dataFromViewToModelC = new DataFromViewToModelC(canvasT.position, posLetters);
        }
    }
}