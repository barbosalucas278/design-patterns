using System;
using DecoratorPattern.Models;
using DecoratorPattern.Models.Decorator;
namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BebidaComponent cafecito = new CafeSolo();
            cafecito = new Leche(cafecito);
            cafecito = new Azucar(cafecito);

            System.Console.WriteLine(cafecito.Descripcion);

        }
    }
}
