namespace DecoratorPattern.Models.Decorator
{
    public class Azucar : AgregadoDecorator
    {
        public Azucar(BebidaComponent bebida) : base(bebida)
        {
        }

        public override double Costo => _bebida.Costo + 0.5;

        public override string Descripcion => $"{_bebida.Descripcion}, Azucar";
    }
}