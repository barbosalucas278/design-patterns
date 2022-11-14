
using System;
using System.Collections.Generic;

namespace CompositePattern.Models
{
    public class Archivo : Componente
    {
        private int _size;
        public Archivo(int size, string name) : base(name)
        {
            _size = size;
        }
        public override void AddChild(Componente child)
        {
            throw new NotImplementedException();
        }

        public override IList<Componente> GetChildren()
        {
            throw new NotImplementedException();
        }

        public override int GetSize
        {
            get
            {
                return _size;
            }
        }
    }
}