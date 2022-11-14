namespace DecoratorPattern.Models
{
    public class CafeDescafeinado : BebidaComponent
    {
        public override double Costo => 20;

        public override string Descripcion => "FCafé descafeinado";
    }
}