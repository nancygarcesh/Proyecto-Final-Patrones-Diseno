using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProyectoFinalPD.Composite;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Decorator
{
    public class PaqueteBase : IPaqueteHabitacion
    {
        private string descripcion;
        private double costoBase;

        public PaqueteBase()
        {
            descripcion = "Paquete Base (Internet + Gimnasio)";
            costoBase = 0; // Precio base del paquete sin servicios adicionales
        }

        public string ObtenerDescripcion()
        {
            return descripcion;
        }

        public double ObtenerPrecio()
        {
            return costoBase;
        }
    }
}
