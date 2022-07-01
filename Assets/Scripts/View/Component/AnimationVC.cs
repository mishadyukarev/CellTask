using UnityEditor;
using UnityEngine;

namespace Cell.View.Component
{
    public readonly struct AnimationVC
    {
        public readonly Animation Animation;

        public AnimationVC(in Animation animation) => Animation = animation;

        public void Play() => Animation.Play();
    }
}