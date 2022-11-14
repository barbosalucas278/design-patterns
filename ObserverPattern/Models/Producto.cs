using System;
using System.Collections.Generic;

namespace ObserverPatter.Models
{
    public class Producto : IObservableProducto
    {
        private List<IObserverUsuario> _usuarios;
        private string _nombre;
        private double _precio;
        public Producto(string nombre, double precio)
        {
            _usuarios = new List<IObserverUsuario>();
            _nombre = nombre;
            _precio = precio;
        }
        public double Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
                this.Notificar();
            }
        }
        public void Notificar()
        {
            foreach (IObserverUsuario usuario in this._usuarios)
            {
                usuario.Actualizar(this);
            }
            if (_usuarios.Count == 0)
            {
                System.Console.WriteLine("No hay usuarios suscriptos");
            }
            System.Console.WriteLine("----------------------------------------------");
        }

        public void Agregar(IObserverUsuario usuario)
        {
            if (!_usuarios.Contains(usuario))
            {
                _usuarios.Add(usuario);
            }
            else
            {
                throw new Exception("Ya existe un usuario suscripto");
            }
        }

        public void Quitar(IObserverUsuario usuario)
        {
            if (_usuarios.Contains(usuario))
            {
                _usuarios.Remove(usuario);
            }
            else
            {
                throw new Exception("El usuario no esta suscripto");
            }
        }
        public override string ToString()
        {
            return $"{this._nombre} (${this.Precio})";
        }
    }
}