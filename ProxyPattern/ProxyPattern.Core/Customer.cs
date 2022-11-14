using System;

namespace ProxyPattern.Core
{
    public class Customer
    {
        public Customer(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get; set; }

    }
}
