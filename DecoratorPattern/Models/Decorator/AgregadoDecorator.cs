namespace DecoratorPattern.Models.Decorator
{
    public abstract class AgregadoDecorator : BebidaComponent
    {
        protected BebidaComponent _bebida;
        public AgregadoDecorator(BebidaComponent bebida)
        {
            _bebida = bebida;
        }
    }
}