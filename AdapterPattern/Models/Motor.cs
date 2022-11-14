namespace AdapterPattern.Models
{
    public abstract class Motor
    {
        public abstract void Acelerar();
        public abstract void Detener();
        public abstract void Arrancar();
        public abstract void CargarCombustible();

    }
}