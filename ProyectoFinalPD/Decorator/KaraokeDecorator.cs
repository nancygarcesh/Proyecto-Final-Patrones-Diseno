using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalPD.Composite;

namespace ProyectoFinalPD.Decorator
{
    public class KaraokeDecorator : ServicioDecorator
    {
        public KaraokeDecorator(IPaqueteHabitacion paquete) : base(paquete) { }

        public override string ObtenerDescripcion()
        {
            return "Karaoke(30 Bs)";
        }

        public override double ObtenerPrecio()
        {
            return base.ObtenerPrecio() + 30; // Precio del servicio de Karaoke
        }
    }
}
