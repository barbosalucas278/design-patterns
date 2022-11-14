using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Models
{
    public class AlfaRomeroPrototype : AutoPrototype
    {
        public override AutoPrototype Clonar()
        {
            return (AlfaRomeroPrototype)this.MemberwiseClone();
        }

        public override string VerAuto()
        {
            return $"Alfa Romeo Modelo: {_modelo}, Color: {_color}";
        }
    }
}
