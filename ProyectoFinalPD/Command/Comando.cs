using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Command
{
    public interface Comando
    {
        void ejecutar();
        void deshacer();
    }
}
