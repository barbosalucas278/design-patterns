using System.Collections.Generic;

namespace CompositePattern.Models
{
    public class Directorio : Componente
    {
        private IList<Componente> _children;
        public Directorio(string name) : base(name)
        {
            _children = new List<Componente>();
        }
        public override void AddChild(Componente child)
        {
            _children.Add(child);
        }

        public override IList<Componente> GetChildren()
        {
            return _children;
        }

        public override int GetSize
        {
            get
            {
                int size = 0;
                foreach (var item in _children)
                {
                    size += item.GetSize;
                }
                return size;
            }
        }
    }
}