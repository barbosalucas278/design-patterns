namespace BuilderPattern.Models.Masas
{
    public abstract class Masa
    {
        protected string _descripcion;

        public override string ToString()
        {
            return _descripcion;
        }

    }
}