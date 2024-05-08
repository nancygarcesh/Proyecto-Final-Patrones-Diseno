using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Builder
{
    public class Habitacion
    {
        private Desayuno desayuno;
        private ServicioBar servicioBar;
        private AccesoAreasLudicas accesoAreasLudicas;
        private ServicioCena servicioCena;

        public void SetDesayuno(Desayuno desayuno)
        {
            this.desayuno = desayuno;
        }

        public void SetServicioBar(ServicioBar servicioBar)
        {
            this.servicioBar = servicioBar;
        }

        public void SetAccesoAreasLudicas(AccesoAreasLudicas accesoAreasLudicas)
        {
            this.accesoAreasLudicas = accesoAreasLudicas;
        }

        public void SetServicioCena(ServicioCena servicioCena)
        {
            this.servicioCena = servicioCena;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine("Detalles de la habitación:");
            Console.WriteLine("Desayuno: " + desayuno.DetalleDesayuno());
            Console.WriteLine("Servicio de bar: " + servicioBar.DetalleServicioBar());
            Console.WriteLine("Acceso a áreas lúdicas: " + accesoAreasLudicas.DetalleAcceso());
            Console.WriteLine("Servicio de cena: " + servicioCena.DetalleServicioCena());
        }
    }
}
