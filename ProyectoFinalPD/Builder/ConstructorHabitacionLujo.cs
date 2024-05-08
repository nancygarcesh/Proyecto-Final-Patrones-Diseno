using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Builder
{
    public class ConstructorHabitacionLujo : IConstructorHabitacion
    {
        private Habitacion habitacion = new Habitacion();

        public void ConstruirDesayuno()
        {
            habitacion.SetDesayuno(new DesayunoLujo());
        }

        public void ConstruirServicioBar()
        {
            habitacion.SetServicioBar(new ServicioBarLujo());
        }

        public void ConstruirAccesoAreasLudicas()
        {
            habitacion.SetAccesoAreasLudicas(new AccesoLujo());
        }

        public void ConstruirServicioCena()
        {
            habitacion.SetServicioCena(new CenaLujo());
        }

        public Habitacion ObtenerHabitacion()
        {
            return habitacion;
        }
    }
}
