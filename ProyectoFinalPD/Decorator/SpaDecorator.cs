using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Decorator
{
    public class SpaDecorator : ServicioDecorator
    {
        public SpaDecorator(PaqueteHabitacion paquete) : base(paquete) { }

        public override string ObtenerDescripcion()
        {
            return "Spa(20 Bs)";
        }

        public override double CalcularCosto()
        {
            return base.CalcularCosto() + 20; // Precio del servicio de Spa
        }
    }
}
