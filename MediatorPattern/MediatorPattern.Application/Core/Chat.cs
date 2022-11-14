using System.Collections.Generic;

namespace MediatorPattern.App.Core
{
    public abstract class Chat
    {
        protected List<Mensaje> _mensajes;
        public Chat()
        {
            _mensajes = new List<Mensaje>();
        }

        public Mensaje[] Mensajes
        {
            get
            {
                return _mensajes.ToArray();
            }
        }
        public abstract void Enviar(string mensaje, Usuario para, Usuario de);
        public abstract void Registrar(Usuario usuario);
    }
}