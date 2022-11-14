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
    public class PizzaPrimaveraBuilder : PizzaBuilder
    {
        public PizzaPrimaveraBuilder()
        {
            _descripcion = "Pizza Primavera";
        }
        protected override Agregado BuildAgregado()
        {
            return new AgregadoAnana();
        }

        protected override Masa BuildMasa()
        {
            return new MasaMadre();
        }

        protected override Salsa BuildSalsa()
        {
            return new SalsaPortuguesa();
        }
    }
}
