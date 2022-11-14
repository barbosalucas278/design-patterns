using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Models
{
    public class IVA : IVisitor
    {
        private const double IVA_1 = 1.21d;
        private const double IVA_2 = 1.105d;

        public double Visitar(ProductoClase1 producto)
        {
            return producto.Precio * IVA_1;
        }

        public double Visitar(ProductoClase2 producto)
        {
            return producto.Precio * IVA_2;
        }
    }
}
