namespace AdapterPattern.Models
{
    public class ElectricoAdapter : Motor
    {
        private MotorElectrico _motorelectrico;
        public ElectricoAdapter()
        {
            _motorelectrico = new MotorElectrico();
        }
        public override void Acelerar()
        {
            _motorelectrico.Mover();
        }

        public override void Detener()
        {
            _motorelectrico.Desactivar();
            _motorelectrico.Parar();
        }

        public override void Arrancar()
        {
            _motorelectrico.Conectar();
            _motorelectrico.Activar();
        }

        public override void CargarCombustible()
        {
            _motorelectrico.Enchufar();
        }
    }
}