using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class PizzaNapolitana : Pizza
    {
        public PizzaNapolitana(string origen) : base(origen)
        {
            Descripcion = "Pizza napolitana";
        }
    }
}
