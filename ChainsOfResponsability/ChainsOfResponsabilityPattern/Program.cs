using System;
using ChainsOfResponsability.Models;

namespace ChainsOfResponsabilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var aprobadorDeCompras = new AprobadorDeCompras();

            double importe = 1;
            Compra compra = new Compra();
            while (importe != 0)
            {
                Console.WriteLine("ingrese el monto de la compra a procesar");
                importe = double.Parse(Console.ReadLine());
                compra.Importe = importe;
                aprobadorDeCompras.ProcesarCompra(compra);
            }
        }
    }
}
