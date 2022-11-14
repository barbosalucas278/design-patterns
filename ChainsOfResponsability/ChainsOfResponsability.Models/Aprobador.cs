namespace ChainsOfResponsability.Models
{
    public abstract class Aprobador
    {
        protected Aprobador _siguiente;
        public void AgregarSiguiente(Aprobador aprobador)
        {
            _siguiente = aprobador;
        }
        public abstract void Procesar(Compra compra);
    }
}