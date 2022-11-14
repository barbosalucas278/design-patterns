using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainsOfResponsability.Models
{
    public class Comprador : Aprobador
    {
        public override void Procesar(Compra compra)
        {
            if (compra.Importe < 100)
            {
                Console.WriteLine("Compra procesada por el comprador : $" + compra.Importe);
            }
            else
            {
                _siguiente.Procesar(compra);
            }
        }
    }
}
