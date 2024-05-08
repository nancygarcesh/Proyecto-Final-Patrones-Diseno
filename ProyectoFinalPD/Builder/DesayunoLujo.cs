using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Builder
{
    public class DesayunoLujo : Desayuno
    {
        public string DetalleDesayuno()
        {
            return "Una infusión, un jugo de frutas, pan, galletas, ración de alimento cocinado";
        }
    }
}
