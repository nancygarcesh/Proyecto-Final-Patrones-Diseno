using ProyectoFinalPD.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Command
{
    public class ControladorApp
    {
        private List<Comando> comandos = new List<Comando>();
        private Recepcion recepcion; // Agregamos una referencia a Recepcion

        public ControladorApp()
        {
        }

        public void AnadirComando(Comando comando)
        {
            comandos.Add(comando);
        }

        public void EliminarComando(Comando comando)
        {
            comandos.Remove(comando);
        }

        public void EjecutarComandos()
        {
            foreach (var comando in comandos)
            {
                comando.ejecutar();
            }
        }

        // Método para enviar un comando a Recepcion
        public void EnviarComandoARecepcion(Comando comando)
        {
            recepcion.EjecutarComando(comando);
        }
    }
}
