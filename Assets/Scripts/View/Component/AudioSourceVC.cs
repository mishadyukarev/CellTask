using UnityEngine;

namespace Cell.View.Component
{
    public readonly struct AudioSourceVC
    {
        public readonly AudioSource AudioS;

        internal AudioSourceVC(in AudioSource aS) => AudioS = aS;
    }
}