using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Models
{
    public interface IVisitor
    {
        double Visitar(ProductoClase1 producto);
        double Visitar(ProductoClase2 producto);
    }
}
