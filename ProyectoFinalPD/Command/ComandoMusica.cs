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

        public ComandoMusica(HabitacionInteligente habitacion, string artista, int volumen)
        {
            this.habitacion = habitacion;
            this.artista = artista;
            this.volumen = volumen;
        }

        public void ejecutar()
        {
            habitacion.ajustarMusica(artista, volumen);
        }

        public void deshacer()
        {
            Console.WriteLine("Deshaciendo ajuste de música...");
        }
    }
}
