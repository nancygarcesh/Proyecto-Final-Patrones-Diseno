using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Mediator
{
    public class Recepcion : Mediador
    {
        private Mantenimiento mantenimiento;
        private Limpieza limpieza;
        private Cocina cocina;
        private Bar bar;

        public Recepcion(Mantenimiento mantenimiento, Limpieza limpieza, Cocina cocina, Bar bar)
        {
            this.mantenimiento = mantenimiento;
            this.limpieza = limpieza;
            this.cocina = cocina;
            this.bar = bar;
        }

        public void Notificar(Colega emisor, string evento)
        {
            // Recepción recibe la notificación y determina qué colega debe manejar el evento
            if (emisor is Mantenimiento)
            {
                // Lógica para coordinar con Mantenimiento
                Console.WriteLine("Recepción: Solicitud de mantenimiento recibida.");
                mantenimiento.RecibirMensaje(evento);
            }
            else if (emisor is Limpieza)
            {
                // Lógica para coordinar con Limpieza
                Console.WriteLine("Recepción: Solicitud de limpieza recibida.");
                limpieza.RecibirMensaje(evento);
            }
            else if (emisor is Cocina)
            {
                // Lógica para coordinar con Cocina
                Console.WriteLine("Recepción: Solicitud de comida recibida.");
                cocina.RecibirMensaje(evento);
            }
            else if (emisor is Bar)
            {
                // Lógica para coordinar con Bar
                Console.WriteLine("Recepción: Solicitud de bebida recibida.");
                bar.RecibirMensaje(evento);
            }
        }
    }
}
