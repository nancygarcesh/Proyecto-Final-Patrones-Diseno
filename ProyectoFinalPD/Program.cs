using ProyectoFinalPD.Builder;
using ProyectoFinalPD.Command;
using ProyectoFinalPD.Composite;
using ProyectoFinalPD.Decorator;
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
            Console.WriteLine("Bienvenido al sistema de reservas del Hotel 5 estrellas!");

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

            Console.WriteLine();

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

            Console.WriteLine();

            //---------------------------------------------DECORATOR----------------------------------------------------

            // Crear un paquete base
            PaqueteHabitacion paquete = new PaqueteBase();

            // Lista para mantener los servicios adicionales seleccionados
            List<PaqueteHabitacion> serviciosAdicionales = new List<PaqueteHabitacion>();

            Console.WriteLine("Seleccione los servicios adicionales que desea agregar al paquete:");
            Console.WriteLine("1. Internet (+10Bs)");
            Console.WriteLine("2. Gimnasio (+20Bs)");
            Console.WriteLine("3. Spa (+20Bs)");
            Console.WriteLine("4. Karaoke (+30Bs)");
            Console.WriteLine("5. Cine (+30Bs)");
            Console.WriteLine("Presione Enter para finalizar la selección.");

            // Leer la selección del usuario y agregar servicios adicionales al paquete
            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;

                switch (input)
                {
                    case "1":
                        if (!serviciosAdicionales.Any(s => s is InternetDecorator))
                            serviciosAdicionales.Add(new InternetDecorator(paquete));
                        break;
                    case "2":
                        if (!serviciosAdicionales.Any(s => s is GimnasioDecorator))
                            serviciosAdicionales.Add(new GimnasioDecorator(paquete));
                        break;
                    case "3":
                        if (!serviciosAdicionales.Any(s => s is SpaDecorator))
                            serviciosAdicionales.Add(new SpaDecorator(paquete));
                        break;
                    case "4":
                        if (!serviciosAdicionales.Any(s => s is KaraokeDecorator))
                            serviciosAdicionales.Add(new KaraokeDecorator(paquete));
                        break;
                    case "5":
                        if (!serviciosAdicionales.Any(s => s is CineDecorator))
                            serviciosAdicionales.Add(new CineDecorator(paquete));
                        break;
                    default:
                        Console.WriteLine("Selección no válida. Intente de nuevo.");
                        break;
                }
            }

            // Calcular el costo total sumando los costos de todos los servicios adicionales
            double costoTotal = paquete.CalcularCosto(); // Incluye el costo base del paquete
            foreach (var servicio in serviciosAdicionales)
            {
                costoTotal += servicio.CalcularCosto();
            }

            // Ejemplo de cómo obtener la descripción y el costo total del paquete
            Console.WriteLine("Descripción del paquete: " + string.Join(", ", serviciosAdicionales.Select(s => s.ObtenerDescripcion())));
            Console.WriteLine("Costo total del paquete: $" + costoTotal);


            //-------------------------------------------------------------------------------------------------------------------

            Console.WriteLine();

            //---------------------------------------COMMAND--------------------------------------------------------------------

            HabitacionInteligente habitacion1 = new HabitacionInteligente();
            ControladorApp controlador = new ControladorApp();

            // Pedir al usuario que ingrese los datos para crear los comandos
            Console.WriteLine("Ingrese los datos para ajustar la música:");
            Console.Write("Artista: ");
            string artista = Console.ReadLine();
            Console.Write("Volumen: ");
            int volumen = Convert.ToInt32(Console.ReadLine());

            ComandoMusica comandoMusica = new ComandoMusica(habitacion1, artista, volumen);

            Console.WriteLine("\nIngrese los datos para llenar la tina:");
            Console.Write("Temperatura: ");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            ComandoTina comandoTina = new ComandoTina(habitacion1, temperatura);

            Console.WriteLine("\nIngrese los datos para ajustar la luz:");
            Console.Write("Intensidad: ");
            int intensidad = Convert.ToInt32(Console.ReadLine());

            ComandoLuz comandoLuz = new ComandoLuz(habitacion1, intensidad);

            Console.WriteLine("\nIngrese los datos para mover las cortinas (true para abrir, false para cerrar):");
            bool abiertas = Convert.ToBoolean(Console.ReadLine());

            ComandoCortinas comandoCortinas = new ComandoCortinas(habitacion1, abiertas);

            Console.WriteLine();

            // Agregar comandos al controlador
            controlador.anadirComando(comandoMusica);
            controlador.anadirComando(comandoTina);
            controlador.anadirComando(comandoLuz);
            controlador.anadirComando(comandoCortinas);

            // Ejecutar comandos
            controlador.ejecutarComandos();



            Console.ReadLine();
        }
    }
}
