using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Builder
{
    public interface IConstructorHabitacion
    {
        void ConstruirDesayuno();
        void ConstruirServicioBar();
        void ConstruirAccesoAreasLudicas();
        void ConstruirServicioCena();
        Habitacion ObtenerHabitacion();

    }
}
