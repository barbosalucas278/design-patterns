namespace DecoratorPattern.Models
{
    public class CafeExpresso : BebidaComponent
    {
        public override double Costo => 30;

        public override string Descripcion => "Un cafecito expresso...";
    }
}