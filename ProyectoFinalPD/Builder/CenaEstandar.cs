using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Builder
{
    public class CenaEstandar : ServicioCena
    {
        public string DetalleServicioCena()
        {
            return "1 plato del día por persona + refresco";
        }
    }
}
