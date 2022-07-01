using Cell.Model.Component;
using UnityEngine;

namespace Cell.Model.Entity
{
    public struct LetterE
    {
        public readonly XyC XyC;
        public readonly IndexC IndexC;
        public TextC TextC;
        public LocalPositionC LocalPositionC;

        public Vector3 PositionForShifting { get; internal set; } //Need to put in components
        public Vector3 LocalPosition
        {
            get => LocalPositionC.Position;
            internal set => LocalPositionC.Position = value;
        }

        internal LetterE(in XyC xyC, in IndexC indexC, in LocalPositionC localPosC) : this()
        {
            XyC = xyC;
            IndexC = indexC;
            LocalPositionC = localPosC;
        }
    }
}