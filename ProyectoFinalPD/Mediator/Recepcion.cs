﻿using ProyectoFinalPD.Command;
using ProyectoFinalPD.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        private Spa1 spa1;

        public Recepcion(Mantenimiento mantenimiento, Limpieza limpieza, Cocina cocina, Bar bar, Spa1 spa1)
        {
            this.mantenimiento = mantenimiento;
            this.limpieza = limpieza;
            this.cocina = cocina;
            this.bar = bar;
            this.spa1 = spa1;
        }

        public void Notificar(Colega emisor, string evento)
        {
            // Recepción recibe la notificación y determina qué colega debe manejar el evento
            if (emisor is Mantenimiento)
            {
                Console.WriteLine("Recepción: Solicitud de mantenimiento recibida.");
                mantenimiento.RecibirMensaje(evento);
            }
            else if (emisor is Limpieza)
            {
                Console.WriteLine("Recepción: Solicitud de limpieza recibida.");
                limpieza.RecibirMensaje(evento);
            }
            else if (emisor is Cocina)
            {
                Console.WriteLine("Recepción: Solicitud de comida recibida.");
                cocina.RecibirMensaje(evento);
            }
            else if (emisor is Bar)
            {
                Console.WriteLine("Recepción: Solicitud de bebida recibida.");
                bar.RecibirMensaje(evento);
            }
            else if (emisor is Spa1)
            {
                Console.WriteLine("Recepción: Solicitud de spa recibida.");
                spa1.RecibirMensaje(evento);
            }
        }

        // Método para ejecutar un comando específico en Recepcion
        public void EjecutarComando(Comando comando)
        {
            comando.ejecutar();
        }

        // Método para generar un reporte visitando todos los colegas
        public void GenerarReporte(ReporteVisitor reporte)
        {

            Console.WriteLine("Reporte de servicios generado!");

        }
    }
}
