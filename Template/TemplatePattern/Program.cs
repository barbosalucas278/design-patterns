using System;
using TemplateMethodPattern.Core;


namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Lucas");
            Credito credito;

            credito = new CreditoHipotecario(cliente);
            var verificacionesHipotecario = credito.Verificar();
            foreach (var verificacion in verificacionesHipotecario)
            {
                Console.WriteLine(verificacion);
            }
            Console.WriteLine("--------------------------");

            credito = new CreditoPersonal(cliente);
            var verificacionesPersonal = credito.Verificar();
            foreach (var verificaciones in verificacionesPersonal)
            {
                Console.WriteLine(verificaciones);
            }

            Console.ReadKey();
        }
    }
}
