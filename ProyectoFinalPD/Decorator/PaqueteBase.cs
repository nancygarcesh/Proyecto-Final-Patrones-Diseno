using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Decorator
{
    public class PaqueteBase : PaqueteHabitacion
    {
        private string descripcion;
        private double costoBase;

        public PaqueteBase()
        {
            descripcion = "Paquete Base (Internet + Gimnasio)";
            costoBase = 0; // Precio base del paquete sin servicios adicionales
        }

        public override string ObtenerDescripcion()
        {
            return descripcion;
        }

        public override double CalcularCosto()
        {
            return costoBase;
        }
    }
}
