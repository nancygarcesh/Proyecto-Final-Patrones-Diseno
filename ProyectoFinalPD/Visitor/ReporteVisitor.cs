
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Visitor
{
    public class ReporteVisitor : IVisitor
    {
        public void VisitMantenimiento(Mantenimiento1 mantenimiento)
        {
            Console.WriteLine("Visitando Mantenimiento - Usos Diarios: {0}, Costo Total: {1}", mantenimiento.UsosDiarios, mantenimiento.CostoTotal);
        }

        public void VisitLimpieza(Limpieza1 limpieza)
        {
            Console.WriteLine("Visitando Limpieza - Usos Diarios: {0}, Costo Total: {1}", limpieza.UsosDiarios, limpieza.CostoTotal);
        }

        public void VisitCocina(Cocina1 cocina)
        {
            Console.WriteLine("Visitando Cocina - Usos Diarios: {0}, Costo Total: {1}", cocina.UsosDiarios, cocina.CostoTotal);
        }

        public void VisitBar(Bar1 bar)
        {
            Console.WriteLine("Visitando Bar - Usos Diarios: {0}, Costo Total: {1}", bar.UsosDiarios, bar.CostoTotal);
        }

        public void VisitSpa(Spa1 spa)
        {
            Console.WriteLine("Visitando Spa - Usos Diarios: {0}, Costo Total: {1}", spa.UsosDiarios, spa.CostoTotal);
        }
    }
}
