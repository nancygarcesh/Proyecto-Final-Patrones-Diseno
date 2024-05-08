using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalPD.Composite;

namespace ProyectoFinalPD.Decorator
{
    public class SpaDecorator : ServicioDecorator
    {
        public SpaDecorator(IPaqueteHabitacion paquete) : base(paquete) { }

        public override string ObtenerDescripcion()
        {
            return "Spa(20 Bs)";
        }

        public override double ObtenerPrecio()
        {
            return base.ObtenerPrecio() + 20; // Precio del servicio de Spa
        }
    }
}



/* 
 
 public abstract class PaqueteHabitacion
    {
        public abstract string ObtenerDescripcion();
        public abstract double CalcularCosto();
    }
 */
