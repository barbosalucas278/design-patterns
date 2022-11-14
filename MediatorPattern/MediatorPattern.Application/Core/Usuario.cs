using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.App.Core
{
    public abstract class Usuario
    {
        List<Mensaje> _mensajes;
        string _nombre;
        public Chat Chat { get; set; }
        public Usuario(string nombre)
        {
            _nombre = nombre;
            _mensajes = new List<Mensaje>();
        }
        public Mensaje[] Mensajes
        {
            get { return _mensajes.ToArray(); }
        }

        public string Nombre
        {
            get { return _nombre; }
        }
        public override string ToString()
        {
            return _nombre;
        }
        public void Enviar (string mensaje, Usuario para)
        {
            Chat.Enviar(mensaje, para, this);
        }

        public void Recibir (Mensaje mensaje)
        {
            _mensajes.Add(mensaje);
        }
    }
}
