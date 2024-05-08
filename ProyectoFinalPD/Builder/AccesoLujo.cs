using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Builder
{
    public class AccesoLujo : AccesoAreasLudicas
    {
        public string DetalleAcceso()
        {
            return "Ilimitado: piscina, juegos infantiles, casino";
        }
    }
}
