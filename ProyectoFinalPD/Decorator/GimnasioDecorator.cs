using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalPD.Composite;

namespace ProyectoFinalPD.Decorator
{
    public class GimnasioDecorator : ServicioDecorator
    {
        public GimnasioDecorator(IPaqueteHabitacion paquete) : base(paquete) { }

        public override string ObtenerDescripcion()
        {
            return "Gimnasio(20 Bs)";
        }

        public override double ObtenerPrecio()
        {
            return base.ObtenerPrecio() + 20; // Precio del servicio de Gimnasio
        }
    }
}
