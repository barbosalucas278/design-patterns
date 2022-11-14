using System.Collections;

namespace IteratorPattern
{
    public class PalabraIterator : IEnumerator
    {
        private char[] _palabra;
        private int _posicion;

        public PalabraIterator(string palabra)
        {
            _palabra = palabra.ToUpper().ToCharArray();
            _posicion = -1;
        }

        public object Current => _palabra[_posicion];

        public bool MoveNext()
        {
            if(_posicion < _palabra.Length - 1)
            {
                _posicion++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _posicion = -1;
        }
    }
}