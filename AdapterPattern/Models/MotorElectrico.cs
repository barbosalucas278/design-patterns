namespace AdapterPattern.Models
{
    public class MotorElectrico
    {
        private bool _conectado;
        private bool _activo;
        private bool _moviendo;
        public void Activar()
        {
            if (!_conectado)
            {
                System.Console.WriteLine("imposible activar un motor que no esté conectado");
            }
            else
            {
                _activo = true;
                System.Console.WriteLine("Motor activado...");
            }
        }
        public void Conectar()
        {
            if (_conectado)
            {
                System.Console.WriteLine("Imposible conectar un motor electrico ya conectado");
            }
            else
            {
                _conectado = true;
                System.Console.WriteLine("Motor conectado...");
            }
        }
        public void Desactivar()
        {
            if (_activo)
            {
                _activo = false;
                System.Console.WriteLine("Desconectando motor electrico...");
            }
            else
            {
                System.Console.WriteLine("El motor debe estar conectado para poder ser desconectado");
            }
        }
        public void Enchufar()
        {
            if (!_activo)
            {
                System.Console.WriteLine("Enchufando motor electrico...");
            }
            else
            {
                _conectado = true;
                System.Console.WriteLine("Imposible enchufar un motor activo");
            }
        }
        public void Mover()
        {
            if (_conectado && _activo)
            {
                _moviendo = true;
                System.Console.WriteLine("moviendo motor electrico...");
            }
            else
            {
                System.Console.WriteLine("el motor se debera conectar y estar activo");
            }
        }
        public void Parar()
        {
            if (_moviendo)
            {
                _moviendo = false;
                System.Console.WriteLine("Parando motor electrico...");
            }
            else
            {
                System.Console.WriteLine("El motordebe estar en movimiento");
            }
        }
    }
}