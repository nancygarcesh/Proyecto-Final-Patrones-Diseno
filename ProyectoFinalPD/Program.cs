using ProyectoFinalPD.Builder;
using ProyectoFinalPD.Command;
using ProyectoFinalPD.Composite;
using ProyectoFinalPD.Decorator;
using ProyectoFinalPD.Mediator;
using ProyectoFinalPD.State;
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
            Console.WriteLine("\r\n█▄▄ █ █▀▀ █▄░█ █░█ █▀▀ █▄░█ █ █▀▄ █▀█   ▄▀█ █░░   █▀ █ █▀ ▀█▀ █▀▀ █▀▄▀█ ▄▀█   █▀▄ █▀▀   █▀█ █▀▀ █▀ █▀▀ █▀█ █░█ ▄▀█ █▀\r\n█▄█ █ ██▄ █░▀█ ▀▄▀ ██▄ █░▀█ █ █▄▀ █▄█   █▀█ █▄▄   ▄█ █ ▄█ ░█░ ██▄ █░▀░█ █▀█   █▄▀ ██▄   █▀▄ ██▄ ▄█ ██▄ █▀▄ ▀▄▀ █▀█ ▄█\r\n\r\n█▀▄ █▀▀ █░░   █░█ █▀█ ▀█▀ █▀▀ █░░   █▀   █▀▀ █▀ ▀█▀ █▀█ █▀▀ █░░ █░░ ▄▀█ █▀ █\r\n█▄▀ ██▄ █▄▄   █▀█ █▄█ ░█░ ██▄ █▄▄   ▄█   ██▄ ▄█ ░█░ █▀▄ ██▄ █▄▄ █▄▄ █▀█ ▄█ ▄");
            Console.WriteLine();

            //-------------------------------------------COMPOSITE---------------------------------------------------
            Console.WriteLine("¡Sistema de reservas de habitaciones/paquetes!");
            Console.WriteLine();

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

            Console.WriteLine("¡Sistema de reservas de tipo de habitaciones!");
            Console.WriteLine();

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

            Console.WriteLine("¡Sistema de reservas de servicios adicionales!");
            Console.WriteLine();

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

            Console.WriteLine("¡Aplicacion de control de habitación!");
            Console.WriteLine();

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

            //--------------------------------------------------------------------------------------------------------------

            Console.WriteLine();

            //------------------------------------------MEDIATOR------------------------------------------------------------

            Console.WriteLine("¡Sistema de reservas de Pedidos!");
            Console.WriteLine();

            // Crear instancias de los colegas
            var mantenimiento = new Mantenimiento();
            var limpieza = new Limpieza();
            var cocina = new Cocina();
            var bar = new Bar();

            // Crear instancia del mediador (Recepción) y asignarle los colegas
            var recepcion = new Recepcion(mantenimiento, limpieza, cocina, bar);

            // Configurar el mediador para cada colega
            mantenimiento.SetMediador(recepcion);
            limpieza.SetMediador(recepcion);
            cocina.SetMediador(recepcion);
            bar.SetMediador(recepcion);

                Console.WriteLine("Ingrese el número correspondiente a la solicitud que desea hacer:");
                Console.WriteLine("1. Pedido de mantenimiento");
                Console.WriteLine("2. Pedido de limpieza");
                Console.WriteLine("3. Pedido de comida");
                Console.WriteLine("4. Pedido de bebida");
                Console.WriteLine("5. Salir");

                int opcion3;
                if (!int.TryParse(Console.ReadLine(), out opcion3))
                {
                    Console.WriteLine("Opción no válida. Por favor, ingrese un número válido.");

                }

                string habitacion3;
                string mensaje;
                switch (opcion3)
                {
                    case 1:
                        Console.WriteLine("Ingrese el número de habitación y una descripción del problema:");
                        habitacion3 = Console.ReadLine();
                        mensaje = Console.ReadLine();
                        recepcion.Notificar(mantenimiento, $"{habitacion3}: {mensaje}");
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el número de habitación y detalles adicionales para la limpieza:");
                        habitacion3 = Console.ReadLine();
                        mensaje = Console.ReadLine();
                        recepcion.Notificar(limpieza, $"{habitacion3}: {mensaje}");
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el número de habitación y su pedido de comida:");
                        habitacion3 = Console.ReadLine();
                        mensaje = Console.ReadLine();
                        recepcion.Notificar(cocina, $"{habitacion3}: {mensaje}");
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el número de habitación y su pedido de bebida:");
                        habitacion3 = Console.ReadLine();
                        mensaje = Console.ReadLine();
                        recepcion.Notificar(bar, $"{habitacion3}: {mensaje}");
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa.");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 5.");
                        break;
                }

            //------------------------------------------------------------------------------------------------------------

            Console.WriteLine();

            //----------------------------------------------------STATE-------------------------------------------------------


            SistemaSpa spa = new SistemaSpa();

            Console.WriteLine("¡Sistema de reservas de Spa!");
            Console.WriteLine();

            Console.WriteLine("\n¿Qué desea hacer?");
                Console.WriteLine("1. Reservar Spa");
                Console.WriteLine("2. Cancelar reserva de Spa");
                Console.WriteLine("3. Salir");

                Console.Write("Ingrese su elección: ");
                string opcion4 = Console.ReadLine();

                switch (opcion4)
                {
                    case "1":
                        Console.Write("Ingrese el número de habitación: ");
                        string habitacion = Console.ReadLine();

                        Console.Write("Ingrese la fecha y hora de la reserva (YYYY-MM-DD HH:MM): ");
                        string fechaHora = Console.ReadLine();
                        spa.Reservar(habitacion, fechaHora);
                        break;
                    case "2":
                        spa.CancelarReserva();
                        break;
                    case "3":
                        Console.WriteLine("¡Gracias por utilizar nuestro sistema de reservas de Spa!");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingrese una opción válida.");
                        break;
                }


            //------------------------------------------------------------------------------------------------------------

            Console.WriteLine();

            //----------------------------------------------------VISITOR-------------------------------------------------------

           



            Console.WriteLine();
            Console.WriteLine("Para finalizar con el sistema de reservas presione ENTER\nGracias por usar el sistema");

            Console.ReadLine();
        }
    }
}
