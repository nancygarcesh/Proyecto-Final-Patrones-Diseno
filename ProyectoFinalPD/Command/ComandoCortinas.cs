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

        public ComandoCortinas(HabitacionInteligente habitacion, bool abiertas)
        {
            this.habitacion = habitacion;
            this.abiertas = abiertas;
        }

        public void ejecutar()
        {
            habitacion.moverCortinas(abiertas);
        }

        public void deshacer()
        {
            Console.WriteLine("Deshaciendo movimiento de cortinas...");
        }
    }
}
