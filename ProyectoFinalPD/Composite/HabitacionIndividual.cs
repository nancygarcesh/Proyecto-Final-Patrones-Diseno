using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Composite
{
    public class HabitacionIndividual : IPaqueteHabitacion
    {
        private double precio;
        private string descripcion;

        public HabitacionIndividual(double precio, string descripcion)
        {
            this.precio = precio;
            this.descripcion = descripcion;
        }

        public string ObtenerDescripcion()
        {
            return descripcion;
        }

        public double ObtenerPrecio()
        {
            return precio;
        }
    }
}
