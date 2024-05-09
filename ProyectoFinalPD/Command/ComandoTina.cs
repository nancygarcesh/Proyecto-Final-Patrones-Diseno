using ProyectoFinalPD.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD
{
    public class ComandoTina : Comando
    {
        private HabitacionInteligente habitacion;
        private double temperatura;
        private string horario;

        public ComandoTina(HabitacionInteligente habitacion, double temperatura, string horario)
        {
            this.habitacion = habitacion;
            this.temperatura = temperatura;
            this.horario = horario;
        }

        public void ejecutar()
        {
            habitacion.llenarTina(temperatura, horario);
        }

        public void deshacer()
        {
            Console.WriteLine("Deshaciendo llenado de tina...");
        }
    }
}
