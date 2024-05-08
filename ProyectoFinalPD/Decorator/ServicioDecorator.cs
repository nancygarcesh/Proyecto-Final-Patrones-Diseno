using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Decorator
{
    public abstract class ServicioDecorator : PaqueteHabitacion
    {
        protected PaqueteHabitacion paquete;

        public ServicioDecorator(PaqueteHabitacion paquete)
        {
            this.paquete = paquete;
        }

        public override string ObtenerDescripcion()
        {
            return paquete.ObtenerDescripcion();
        }

        public override double CalcularCosto()
        {
            return paquete.CalcularCosto();
        }
    }
}
