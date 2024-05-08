using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Decorator
{
    public class CineDecorator : ServicioDecorator
    {
        public CineDecorator(PaqueteHabitacion paquete) : base(paquete) { }

        public override string ObtenerDescripcion()
        {
            return "Cine(30 Bs)";
        }

        public override double CalcularCosto()
        {
            return base.CalcularCosto() + 30; // Precio del servicio de Cine
        }
    }
}
