using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.Models
{
    public class Caretaker
    {
        private List<Memento> _mementos = new List<Memento>();

        public void Add(Memento memento)
        {
            _mementos.Add(memento);
        }
        public Memento GetMemento(int index)
        {
            return _mementos[index];
        }
    }
}
