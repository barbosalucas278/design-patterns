using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Palabra palabra = new Palabra("Hola mundo");

            foreach (var letra in palabra)
            {
                Console.WriteLine(letra);
            }
        }
    }
}
