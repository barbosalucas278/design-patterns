namespace StrategyPattern.Models
{
    public class Jugador
    {
        Arma _estrategia;

        public Jugador(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get; set; }
        public void CambiarEstrategia(Arma estrategia)
        {
            _estrategia = estrategia;
        }
        public string Disparar()
        {
            if (_estrategia is null)
            {
                return "Arma no disponible";
            }

            return _estrategia.Disparar();
        }
    }
}