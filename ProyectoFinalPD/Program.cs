using ProyectoFinalPD.Builder;
using ProyectoFinalPD.Command;
using ProyectoFinalPD.Composite;
using ProyectoFinalPD.Decorator;
using ProyectoFinalPD.Mediator;
using ProyectoFinalPD.State;
using ProyectoFinalPD.Visitor;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\r\n█▄▄ █ █▀▀ █▄░█ █░█ █▀▀ █▄░█ █ █▀▄ █▀█   ▄▀█ █░░   █▀ █ █▀ ▀█▀ █▀▀ █▀▄▀█ ▄▀█   █▀▄ █▀▀   █▀█ █▀▀ █▀ █▀▀ █▀█ █░█ ▄▀█ █▀\r\n█▄█ █ ██▄ █░▀█ ▀▄▀ ██▄ █░▀█ █ █▄▀ █▄█   █▀█ █▄▄   ▄█ █ ▄█ ░█░ ██▄ █░▀░█ █▀█   █▄▀ ██▄   █▀▄ ██▄ ▄█ ██▄ █▀▄ ▀▄▀ █▀█ ▄█\r\n\r\n█▀▄ █▀▀ █░░   █░█ █▀█ ▀█▀ █▀▀ █░░   █▀   █▀▀ █▀ ▀█▀ █▀█ █▀▀ █░░ █░░ ▄▀█ █▀ █\r\n█▄▀ ██▄ █▄▄   █▀█ █▄█ ░█░ ██▄ █▄▄   ▄█   ██▄ ▄█ ░█░ █▀▄ ██▄ █▄▄ █▄▄ █▀█ ▄█ ▄");
            Console.ResetColor();
            Console.WriteLine();
            double costoTotal = 0;

            //-------------------------------------------COMPOSITE---------------------------------------------------
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("¡Reservas de habitaciones/paquetes!");
            Console.ResetColor();
            Console.WriteLine();

            Cliente cliente = new Cliente();

            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Reservar habitación individual (ONE)");
            Console.WriteLine("2. Reservar paquete Medium (MEDIUM)");
            Console.WriteLine("3. Reservar paquete Big (BIG)");
            Console.WriteLine("4. Salir");
            int numeroHabitaciones = 1;
            double costoPaqueteIndividual = 50;
            double costoPaqueteMedium1 = 100;
            double costoPaqueteMedium = costoPaqueteMedium1 * 0.9;
            double costoPaqueteBig1 = 250;
            double costoPaqueteBig = costoPaqueteBig1*0.8;
            double costoPaquete = 0;

            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion))
            {

                switch (opcion)
                {
                    case 1:
                        cliente.HacerReservacion(new HabitacionIndividual(50, "Habitación individual (ONE)"));
                        costoPaquete = costoPaqueteIndividual;
                        Console.WriteLine("Reserva de habitación individual realizada con éxito.");
                        break;
                    case 2:
                        numeroHabitaciones = 2; // Si se elige el paquete Medium, son 2 habitaciones
                        var paqueteMedium = new PaqueteCompuesto();
                        // Agrega el costo de cada habitación individual del paquete Medium
                        paqueteMedium.Agregar(new HabitacionIndividual(50, "Habitación individual (ONE)"));
                        paqueteMedium.Agregar(new HabitacionIndividual(50, "Habitación individual (ONE)"));
                        paqueteMedium.EstablecerDescuento(0.1); // Descuento del 10%
                        cliente.HacerReservacion(paqueteMedium);
                        costoPaquete = costoPaqueteMedium;
                        Console.WriteLine("Reserva de paquete Medium realizada con éxito.");
                        break;
                    case 3:
                        numeroHabitaciones = 3; // Si se elige el paquete Big, son 3 habitaciones
                        var paqueteBig = new PaqueteCompuesto();
                        // Agrega el costo de cada habitación individual del paquete Big
                        paqueteBig.Agregar(new HabitacionIndividual(50, "Habitación individual (ONE)"));
                        paqueteBig.Agregar(new HabitacionIndividual(100, "Paquete Medium (MEDIUM)"));
                        paqueteBig.Agregar(new HabitacionIndividual(100, "Paquete Medium (MEDIUM)"));
                        paqueteBig.EstablecerDescuento(0.2); // Descuento del 20%
                        cliente.HacerReservacion(paqueteBig);
                        costoPaquete = costoPaqueteBig;
                        Console.WriteLine("Reserva de paquete Big realizada con éxito.");
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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("¡Reservas de tipo de habitaciones!");
            Console.ResetColor();
            Console.WriteLine();

            // Definir los costos de las habitaciones
            int costoHabitacionEstandar = 200;
            int costoHabitacionLujo = 350;
            int costoHabitacionInteligente = 400;

            Director director = new Director();
            IConstructorHabitacion constructor = null;

            Console.WriteLine("Seleccione el tipo de habitación que desea:");
            Console.WriteLine("1. Estándar");
            Console.WriteLine("2. Lujo");
            Console.WriteLine("3. Inteligente");

            int opcion1;
            if (int.TryParse(Console.ReadLine(), out opcion1))
            {
                double costoFinal = 0;
                double costoHabitacion = 0;

                switch (opcion1)
                {
                    case 1:
                        constructor = new ConstructorHabitacionEstandar();
                        costoFinal = costoHabitacionEstandar;
                        costoHabitacion = costoHabitacionEstandar;
                        break;
                    case 2:
                        constructor = new ConstructorHabitacionLujo();
                        costoFinal = costoHabitacionLujo;
                        costoHabitacion = costoHabitacionLujo;
                        break;
                    case 3:
                        constructor = new ConstructorHabitacionInteligente();
                        costoFinal = costoHabitacionInteligente;
                        costoHabitacion = costoHabitacionInteligente;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Seleccionando habitación estándar por defecto.");
                        constructor = new ConstructorHabitacionEstandar();
                        costoFinal = costoHabitacionEstandar;
                        costoHabitacion = costoHabitacionEstandar;
                        break;
                }

                director.SetConstructor(constructor);
                director.ConstruirHabitacion();
                Habitacion habitacion = constructor.ObtenerHabitacion();

                if (opcion1 == 3) // Si la opción elegida es habitación inteligente
                {
                    //---------------------------------------COMMAND--------------------------------------------------------------------

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Aplicacion de control de habitación!");
                    Console.ResetColor();
                    Console.WriteLine();

                    HabitacionInteligente habitacion1 = new HabitacionInteligente();
                    ControladorApp controlador = new ControladorApp();

                    // Pedir al usuario que ingrese los datos para crear los comandos
                    Console.WriteLine("Ingrese los datos para ajustar la música:");
                    Console.Write("Artista (string): ");
                    string artista = Console.ReadLine();
                    Console.Write("Volumen (int): ");
                    int volumen = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Horario (string): ");
                    string horario1 = Console.ReadLine();

                    ComandoMusica comandoMusica = new ComandoMusica(habitacion1, artista, volumen, horario1);

                    Console.WriteLine("\nIngrese los datos para llenar la tina:");
                    Console.Write("Temperatura (double): ");
                    double temperatura = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Horario (string): ");
                    string horario2 = Console.ReadLine();

                    ComandoTina comandoTina = new ComandoTina(habitacion1, temperatura, horario2);

                    Console.WriteLine("\nIngrese los datos para ajustar la luz:");
                    Console.Write("Intensidad (int): ");
                    int intensidad = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Horario (string): ");
                    string horario3 = Console.ReadLine();

                    ComandoLuz comandoLuz = new ComandoLuz(habitacion1, intensidad, horario3);

                    Console.WriteLine("\nIngrese los datos para mover las cortinas (true para abrir, false para cerrar):");
                    bool abiertas = Convert.ToBoolean(Console.ReadLine());
                    Console.Write("Horario (string): ");
                    string horario4 = Console.ReadLine();

                    ComandoCortinas comandoCortinas = new ComandoCortinas(habitacion1, abiertas, horario4);

                    Console.WriteLine();

                    // Agregar comandos al controlador
                    controlador.AnadirComando(comandoMusica);
                    controlador.AnadirComando(comandoTina);
                    controlador.AnadirComando(comandoLuz);
                    controlador.AnadirComando(comandoCortinas);

                    // Ejecutar comandos
                    controlador.EjecutarComandos();

                    //-------------------------------------------------------------------------------------------------------------
                }

                costoFinal *= numeroHabitaciones;
                costoFinal += costoPaquete;
                Console.WriteLine("Costo de la habitación: {0} Bs", costoHabitacion);
                Console.WriteLine();
                habitacion.MostrarDetalles();

                // Mostrar el precio final
                Console.WriteLine("\nPrecio Final: {0} Bs", costoFinal);
                Console.WriteLine();
                costoTotal += costoFinal;
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

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("¡Reservas de servicios adicionales!");
            Console.ResetColor();
            Console.WriteLine();

            // Crear un paquete base
            IPaqueteHabitacion paquete = new PaqueteBase();

            // Lista para mantener los servicios adicionales seleccionados
            List<IPaqueteHabitacion> serviciosAdicionales = new List<IPaqueteHabitacion>();

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
            double costoTotal1 = paquete.ObtenerPrecio(); // Incluye el costo base del paquete
            foreach (var servicio in serviciosAdicionales)
            {
                costoTotal1 += servicio.ObtenerPrecio();
                costoTotal += servicio.ObtenerPrecio();
            }

            // Ejemplo de cómo obtener la descripción y el costo total del paquete
            Console.WriteLine("Descripción del paquete: " + string.Join(", ", serviciosAdicionales.Select(s => s.ObtenerDescripcion())));
            Console.WriteLine("Costo total del paquete: " + costoTotal1 + " Bs");

            //-------------------------------------------------------------------------------------------------------------------

            Console.WriteLine();

            //------------------------------------------MEDIATOR------------------------------------------------------------

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("¡Solicitar algo a Recepcion!");
            Console.ResetColor();
            Console.WriteLine();

            // Crear instancias de los colegas
            var mantenimiento = new Mantenimiento();
            var limpieza = new Limpieza();
            var cocina = new Cocina();
            var bar = new Bar();
            var spa1 = new Spa1(3, 1200.0);

            // Crear instancia del mediador (Recepción) y asignarle los colegas
            var recepcion = new Recepcion(mantenimiento, limpieza, cocina, bar, spa1);

            // Configurar el mediador para cada colega
            mantenimiento.SetMediador(recepcion);
            limpieza.SetMediador(recepcion);
            cocina.SetMediador(recepcion);
            bar.SetMediador(recepcion);
            spa1.SetMediador(recepcion);

            Console.WriteLine("Ingrese el número correspondiente a la solicitud que desea hacer:");
            Console.WriteLine("1. Pedido de mantenimiento");
            Console.WriteLine("2. Pedido de limpieza");
            Console.WriteLine("3. Pedido de comida");
            Console.WriteLine("4. Pedido de bebida");
            Console.WriteLine("5. No deseo hacer ninguna solicitud");
            Console.WriteLine("6. Salir");

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
                    Console.WriteLine("Saliendo sin Solicitudes");
                    break;
                case 6:
                    Console.WriteLine("Saliendo del programa.");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 5.");
                    break;
            }

            //------------------------------------------------------------------------------------------------------------

            Console.WriteLine();

            //----------------------------------------------------STATE-------------------------------------------------------

            Console.ForegroundColor = ConsoleColor.Blue;
            SistemaSpa spa = new SistemaSpa();

            Console.WriteLine("¡Reservas de Spa!");
            Console.WriteLine();
            Console.ResetColor();
            string habitacion10;
            string mensaje1;
            Console.WriteLine("\n¿Qué desea hacer?");
            Console.WriteLine("1. Reservar Spa");
            Console.WriteLine("2. Cancelar reserva de Spa");
            Console.WriteLine("3. No realizar ninguna accion");
            Console.WriteLine("4. Salir");

            Console.Write("Ingrese su elección: ");
            string opcion4 = Console.ReadLine();

            switch (opcion4)
            {
                case "1":
                    Console.WriteLine("Ingrese el número de habitación y una descripción:");
                    habitacion10 = Console.ReadLine();
                    mensaje1 = Console.ReadLine();
                    recepcion.Notificar(spa1, $"{habitacion10}: {mensaje1}");

                    Console.Write("Ingrese la fecha y hora de la reserva (YYYY-MM-DD HH:MM): ");
                    string fechaHora = Console.ReadLine();
                    spa.Reservar(habitacion10, fechaHora);
                    break;
                case "2":
                    spa.CancelarReserva();
                    break;
                case "3":
                    Console.WriteLine("¡No realizando ninguna accion!");
                    break;
                case "4":
                    Console.WriteLine("¡Gracias por utilizar nuestro sistema de reservas de Spa!");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Por favor, ingrese una opción válida.");
                    break;
            }

            //------------------------------------------------------------------------------------------------------------

            Console.WriteLine();
            

            //----------------------------------------------------VISITOR-------------------------------------------------------

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("¡Visitando todos los sistemas dentro del hotel!");
            Console.ResetColor();
            Console.WriteLine();

            var mantenimiento3 = new Mantenimiento1(10, 500.0);
            var limpieza3 = new Limpieza1(5, 300.0);
            var cocina3 = new Cocina1(15, 1000.0);
            var bar3 = new Bar1(20, 700.0);
            var spa3 = new Spa1(3, 1200.0);

            var reporteVisitor = new ReporteVisitor();
            mantenimiento3.Accept(reporteVisitor);
            limpieza3.Accept(reporteVisitor);
            cocina3.Accept(reporteVisitor);
            bar3.Accept(reporteVisitor);
            spa3.Accept(reporteVisitor);
            Console.WriteLine();

            //----------------------------------------------------------------------------------------------------------------------

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Costo total de todas las reservas: {costoTotal} Bs");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("Para finalizar con el sistema de reservas presione ENTER\nGracias por usar el sistema");

            Console.ReadLine();
        }
    }
}
