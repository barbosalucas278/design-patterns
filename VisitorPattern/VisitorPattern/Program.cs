using System;
using VisitorPattern.Models;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductoClase1 producto1 = new ProductoClase1();
            producto1.Precio = 100;
            ProductoClase2 producto2 = new ProductoClase2();
            producto2.Precio = 100;

            var iva = new IVA();
            Console.WriteLine($"El precio total para el producto 1 es de : ${iva.Visitar(producto1)}");
            Console.WriteLine($"El precio total para el producto 2 es de : ${iva.Visitar(producto2)}");
            Console.ReadKey();
        }
    }
}
