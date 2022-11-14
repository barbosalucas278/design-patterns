namespace CommandPattern.Models
{
    public abstract class OrdenCommand
    {
        protected ProductoReceiver _producto;
        protected double _cantidad;

        protected OrdenCommand(ProductoReceiver producto, double cantidad)
        {
            _producto = producto;
            _cantidad = cantidad;
        }
        public abstract void Ejecutar();
    }
}