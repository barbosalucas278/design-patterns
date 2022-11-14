namespace StatePattern.Core
{
    public abstract class Estado
    {
        public abstract void ControlarEstado(Switch @switch);
        public abstract string Describir();
    }
}