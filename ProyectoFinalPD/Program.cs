using ProyectoFinalPD.Builder;
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
            //-------------------------------------------COMPOSITE---------------------------------------------------
            Cliente cliente = new Cliente();

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

            //----------------------------------------------------------------------------------------------------------------


            //------------------------------------------BUILDER------------------------------------------------------------

            Director director = new Director();
            IConstructorHabitacion constructor = null;

            Console.WriteLine("Seleccione el tipo de habitación que desea:");
            Console.WriteLine("1. Estándar");
            Console.WriteLine("2. Lujo");
            Console.WriteLine("3. Inteligente");

            int opcion1;
            if (int.TryParse(Console.ReadLine(), out opcion1))
            {
                switch (opcion1)
                {
                    case 1:
                        constructor = new ConstructorHabitacionEstandar();
                        break;
                    case 2:
                        constructor = new ConstructorHabitacionLujo();
                        break;
                    case 3:
                        constructor = new ConstructorHabitacionInteligente();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Seleccionando habitación estándar por defecto.");
                        constructor = new ConstructorHabitacionEstandar();
                        break;
                }

                director.SetConstructor(constructor);
                director.ConstruirHabitacion();
                Habitacion habitacion = constructor.ObtenerHabitacion();


                habitacion.MostrarDetalles();
            }
            else
            {
                Console.WriteLine("Entrada no válida. Seleccionando habitación estándar por defecto.");
                constructor = new ConstructorHabitacionEstandar();
                director.SetConstructor(constructor);
                director.ConstruirHabitacion();
                Habitacion habitacion = constructor.ObtenerHabitacion();

                Console.WriteLine("Detalles de la habitación:");
                habitacion.MostrarDetalles();
            }

            //---------------------------------------------------------------------------------------------------------------


            Console.ReadLine();
        }
    }
}
