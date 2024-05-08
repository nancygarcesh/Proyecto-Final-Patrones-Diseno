using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Decorator
{
    public class GimnasioDecorator : ServicioDecorator
    {
        public GimnasioDecorator(PaqueteHabitacion paquete) : base(paquete) { }

        public override string ObtenerDescripcion()
        {
            return "Gimnasio(20 Bs)";
        }

        public override double CalcularCosto()
        {
            return base.CalcularCosto() + 20; // Precio del servicio de Gimnasio
        }
    }
}
