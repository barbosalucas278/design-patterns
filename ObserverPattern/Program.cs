using System;
using ObserverPatter.Models;
namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto p1 = new Producto("Coca-Cola", 150.5);
            Producto p2 = new Producto("Pepsi", 170);

            Usuario u1 = new Usuario("Lucas", "Barbosa");
            Usuario u2 = new Usuario("Harry", "Potter");
            Usuario u3 = new Usuario("Jonh", "Snow");

            p1.Agregar(u1);
            p1.Agregar(u2);
            p2.Agregar(u3);

            p1.Precio = 300;
            p2.Precio = 200;

            System.Console.WriteLine("----------------------------------");

            p1.Quitar(u2);
            p1.Precio = 100;
            Console.ReadKey();
        }
    }
}
