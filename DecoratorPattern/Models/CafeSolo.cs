namespace DecoratorPattern.Models
{
    public class CafeSolo : BebidaComponent
    {
        public override double Costo => 10;
        public override string Descripcion => "Cafe solo";
    }
}