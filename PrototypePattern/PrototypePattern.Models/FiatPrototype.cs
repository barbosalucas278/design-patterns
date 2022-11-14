using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Models
{
    public class FiatPrototype : AutoPrototype
    {
        public override AutoPrototype Clonar()
        {
            return (FiatPrototype)this.MemberwiseClone();
        }

        public override string VerAuto()
        {
            return $"Fiat Modelo: {_modelo}, Color: {_color}";
        }
    }
}
