namespace BuilderPattern.Models.Agregados
{
    public abstract class Agregado
    {
        protected string _descripcion;
        public override string ToString()
        {
            return _descripcion;
        }
    }
}