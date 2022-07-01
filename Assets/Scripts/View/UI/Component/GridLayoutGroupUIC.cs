using UnityEngine;
using UnityEngine.UI;

namespace Cell.View.UI.Component
{
    internal struct GridLayoutGroupUIC
    {
        internal readonly GridLayoutGroup GridLayoutGroup;

        internal Transform Transform => GridLayoutGroup.transform;

        internal GridLayoutGroupUIC(in GridLayoutGroup gridLayoutGroup)
        {
            GridLayoutGroup = gridLayoutGroup;
        }
    }
}