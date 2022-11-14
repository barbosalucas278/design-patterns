using System.Collections.Generic;

namespace CompositePattern.Models
{
    public abstract class Componente
    {
        private string _name;
        public Componente(string name)
        {
            _name = name;
        }
        public string Name { get { return _name; } }
        public abstract void AddChild(Componente child);
        public abstract IList<Componente> GetChildren();
        public abstract int GetSize { get; }
    }
}