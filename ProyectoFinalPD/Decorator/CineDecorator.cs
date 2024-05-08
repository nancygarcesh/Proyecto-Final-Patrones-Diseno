using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalPD.Composite;

namespace ProyectoFinalPD.Decorator
{
    public class CineDecorator : ServicioDecorator
    {
        public CineDecorator(IPaqueteHabitacion paquete) : base(paquete) { }

        public override string ObtenerDescripcion()
        {
            return "Cine(30 Bs)";
        }

        public override double ObtenerPrecio()
        {
            return base.ObtenerPrecio() + 30; // Precio del servicio de Cine
        }
    }
}
