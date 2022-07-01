using Cell.Model.Entity;
using Cell.Model.System;
using Cell.Model.Values;
using Cell.View.Entity;
using Cell.View.System;
using Cell.View.UI.Entity;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Cell.View.UI.System
{
    public sealed class EnventButtonsUIS
    {
        public EnventButtonsUIS(EntitiesView eV, EntitiesViewUI eUI, EntitiesModel eM, SystemsView sV, SystemsModel sM)
        {
            //Эти все методы нужно в Model перенести, а .Play() закинуть в Model при старте игры как Action

            eUI.GenerateLettersButtonE.ButtonC.AddListener(() =>
            {
                if (!eM.IsGeneratedLetters)
                {
                    sM.GenerateLetters(eUI.CanvasE.InputXC.Text, eUI.CanvasE.InputYC.Text);

                    eV.AudioE.AfterClickGenerateASVC.AudioS.Play();
                }
                else
                {
                    ValuesGame.StartXForUIBar = int.Parse(eUI.CanvasE.InputXC.Text);
                    ValuesGame.StartYForUIBar = int.Parse(eUI.CanvasE.InputYC.Text);

                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }

            });
            eUI.CanvasE.JumbleButtonC.AddListener(() =>
            {
                if (eM.IsGeneratedLetters)
                {
                    sM.Jumble();

                    eV.AudioE.AfterClickJumbleASVC.AudioS.Play();
                }
            });

            eUI.CanvasE.InputXC.TMP_InputField.onValueChanged.AddListener((string text) =>
            {
                if (int.TryParse(eUI.CanvasE.InputXC.Text, out var num))
                {
                    if (num > ValuesGame.MAX_X) num = ValuesGame.MAX_X;
                    else if (num < ValuesGame.MIN_X) num = ValuesGame.MIN_X;

                    eUI.CanvasE.InputXC.TMP_InputField.text = num.ToString();
                }
            });

            eUI.CanvasE.InputYC.TMP_InputField.onValueChanged.AddListener((string text) =>
            {
                if (int.TryParse(eUI.CanvasE.InputYC.Text, out var num))
                {
                    if (num > ValuesGame.MAX_Y) num = ValuesGame.MAX_Y;
                    else if (num < ValuesGame.MIN_Y) num = ValuesGame.MIN_Y;

                    eUI.CanvasE.InputYC.TMP_InputField.text = num.ToString();
                }
            });
        }
    }
}