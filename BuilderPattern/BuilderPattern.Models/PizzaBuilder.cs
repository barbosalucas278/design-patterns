using BuilderPattern.Models.Agregados;
using BuilderPattern.Models.Masas;
using BuilderPattern.Models.Salsas;
using System;

namespace BuilderPattern.Models
{
    public abstract class PizzaBuilder
    {
        protected string _descripcion;

        protected abstract Agregado BuildAgregado();
        protected abstract Masa BuildMasa();
        protected abstract Salsa BuildSalsa();
        public Pizza BuildPizza()
        {
            Agregado agregado = BuildAgregado();
            Masa masa = BuildMasa();
            Salsa salsa = BuildSalsa();
            return new Pizza(agregado, masa, salsa, _descripcion);
        }
        public override string ToString()
        {
            return _descripcion;
        }
    }
}
