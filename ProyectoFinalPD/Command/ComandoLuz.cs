using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Command
{
    public class ComandoLuz : Comando
    {
        private HabitacionInteligente habitacion;
        private int intensidad;
        private string horario;

        public ComandoLuz(HabitacionInteligente habitacion, int intensidad, string horario)
        {
            this.habitacion = habitacion;
            this.intensidad = intensidad;
            this.horario = horario;
        }

        public void ejecutar()
        {
            habitacion.ajustarLuz(intensidad, horario);
        }

        public void deshacer()
        {
            Console.WriteLine("Deshaciendo ajuste de luz...");
        }
    }
}
