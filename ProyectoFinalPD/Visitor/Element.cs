using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Visitor
{
    public interface Element
    {
        void accept(Visitor visitor);
        double CalcularCosto();
    }
}
