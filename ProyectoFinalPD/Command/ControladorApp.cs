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

        public void anadirComando(Comando comando)
        {
            comandos.Add(comando);
        }

        public void eliminarComando(Comando comando)
        {
            comandos.Remove(comando);
        }

        public void ejecutarComandos()
        {
            foreach (var comando in comandos)
            {
                comando.ejecutar();
            }
        }
    }
}
