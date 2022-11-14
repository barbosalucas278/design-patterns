using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class PizzeriaArgentina : Pizzeria
    {
        public override Pizza CrearPizza(TiposDePizza tipo)
        {
            switch (tipo)
            {
                case TiposDePizza.Cancha:
                    return new PizzaCancha("Argentina");
                case TiposDePizza.Napolitana:
                    return new PizzaNapolitana("Argentina");
                default:
                    return null;
            }
        }
    }
}
