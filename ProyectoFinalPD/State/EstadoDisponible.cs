using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.State
{
    public class EstadoDisponible : EstadoSpa
    {
        public void Reservar(SistemaSpa contexto, string habitacion, string fechaHora)
        {
            Console.WriteLine("Reservando el Spa para la habitación " + habitacion + " a las " + fechaHora + ".");
            contexto.SetEstado(new EstadoReservado());
        }

        public void CancelarReserva(SistemaSpa contexto)
        {
            Console.WriteLine("No hay reserva para cancelar en el Spa.");
        }
    }
}
