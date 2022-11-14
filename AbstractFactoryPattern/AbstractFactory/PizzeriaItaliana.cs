using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PizzeriaItaliana : Pizzeria
    {
        public override Pizza CrearPizza(string descripcion, decimal precio)
        {
            return new PizzaNapolitana(descripcion, precio);
        }
    }
}
