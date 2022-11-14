namespace BuilderPattern.Models.Salsas
{
    public abstract class Salsa
    {
        protected string _descripcion;

        public override string ToString()
        {
            return _descripcion;
        }
    }
}