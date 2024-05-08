using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Command
{
    public class HabitacionInteligente
    {
        public void ajustarMusica(string artista, int volumen)
        {
            Console.WriteLine($"Ajustando música: Artista {artista}, Volumen {volumen}");
        }

        public void llenarTina(double temperatura)
        {
            Console.WriteLine($"Llenando tina a {temperatura} grados");
        }

        public void ajustarLuz(int intensidad)
        {
            Console.WriteLine($"Ajustando intensidad de luz: {intensidad}");
        }

        public void moverCortinas(bool abiertas)
        {
            Console.WriteLine($"Mover cortinas: {(abiertas ? "Abiertas" : "Cerradas")}");
        }
    }
}
