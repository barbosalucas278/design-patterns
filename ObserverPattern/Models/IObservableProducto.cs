namespace ObserverPatter.Models
{
    public interface IObservableProducto
    {
        void Agregar(IObserverUsuario usuario);
        void Notificar();
        void Quitar(IObserverUsuario usuario);
    }
}