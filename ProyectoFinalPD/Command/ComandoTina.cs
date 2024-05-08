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

        public ComandoTina(HabitacionInteligente habitacion, double temperatura)
        {
            this.habitacion = habitacion;
            this.temperatura = temperatura;
        }

        public void ejecutar()
        {
            habitacion.llenarTina(temperatura);
        }

        public void deshacer()
        {
            Console.WriteLine("Deshaciendo llenado de tina...");
        }
    }
}
