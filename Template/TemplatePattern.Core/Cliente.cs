namespace TemplateMethodPattern.Core
{
    public class Cliente
    {
        public Cliente(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}