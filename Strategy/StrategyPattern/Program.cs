using System;
using StrategyPattern.Models;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador = new Jugador("Lucas");

            //Jugador sin arma asignada
            Console.WriteLine(jugador.Disparar());

            jugador.CambiarEstrategia(new Pistola());
            Console.WriteLine(jugador.Disparar());

            jugador.CambiarEstrategia(new Bazooka());
            Console.WriteLine(jugador.Disparar());

            jugador.CambiarEstrategia(new Ak47());
            Console.WriteLine(jugador.Disparar());

            jugador.CambiarEstrategia(new AireComprimido());
            Console.WriteLine(jugador.Disparar());


            Console.ReadKey();
        }
    }
}
