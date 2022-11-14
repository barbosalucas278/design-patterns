using System;
using CommandPattern.Models;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpresaInvoker empresa = new EmpresaInvoker();
            ProductoReceiver producto = new ProductoReceiver("Papitas", 100);

            AltaStockCommand ordenDeAlta = new AltaStockCommand(producto, 10);
            empresa.TomarOrden(ordenDeAlta);
            BajaStockCommand ordenDeBaja = new BajaStockCommand(producto, 50);
            empresa.TomarOrden(ordenDeBaja);

            BajaStockCommand ordenDeBaja3 = new BajaStockCommand(producto, 10);
            empresa.TomarOrden(ordenDeBaja3);
            BajaStockCommand ordenDeBaja4 = new BajaStockCommand(producto, 20);
            empresa.TomarOrden(ordenDeBaja4);

            AltaStockCommand ordenDeAlta2 = new AltaStockCommand(producto, 100);
            empresa.TomarOrden(ordenDeAlta2);
            BajaStockCommand ordenDeBaja5 = new BajaStockCommand(producto, 50);
            empresa.TomarOrden(ordenDeBaja5);

            empresa.ProcesarOrdens();

            Console.WriteLine($"La cnatidad total del producto {producto.Nombre} es: {producto.Cantidad}");

        }
    }
}
