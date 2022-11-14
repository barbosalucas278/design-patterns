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
    public class PizzaVeganaBuilder : PizzaBuilder
    {
        public PizzaVeganaBuilder()
        {
            _descripcion = "Pizza Vegana";
        }
        protected override Agregado BuildAgregado()
        {
            return new AgregadoAceituna();
        }

        protected override Masa BuildMasa()
        {
            return new MasaIntegral();
        }

        protected override Salsa BuildSalsa()
        {
            return new SalsaVegana();
        }
    }
}
