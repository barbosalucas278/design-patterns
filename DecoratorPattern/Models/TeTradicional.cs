namespace DecoratorPattern.Models
{
    public class TeTradicional : BebidaComponent
    {
        public override double Costo => 5;

        public override string Descripcion => "Un tecito rico";
    }
}