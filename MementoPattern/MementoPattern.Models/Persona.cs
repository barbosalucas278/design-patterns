using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public Memento SaveToMemento()
        {
            Console.WriteLine("Se guardó un memento de persona para " + Nombre);
            return new Memento(Nombre);
        }
        public void RestoreMemento(Memento m)
        {
            Nombre = m.Estado;
            Console.WriteLine("Recuperando Memento de " + Nombre);
        }
    }
}
