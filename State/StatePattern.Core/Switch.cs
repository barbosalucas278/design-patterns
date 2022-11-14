using System;

namespace StatePattern.Core
{
    public class Switch
    {
        Estado _estado;
        public Switch()
        {
            _estado = new Encendido();
        }
        
        public void DefinirEstado(Estado estado)
        {
            _estado = estado;
        }

        public void Presionar()
        {
            _estado.ControlarEstado(this);
            Console.WriteLine(_estado.Describir());
        }
    }
}