using System;

namespace PrototypePattern.Models
{
    public abstract class AutoPrototype
    {
        protected string _color;
        protected string _modelo;
        public string Color { set => _color = value; }
        public string Modelo { set => _modelo = value; }
        public abstract AutoPrototype Clonar();
        public abstract string VerAuto();
    }
}
