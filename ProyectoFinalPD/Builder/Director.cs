using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Builder
{
    public class Director
    {
        private IConstructorHabitacion constructor;

        public void ConstruirHabitacion()
        {
            constructor.ConstruirDesayuno();
            constructor.ConstruirServicioBar();
            constructor.ConstruirAccesoAreasLudicas();
            constructor.ConstruirServicioCena();
        }

        public void SetConstructor(IConstructorHabitacion constructor)
        {
            this.constructor = constructor;
        }
    }
}
