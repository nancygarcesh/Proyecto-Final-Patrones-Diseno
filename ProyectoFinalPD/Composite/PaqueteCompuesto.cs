using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Composite
{
    public class PaqueteCompuesto : IPaqueteHabitacion
    {
        private List<IPaqueteHabitacion> hijos = new List<IPaqueteHabitacion>();
        private double descuento;

        public void Agregar(IPaqueteHabitacion paquete)
        {
            hijos.Add(paquete);
        }

        public void Remover(IPaqueteHabitacion paquete)
        {
            hijos.Remove(paquete);
        }

        public double ObtenerPrecio()
        {
            double precioTotal = 0;
            foreach (var paquete in hijos)
            {
                precioTotal += paquete.ObtenerPrecio();
            }
            return precioTotal * (1 - descuento);
        }

        public string ObtenerDescripcion()
        {
            string descripcion = "";
            foreach (var paquete in hijos)
            {
                descripcion += paquete.ObtenerDescripcion() + "\n";
            }
            return descripcion;
        }

        public void EstablecerDescuento(double descuento)
        {
            this.descuento = descuento;
        }
    }
}
