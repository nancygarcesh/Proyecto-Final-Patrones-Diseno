using ProyectoFinalPD.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Reservar habitación individual (ONE)");
                Console.WriteLine("2. Reservar paquete Medium (MEDIUM)");
                Console.WriteLine("3. Reservar paquete Big (BIG)");
                Console.WriteLine("4. Salir");

                int opcion;
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            cliente.HacerReservacion(new HabitacionIndividual(100, "Habitación individual (ONE)"));
                            break;
                        case 2:
                            var paqueteMedium = new PaqueteCompuesto();
                            paqueteMedium.Agregar(new HabitacionIndividual(200, "Paquete Medium (MEDIUM)"));
                            paqueteMedium.Agregar(new HabitacionIndividual(200, "Paquete Medium (MEDIUM)"));
                            paqueteMedium.EstablecerDescuento(0.1); // Descuento del 10%
                            cliente.HacerReservacion(paqueteMedium);
                            break;
                        case 3:
                            var paqueteBig = new PaqueteCompuesto();
                            paqueteBig.Agregar(new HabitacionIndividual(100, "Habitación individual (ONE)"));
                            paqueteBig.Agregar(new HabitacionIndividual(200, "Paquete Medium (MEDIUM)"));
                            paqueteBig.Agregar(new HabitacionIndividual(200, "Paquete Medium (MEDIUM)"));
                            paqueteBig.EstablecerDescuento(0.2); // Descuento del 20%
                            cliente.HacerReservacion(paqueteBig);
                            break;
                        case 4:
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, introduzca un número.");
                }

                Console.WriteLine("¿Desea realizar otra acción? (s/n)");
                string respuesta = Console.ReadLine();
                continuar = respuesta.Equals("s", StringComparison.OrdinalIgnoreCase);
            }
            Console.ReadLine();
        }
    }
}
