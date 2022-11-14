using System;
using CompositePattern.Models;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Componente root = new Directorio("Directorio Raiz");
            Componente directorio1 = new Directorio("Directorio 1");
            Componente directorio2 = new Directorio("Directorio 2");
            Componente directorio3 = new Directorio("Directorio 3");

            Componente archivo1 = new Archivo(200, "Archivo 1");
            Componente archivo2 = new Archivo(500, "Archivo 2");
            Componente archivo3 = new Archivo(1000, "Archivo 3");
            Componente archivo4 = new Archivo(150, "Archivo 4");
            Componente archivo5 = new Archivo(10, "Archivo 5");

            root.AddChild(directorio1);
            directorio2.AddChild(directorio3);
            root.AddChild(directorio2);

            directorio1.AddChild(archivo1);
            directorio2.AddChild(archivo2);
            directorio3.AddChild(archivo3);
            directorio1.AddChild(archivo4);
            directorio3.AddChild(archivo5);

            System.Console.WriteLine("Size of Root " + root.GetSize);
            System.Console.WriteLine("Size of Directory 1 " + directorio1.GetSize);
            System.Console.WriteLine("Size of Directory 2 " + directorio2.GetSize);
            System.Console.WriteLine("Size of Directory 3 " + directorio3.GetSize);
            Console.ReadKey();
        }
    }
}
