
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Visitor
{
    interface IVisitor
    {
        void VisitMantenimiento(Mantenimiento1 mantenimiento);
        void VisitLimpieza(Limpieza1 limpieza);
        void VisitCocina(Cocina1 cocina);
        void VisitBar(Bar1 bar);
        void VisitSpa(Spa1 spa);
    }
}
