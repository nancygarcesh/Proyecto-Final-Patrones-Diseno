using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Visitor
{
    public class ReporteVisitor : Visitor
    {
        private List<Eleccion> elecciones = new List<Eleccion>();

        public void visitEleccion(Eleccion eleccion)
        {
            elecciones.Add(eleccion);
        }

        // Método para mostrar el reporte de elecciones
        public void MostrarReporte()
        {
            Console.WriteLine("Reporte de Elecciones:");
            foreach (var eleccion in elecciones)
            {
                Console.WriteLine($"Patron: {eleccion.Patron}, Descripción: {eleccion.Descripcion}, Costo: {eleccion.Costo}");
            }
        }
    }
}
