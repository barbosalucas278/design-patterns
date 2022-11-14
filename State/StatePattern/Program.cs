using System;
using StatePattern.Core;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Switch sw = new Switch();

            sw.Presionar();
            sw.Presionar();
            sw.Presionar();
            sw.Presionar();
            sw.Presionar();

            Console.ReadKey();
        }
    }
}
