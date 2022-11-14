using BuilderPattern.Models.Agregados;
using BuilderPattern.Models.Masas;
using BuilderPattern.Models.Salsas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Models
{
    public class PizzaItalianaBuilder : PizzaBuilder
    {
        public PizzaItalianaBuilder()
        {
            _descripcion = "Pizza Italiana";
        }

        protected override Agregado BuildAgregado()
        {
            return new AgregadoMuzzarella();
        }

        protected override Masa BuildMasa()
        {
            return new MasaClasica();
        }

        protected override Salsa BuildSalsa()
        {
            return new SalsaCuatroQuesos();
        }
    }
}
