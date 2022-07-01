using Cell.Model.Component;
using Cell.View.Component;
using UnityEngine;

namespace Cell.View.Entity
{
    public sealed class EntitiesView
    {
        public readonly AudioVE AudioE;

        public EntitiesView(out DataFromViewToModelC dataFromViewToModelC)
        {
            var commonGoForSounds = new GameObject("Sounds");

            var clickJumbleAS = commonGoForSounds.AddComponent<AudioSource>();
            clickJumbleAS.clip = Resources.Load<AudioClip>("ClickJumble");
            clickJumbleAS.volume = 0.4f;

            var appearanceAS = commonGoForSounds.AddComponent<AudioSource>();
            appearanceAS.clip = Resources.Load<AudioClip>("Appearance");
            appearanceAS.volume = 0.1f;


            AudioE = new AudioVE(new AudioSourceVC(clickJumbleAS), new AudioSourceVC(appearanceAS));


            dataFromViewToModelC = default;
        }
    }
}