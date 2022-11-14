using PrototypePattern.Models;
using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoPrototype prototipoFiat = new FiatPrototype();
            AutoPrototype prototipoAlfaRomeo = new AlfaRomeroPrototype();
            AutoPrototype prototipoDS = new DSPrototype();

            AutoPrototype fiatPalio = prototipoFiat.Clonar();
            fiatPalio.Modelo = "Palio Fire";
            fiatPalio.Color = "Negro";
            Console.WriteLine(fiatPalio.VerAuto());

            AutoPrototype fiatUno = prototipoFiat.Clonar();
            fiatUno.Modelo = "Uno";
            fiatUno.Color = "Blanco";
            Console.WriteLine(fiatUno.VerAuto());

            AutoPrototype alfaRomeo145 = prototipoAlfaRomeo.Clonar();
            alfaRomeo145.Modelo = "145";
            alfaRomeo145.Color = "Verde";
            Console.WriteLine(alfaRomeo145.VerAuto());

            AutoPrototype alfaRomeo146 = prototipoAlfaRomeo.Clonar();
            alfaRomeo146.Modelo = "146";
            alfaRomeo146.Color = "Azul";
            Console.WriteLine(alfaRomeo146.VerAuto());

            AutoPrototype DS4Sport = prototipoDS.Clonar();
            DS4Sport.Modelo = "4 Sport";
            DS4Sport.Color = "Azul";
            Console.WriteLine(DS4Sport.VerAuto());

            AutoPrototype DS6Sport = prototipoDS.Clonar();
            DS6Sport.Modelo = "6 Sport";
            DS6Sport.Color = "Azul";
            Console.WriteLine(DS6Sport.VerAuto());

            Console.ReadKey();
        }
    }
}
