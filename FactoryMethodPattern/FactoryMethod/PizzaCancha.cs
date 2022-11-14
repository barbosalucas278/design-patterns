using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class PizzaCancha : Pizza
    {
        public PizzaCancha(string origen) : base(origen)
        {
            Descripcion = "Pizza a la cancha";
        }
    }
}
