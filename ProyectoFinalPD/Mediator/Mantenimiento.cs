using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Mediator
{
    public class Mantenimiento : Colega
    {
        public override void RecibirMensaje(string mensaje)
        {
            // Lógica para manejar la solicitud de mantenimiento
            Console.WriteLine("Mantenimiento: Solicitud recibida - " + mensaje);
        }

    }
}
