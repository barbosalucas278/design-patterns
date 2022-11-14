namespace DecoratorPattern.Models.Decorator
{
    public class Crema : AgregadoDecorator
    {
        public Crema(BebidaComponent bebida) : base(bebida)
        {
        }

        public override double Costo => _bebida.Costo + 3;

        public override string Descripcion => $"{_bebida.Descripcion}, Crema";
    }
}