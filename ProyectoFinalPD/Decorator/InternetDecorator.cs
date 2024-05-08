using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Decorator
{
    public class InternetDecorator : ServicioDecorator
    {
        public InternetDecorator(PaqueteHabitacion paquete) : base(paquete) { }

        public override string ObtenerDescripcion()
        {
            return "Internet(10 Bs)";
        }

        public override double CalcularCosto()
        {
            return base.CalcularCosto() + 10; // Precio del servicio de Internet
        }
    }
}
