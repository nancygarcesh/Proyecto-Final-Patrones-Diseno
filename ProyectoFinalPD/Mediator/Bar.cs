using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Mediator
{
    public class Bar : Colega
    {
        public override void RecibirMensaje(string mensaje)
        {
            // Lógica para manejar la solicitud de bebida
            Console.WriteLine("Bar: Solicitud recibida - " + mensaje);
        }
    }
}
