using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainsOfResponsability.Models
{
    public class Director : Aprobador
    {
        public override void Procesar(Compra compra)
        {
            if (compra.Importe <= 5000)
            {
                Console.WriteLine("Compra procesada por el Director : $" + compra.Importe);
            }
            else
            {
                _siguiente.Procesar(compra);
            }
        }
    }
}
