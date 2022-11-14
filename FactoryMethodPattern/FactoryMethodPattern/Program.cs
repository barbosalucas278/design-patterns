using FactoryMethod;
using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzeria pizzeria;
            Pizza pizza;

            pizzeria = new PizzeriaArgentina();
            pizza = pizzeria.CrearPizza(Pizzeria.TiposDePizza.Cancha);
            pizza.Render();
            pizza = pizzeria.CrearPizza(Pizzeria.TiposDePizza.Napolitana);
            pizza.Render();

            Console.WriteLine("-------------------------------------");

            pizzeria = new PizzeriaItaliana();
            pizza = pizzeria.CrearPizza(Pizzeria.TiposDePizza.Cancha);
            pizza.Render();
            pizza = pizzeria.CrearPizza(Pizzeria.TiposDePizza.Napolitana);
            pizza.Render();

            Console.ReadKey();
        }
    }
}
