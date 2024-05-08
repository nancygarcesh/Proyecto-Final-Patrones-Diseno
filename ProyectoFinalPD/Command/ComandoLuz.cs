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

        public ComandoLuz(HabitacionInteligente habitacion, int intensidad)
        {
            this.habitacion = habitacion;
            this.intensidad = intensidad;
        }

        public void ejecutar()
        {
            habitacion.ajustarLuz(intensidad);
        }

        public void deshacer()
        {
            Console.WriteLine("Deshaciendo ajuste de luz...");
        }
    }
}
