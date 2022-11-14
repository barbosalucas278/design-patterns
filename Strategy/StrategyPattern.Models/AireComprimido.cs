using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Models
{
    public class AireComprimido : Arma
    {
        public override string Disparar()
        {
            return "Se ha disparado un arma de aire comprimido!";
        }
    }
}
