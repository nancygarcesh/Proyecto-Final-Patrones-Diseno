using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Builder
{
    public class DesayunoEstandar : Desayuno
    {
        public string DetalleDesayuno()
        {
            return "Una infusión, pan, galletas, mermeladas";
        }
    }
}
