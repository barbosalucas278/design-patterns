using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Models
{
    public class Pistola : Arma
    {
        public override string Disparar()
        {
            return "Se ha disparado una pistola!";
        }
    }
}
