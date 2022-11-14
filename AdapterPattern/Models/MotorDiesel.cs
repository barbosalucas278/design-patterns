namespace AdapterPattern.Models
{
    public class MotorDiesel : Motor
    {
        public override void Acelerar()
        {
            System.Console.WriteLine("Acelerando el motor");
        }

        public override void Detener()
        {
            System.Console.WriteLine("Apagando el motor");
        }

        public override void Arrancar()
        {
            System.Console.WriteLine("Arrancando el motor");
        }

        public override void CargarCombustible()
        {
            System.Console.WriteLine("Cargando cumbustible...");
        }
    }
}