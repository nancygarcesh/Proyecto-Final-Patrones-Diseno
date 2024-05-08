using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Visitor
{
    public interface Visitor
    {
        void visitEleccion(Eleccion eleccion);
    }
}
