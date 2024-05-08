using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Mediator
{
    public abstract class Colega
    {
        public Mediador mediador;

        public void SetMediador(Mediador mediador)
        {
            this.mediador = mediador;
        }

        public abstract void RecibirMensaje(string mensaje);
    }
}
