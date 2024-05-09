using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Composite
{
    public class Cliente
    {
        public void HacerReservacion(IPaqueteHabitacion paquete)
        {
            Console.WriteLine("Reserva realizada:");
            Console.WriteLine("Descripción: " + paquete.ObtenerDescripcion());
            Console.WriteLine("Precio: " + paquete.ObtenerPrecio() + "Bs");
        }
    }
}
