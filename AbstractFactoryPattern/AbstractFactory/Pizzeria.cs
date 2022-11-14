using System;

namespace AbstractFactory
{
    public abstract class Pizzeria
    {
        public abstract Pizza CrearPizza(string descripcion, decimal precio);
    }
}
