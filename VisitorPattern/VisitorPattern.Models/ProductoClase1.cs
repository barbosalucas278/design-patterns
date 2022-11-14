using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Models
{
    public class ProductoClase1 : Producto
    {
        public override double Aceptar(IVisitor visitor)
        {
            return visitor.Visitar(this);
        }
    }
}
