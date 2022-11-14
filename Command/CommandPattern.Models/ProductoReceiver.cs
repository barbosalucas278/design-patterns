using System;

namespace CommandPattern.Models
{
    public class ProductoReceiver
    {
        public ProductoReceiver(string nombre, double cantidad)
        {
            Nombre = nombre;
            Cantidad = cantidad;
        }

        public string Nombre { get; set; }
        public double Cantidad { get; set; }
        internal void RestarStock(double cantidad)
        {
            Cantidad -= cantidad;
            Console.WriteLine($"Quitando {cantidad} unidades");
        }

        internal void SumarStock(double cantidad)
        {
            Cantidad += cantidad;
            Console.WriteLine($"Agregando {cantidad} unidades");
        }
    }
}