using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalPD.Mediator;
using ProyectoFinalPD.State;

namespace ProyectoFinalPD.Visitor
{
    public class Spa1 : Colega, IElement
    {
        private int usosDiarios;
        private double costoTotal;

        public Spa1(int usosDiarios, double costoTotal)
        {
            this.usosDiarios = usosDiarios;
            this.costoTotal = costoTotal;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitSpa(this);
        }

        public override void RecibirMensaje(string mensaje)
        {
            Console.WriteLine("Spa: Solicitud recibida - " + mensaje);
        }

        public int UsosDiarios { get { return usosDiarios; } }
        public double CostoTotal { get { return costoTotal; } }
    }
}
