namespace FactoryMethod
{
    public abstract class Pizza
    {
        protected string _origen;
        protected string _descripcion;

        protected Pizza(string origen)
        {
            _origen = origen;
        }
        public string Descripcion
        {
            set
            {
                _descripcion = value;
            }
        }
        public void Render()
        {
            System.Console.WriteLine($"{_descripcion} Origen: {_origen}");
        }
    }
}