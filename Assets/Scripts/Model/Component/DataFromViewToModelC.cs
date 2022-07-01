using UnityEngine;

namespace Cell.Model.Component
{
    public struct DataFromViewToModelC
    {
        public readonly Vector3 PositionCanvas;
        public readonly Vector3[] PositionsLetters;

        public DataFromViewToModelC(in Vector3 positionCanvas, in Vector3[] positionsLetters)
        {
            PositionCanvas = positionCanvas;
            PositionsLetters = positionsLetters;
        }
    }
}