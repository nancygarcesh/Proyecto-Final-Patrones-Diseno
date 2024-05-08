using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Builder
{
    public class ConstructorHabitacionEstandar : IConstructorHabitacion
    {
        private Habitacion habitacion = new Habitacion();

        public void ConstruirDesayuno()
        {
            habitacion.SetDesayuno(new DesayunoEstandar());
        }

        public void ConstruirServicioBar()
        {
            habitacion.SetServicioBar(new ServicioBarEstandar());
        }

        public void ConstruirAccesoAreasLudicas()
        {
            habitacion.SetAccesoAreasLudicas(new AccesoEstandar());
        }

        public void ConstruirServicioCena()
        {
            habitacion.SetServicioCena(new CenaEstandar());
        }

        public Habitacion ObtenerHabitacion()
        {
            return habitacion;
        }
    }
}
