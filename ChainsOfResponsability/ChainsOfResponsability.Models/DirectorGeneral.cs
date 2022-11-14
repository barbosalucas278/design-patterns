using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainsOfResponsability.Models
{
    public class DirectorGeneral : Aprobador
    {
        public override void Procesar(Compra compra)
        {
            Console.WriteLine("Compra procesada por el director general : $" + compra.Importe);
        }
    }
}
