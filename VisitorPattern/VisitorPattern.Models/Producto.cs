using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Models
{
    public abstract class Producto : IVisitable
    {
        public double Precio { get; set; }

        public abstract double Aceptar(IVisitor visitor);
    }
}
