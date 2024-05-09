using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Command
{
    public class ComandoMusica : Comando
    {
        private HabitacionInteligente habitacion;
        private string artista;
        private int volumen;
        private string horario;

        public ComandoMusica(HabitacionInteligente habitacion, string artista, int volumen, string horario)
        {
            this.habitacion = habitacion;
            this.artista = artista;
            this.volumen = volumen;
            this.horario = horario;
        }

        public void ejecutar()
        {
            habitacion.ajustarMusica(artista, volumen, horario);
        }

        public void deshacer()
        {
            Console.WriteLine("Deshaciendo ajuste de música...");
        }
    }
}
