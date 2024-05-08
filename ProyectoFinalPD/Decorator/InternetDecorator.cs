using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalPD.Composite;

namespace ProyectoFinalPD.Decorator
{
    public class InternetDecorator : ServicioDecorator
    {
        public InternetDecorator(IPaqueteHabitacion paquete) : base(paquete) { }

        public override string ObtenerDescripcion()
        {
            return "Internet(10 Bs)";
        }

        public override double ObtenerPrecio()
        {
            return base.ObtenerPrecio() + 10; // Precio del servicio de Internet
        }
    }
}
