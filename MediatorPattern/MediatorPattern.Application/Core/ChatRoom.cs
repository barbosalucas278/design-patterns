using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.App.Core
{
    public class ChatRoom : Chat
    {
        IDictionary<string, Usuario> _participantes;
        public ChatRoom()
        {
            _participantes = new Dictionary<string, Usuario>();
        }
        public override void Enviar(string mensajeEntrante, Usuario emisor, Usuario receptor)
        {
            Mensaje mensaje = new Mensaje() { Texto = mensajeEntrante, De = receptor, Para = emisor };

            if (_participantes.ContainsKey(emisor.Nombre))
            {
                _participantes[emisor.Nombre].Recibir(mensaje);
                _mensajes.Add(mensaje);
            }
        }

        public override void Registrar(Usuario usuario)
        {
            if (!_participantes.ContainsKey(usuario.Nombre))
            {
                _participantes.Add(usuario.Nombre, usuario);
            }
        }
    }
}
