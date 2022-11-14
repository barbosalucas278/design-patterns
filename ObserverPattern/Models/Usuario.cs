using System.Text;

namespace ObserverPatter.Models
{
    public class Usuario : IObserverUsuario
    {
        private string _nombre;
        private string _apellido;
        public Usuario(string nombre, string apellido)
        {
            _nombre = nombre;
            _apellido = apellido;
        }
        public void Actualizar(Producto p)
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine($"{this._nombre} {this._apellido} se a actualizó su suscripcion al producto:");
            st.AppendLine($"{p.ToString()}");
            System.Console.WriteLine(st.ToString());
        }
    }
}