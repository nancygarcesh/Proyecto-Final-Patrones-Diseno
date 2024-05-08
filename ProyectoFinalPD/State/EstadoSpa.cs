using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.State
{
    public interface EstadoSpa
    {
        void Reservar(SistemaSpa contexto, string habitacion, string fechaHora);
        void CancelarReserva(SistemaSpa contexto);
    }
}
