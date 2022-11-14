using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Models
{
    public class DSPrototype : AutoPrototype
    {
        public override AutoPrototype Clonar()
        {
            return (DSPrototype)this.MemberwiseClone();
        }
        public override string VerAuto()
        {
            return $"DS Modelo: {_modelo}, Color: {_color}";
        }
    }
}
