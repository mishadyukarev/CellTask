using UnityEngine;

namespace Cell.Model.Component
{
    public struct LocalPositionC
    {
        public Vector3 Position { get; internal set; }

        internal LocalPositionC(in Vector3 pos) => Position = pos; 
    }
}