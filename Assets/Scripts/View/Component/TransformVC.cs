using UnityEngine;

namespace Cell.View.Component
{
    public readonly struct TransformVC
    {
        public readonly Transform Transform;

        public TransformVC(in Transform transform) => Transform = transform;
    }
}