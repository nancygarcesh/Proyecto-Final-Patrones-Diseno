using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.State
{
    public class SistemaSpa
    {
        private EstadoSpa estadoActual;

        public SistemaSpa()
        {
            estadoActual = new EstadoDisponible();
        }

        public void SetEstado(EstadoSpa nuevoEstado)
        {
            estadoActual = nuevoEstado;
        }

        public void Reservar(string habitacion, string fechaHora)
        {
            estadoActual.Reservar(this, habitacion, fechaHora);
        }

        public void CancelarReserva()
        {
            estadoActual.CancelarReserva(this);
        }
    }
}
