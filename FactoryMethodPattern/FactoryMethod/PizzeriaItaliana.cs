using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class PizzeriaItaliana : Pizzeria
    {
        public override Pizza CrearPizza(TiposDePizza tipo)
        {
            switch (tipo)
            {
                case TiposDePizza.Cancha:
                    return new PizzaCancha("Italia");
                case TiposDePizza.Napolitana:
                    return new PizzaNapolitana("Italia");
                default:
                    return null;
            }
        }
    }
}
