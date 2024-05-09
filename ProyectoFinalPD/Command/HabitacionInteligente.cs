using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Command
{
    public class HabitacionInteligente
    {
        public void ajustarMusica(string artista, int volumen, string horario)
        {
            Console.WriteLine($"Ajustando música a las {horario}: Artista {artista}, Volumen {volumen}");
        }

        public void llenarTina(double temperatura, string horario)
        {
            Console.WriteLine($"Llenando tina a {temperatura} grados a las {horario}");
        }

        public void ajustarLuz(int intensidad, string horario)
        {
            Console.WriteLine($"Ajuste de intensidad de luz: {intensidad}, se realizara a las {horario}");
        }

        public void moverCortinas(bool abiertas, string horario)
        {
            Console.WriteLine($"Mover cortinas a las {horario}: {(abiertas ? "Abiertas" : "Cerradas" )}");
        }

    }
}
