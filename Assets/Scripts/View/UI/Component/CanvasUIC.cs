using UnityEngine;

namespace Cell.View.UI.Component
{
    readonly struct CanvasUIC
    {
        internal readonly Canvas Canvas;

        internal Transform Transform => Canvas.transform;

        internal CanvasUIC(in Canvas canvas)
        {
            Canvas = canvas;
        }
    }
}