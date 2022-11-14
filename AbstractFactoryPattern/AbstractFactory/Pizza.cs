using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Pizza
    {
        protected Pizza(string descripcion, decimal precio)
        {
            Descripcion = descripcion;
            Precio = precio;
        }

        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public override string ToString()
        {
            return $"{Descripcion} ${Precio}";
        }
    }
}
