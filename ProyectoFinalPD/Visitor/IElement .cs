using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Visitor
{
    interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
