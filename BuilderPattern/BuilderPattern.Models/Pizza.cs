using BuilderPattern.Models.Agregados;
using BuilderPattern.Models.Masas;
using BuilderPattern.Models.Salsas;

namespace BuilderPattern.Models
{
    public class Pizza
    {
        private Agregado _agregado;
        private Masa _masa;
        private Salsa _salsa;
        private string _descripcion;

        public Pizza(Agregado agregado, Masa masa, Salsa salsa, string descripcion)
        {
            _agregado = agregado;
            _masa = masa;
            _salsa = salsa;
            _descripcion = descripcion;
        }
        public override string ToString()
        {
            return $"{_descripcion}, Agregado: {_agregado}, Masa: {_masa}, Salsa: {_salsa}";
        }
    }
}