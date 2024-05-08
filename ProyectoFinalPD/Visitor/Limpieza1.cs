using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Visitor
{
    public class Limpieza1 : IElement
    {
        private int usosDiarios;
        private double costoTotal;

        public Limpieza1(int usosDiarios, double costoTotal)
        {
            this.usosDiarios = usosDiarios;
            this.costoTotal = costoTotal;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitLimpieza(this);
        }

        public int UsosDiarios { get { return usosDiarios; } }
        public double CostoTotal { get { return costoTotal; } }
    }
}
