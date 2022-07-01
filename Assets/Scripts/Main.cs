using Cell.Model.Entity;
using Cell.Model.Interface;
using Cell.Model.System;
using Cell.View.Entity;
using Cell.View.System;
using Cell.View.UI.Entity;
using Cell.View.UI.System;
using System.Collections.Generic;
using UnityEngine;

namespace Cell
{
    sealed class Main : MonoBehaviour
    {
        List<IUpdate> _updates;

        void Start()
        { 
            var eV = new EntitiesView(out var dataFromViewToModelC);
            var eUI = new EntitiesViewUI(ref dataFromViewToModelC);
            var eM = new EntitiesModel(dataFromViewToModelC);

            var sM = new SystemsModel(eM);
            var sV = new SystemsView(eV, eM);
            var sUI = new SystemViewUI(eUI, eM);

            new EnventButtonsUIS(eV, eUI, eM, sV, sM); 

            _updates = new List<IUpdate>()
            {
                sM,

                sV,
                sUI,
            };
        }

        void Update() => _updates.ForEach((IUpdate iUpdate) => iUpdate.Update());
    }
}
