using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.State
{
    public class EstadoNoDisponible : EstadoSpa
    {
        public void Reservar(SistemaSpa contexto, string habitacion, string fechaHora)
        {
            Console.WriteLine("El Spa no está disponible en esta fecha y hora.");
        }

        public void CancelarReserva(SistemaSpa contexto)
        {
            Console.WriteLine("No hay reserva para cancelar en el Spa.");
        }
    }
}
