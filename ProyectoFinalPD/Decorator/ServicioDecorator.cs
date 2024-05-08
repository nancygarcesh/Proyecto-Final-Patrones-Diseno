using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalPD.Composite;

namespace ProyectoFinalPD.Decorator
{
    public abstract class ServicioDecorator : IPaqueteHabitacion
    {
        protected IPaqueteHabitacion paquete;

        public ServicioDecorator(IPaqueteHabitacion paquete)
        {
            this.paquete = paquete;
        }

        public virtual string ObtenerDescripcion()
        {
            return paquete.ObtenerDescripcion();
        }

        public virtual double ObtenerPrecio()
        {
            return paquete.ObtenerPrecio();
        }
    }
}
