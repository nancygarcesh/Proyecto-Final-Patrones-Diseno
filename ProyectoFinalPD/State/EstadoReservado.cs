using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.State
{
    public class EstadoReservado : EstadoSpa
    {
        public void Reservar(SistemaSpa contexto, string habitacion, string fechaHora)
        {
            Console.WriteLine("El Spa ya está reservado para esta fecha y hora.");
        }

        public void CancelarReserva(SistemaSpa contexto)
        {
            Console.WriteLine("Cancelando la reserva del Spa.");
            contexto.SetEstado(new EstadoDisponible());
        }
    }
}
