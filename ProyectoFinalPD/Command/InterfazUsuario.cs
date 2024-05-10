using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Command
{
    public class InterfazUsuario
    {
        private ControladorApp controlador;
        private HabitacionInteligente habitacion;

        public InterfazUsuario(ControladorApp controlador, HabitacionInteligente habitacion)
        {
            this.controlador = controlador;
            this.habitacion = habitacion;
        }

        public void Iniciar()
        {
            while (true)
            {
                MostrarMenu();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarServicio();
                        break;
                    case "2":
                        QuitarServicio();
                        break;
                    case "3":
                        controlador.EjecutarComandos();
                        break;
                    case "4":
                        Console.WriteLine("Saliendo...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }

        private void MostrarMenu()
        {
            Console.WriteLine("1. Añadir servicio");
            Console.WriteLine("2. Quitar servicio");
            Console.WriteLine("3. Ejecutar comandos");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
        }

        private void AgregarServicio()
        {
            Console.WriteLine("\nSeleccione el servicio que desea añadir:");
            Console.WriteLine("1. Ajustar música");
            Console.WriteLine("2. Llenar tina");
            Console.WriteLine("3. Ajustar luz");
            Console.WriteLine("4. Mover cortinas");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarComandoMusica();
                    break;
                case "2":
                    AgregarComandoTina();
                    break;
                case "3":
                    AgregarComandoLuz();
                    break;
                case "4":
                    AgregarComandoCortinas();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        }

        private void AgregarComandoMusica()
        {
            Console.Write("Artista (string): ");
            string artista = Console.ReadLine();
            Console.Write("Volumen (int): ");
            int volumen = Convert.ToInt32(Console.ReadLine());
            Console.Write("Horario (string): ");
            string horario1 = Console.ReadLine();

            ComandoMusica comandoMusica = new ComandoMusica(habitacion, artista, volumen, horario1);
            controlador.AnadirComando(comandoMusica);
        }

        private void AgregarComandoTina()
        {
            Console.Write("Temperatura (double): ");
            double temperatura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Horario (string): ");
            string horario2 = Console.ReadLine();

            ComandoTina comandoTina = new ComandoTina(habitacion, temperatura, horario2);
            controlador.AnadirComando(comandoTina);
        }

        private void AgregarComandoLuz()
        {
            Console.Write("Intensidad (int): ");
            int intensidad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Horario (string): ");
            string horario3 = Console.ReadLine();

            ComandoLuz comandoLuz = new ComandoLuz(habitacion, intensidad, horario3);
            controlador.AnadirComando(comandoLuz);
        }

        private void AgregarComandoCortinas()
        {
            Console.WriteLine("¿Desea abrir o cerrar las cortinas? (true para abrir, false para cerrar):");
            bool abiertas = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Horario (string): ");
            string horario4 = Console.ReadLine();

            ComandoCortinas comandoCortinas = new ComandoCortinas(habitacion, abiertas, horario4);
            controlador.AnadirComando(comandoCortinas);
        }

        private void QuitarServicio()
        {
            if (controlador.Comandos.Count == 0)
            {
                Console.WriteLine("No hay servicios para quitar.");
                return;
            }

            Console.WriteLine("Seleccione el servicio que desea quitar:");
            for (int i = 0; i < controlador.Comandos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {controlador.Comandos[i].GetType().Name}");
            }
            Console.Write("Seleccione el número del servicio: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion >= 1 && opcion <= controlador.Comandos.Count)
            {
                Comando comando = controlador.Comandos[opcion - 1];
                controlador.EliminarComando(comando);
                Console.WriteLine($"Se ha quitado el servicio: {comando.GetType().Name}");
                comando.deshacer();
            }
            else
            {
                Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
            }
        }
    }
}
