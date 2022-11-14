using System;

namespace FactoryMethod
{
    public abstract class Pizzeria
    {
        public enum TiposDePizza
        {
            Cancha,
            Napolitana
        }
        public abstract Pizza CrearPizza(TiposDePizza tipo);
    }
}
