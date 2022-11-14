using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class Palabra : IEnumerable
    {
        private string _palabra;
        public Palabra(string palabra)
        {
            _palabra = palabra;
        }
        public IEnumerator GetEnumerator()
        {
            return new PalabraIterator(_palabra);
        }
    }
}
