using BuilderPattern.Models;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBuilder builderItaliana = new PizzaItalianaBuilder();
            PizzaBuilder builderVegana = new PizzaVeganaBuilder();
            PizzaBuilder builderPrimavera = new PizzaPrimaveraBuilder();

            Pizza pizzaItaliana = builderItaliana.BuildPizza();
            Pizza pizzaVegana = builderVegana.BuildPizza();
            Pizza pizzaPrimavera = builderPrimavera.BuildPizza();

            Console.WriteLine(pizzaItaliana.ToString());
            Console.WriteLine(pizzaVegana.ToString());
            Console.WriteLine(pizzaPrimavera.ToString());

            Console.ReadKey();
        }
    }
}
