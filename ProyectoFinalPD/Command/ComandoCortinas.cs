using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Command
{
    public class ComandoCortinas : Comando
    {
        private HabitacionInteligente habitacion;
        private bool abiertas;
        private string horario;

        public ComandoCortinas(HabitacionInteligente habitacion, bool abiertas, string horario)
        {
            this.habitacion = habitacion;
            this.abiertas = abiertas;
            this.horario = horario;
        }

        public void ejecutar()
        {
            habitacion.moverCortinas(abiertas, horario);
        }

        public void deshacer()
        {
            Console.WriteLine("Deshaciendo movimiento de cortinas...");
        }
    }
}
