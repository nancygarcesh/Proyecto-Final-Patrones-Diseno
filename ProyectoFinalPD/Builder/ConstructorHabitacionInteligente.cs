using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Builder
{
    public class ConstructorHabitacionInteligente : IConstructorHabitacion
    {
        private Habitacion habitacion = new Habitacion();

        public void ConstruirDesayuno()
        {
            habitacion.SetDesayuno(new DesayunoInteligente());
        }

        public void ConstruirServicioBar()
        {
            habitacion.SetServicioBar(new ServicioBarInteligente());
        }

        public void ConstruirAccesoAreasLudicas()
        {
            habitacion.SetAccesoAreasLudicas(new AccesoInteligente());
        }

        public void ConstruirServicioCena()
        {
            habitacion.SetServicioCena(new CenaInteligente());
        }

        public Habitacion ObtenerHabitacion()
        {
            return habitacion;
        }
    }

}
