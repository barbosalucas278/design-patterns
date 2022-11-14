using System;

namespace MediatorPattern.App.Core
{
    public class Mensaje
    {
        private DateTime _fecha;
        public string Texto { get; set; }
        public Usuario De { get; set; }
        public Usuario Para { get; set; }
        public DateTime Fecha { get { return _fecha; } }
        public Mensaje()
        {
            _fecha = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Mensaje a las {Fecha.ToShortTimeString()} de {De} para {Para} --> {Texto}";
        }
    }
}