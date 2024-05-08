using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Mediator
{
    public interface Mediador
    {
        void Notificar(Colega emisor, string evento);
    }
}
