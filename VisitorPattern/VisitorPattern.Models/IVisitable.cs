using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Models
{
    public interface IVisitable
    {
        double Aceptar(IVisitor visitor);
    }
}
