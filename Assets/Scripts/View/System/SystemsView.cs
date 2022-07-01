using Cell.Model.Entity;
using Cell.Model.Interface;
using Cell.View.Entity;

namespace Cell.View.System
{
    public sealed class SystemsView : IUpdate
    {
        readonly EntitiesModel _eM;
        readonly EntitiesView _eV;

        public SystemsView(in EntitiesView eV, in EntitiesModel eM)
        {
            _eV = eV;
            _eM = eM;
        }

        public void Update()
        {
            //Тут весь визуал кроме UI обрабатывается
        }
    }
}