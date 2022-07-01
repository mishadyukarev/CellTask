using Cell.View.Component;
using Cell.View.UI.Component;

namespace Cell.View.UI.Entity
{
    readonly struct GridUIE
    {
        internal readonly TransformVC ParentTransformC;
        internal readonly GridLayoutGroupUIC GridLayoutGroupC;

        internal GridUIE(in TransformVC parentGrindC, in GridLayoutGroupUIC gridLayoutGroupC)
        {
            ParentTransformC = parentGrindC;
            GridLayoutGroupC = gridLayoutGroupC;
        }
    }
}