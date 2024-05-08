using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Decorator
{
    public abstract class PaqueteHabitacion
    {
        public abstract string ObtenerDescripcion();
        public abstract double CalcularCosto();
    }
}
