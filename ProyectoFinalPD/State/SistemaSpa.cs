using ProyectoFinalPD.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.State
{
    public class SistemaSpa : IElement
    {
        private EstadoSpa estadoActual;
        private Spa1 spa;

        public SistemaSpa()
        {
            estadoActual = new EstadoDisponible();
            spa = new Spa1(0, 0); // Supongamos que se inicializa con valores por defecto
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

        public Spa1 GetSpa()
        {
            return spa;
        }

        // Implementación de Element para aceptar visitas
        public void Accept(IVisitor visitor)
        {
            spa.Accept(visitor);
        }
    }
}
