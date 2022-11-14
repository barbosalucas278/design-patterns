using AbstractFactory;
using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzeria pizzeria;
            pizzeria = new PizzeriaArgentina();

            Pizza pizza = pizzeria.CrearPizza("Una buena pizza con mucha muza", 150);
            Console.WriteLine(pizza.Descripcion);

            pizzeria = new PizzeriaItaliana();
            pizza = pizzeria.CrearPizza("Napolitana con mucho ajo", 200);
            Console.WriteLine(pizza.Descripcion);

            Console.ReadKey();
        }
    }
}
