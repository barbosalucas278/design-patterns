namespace StatePattern.Core
{
    public class Encendido : Estado
    {
        public override void ControlarEstado(Switch @switch)
        {
            @switch.DefinirEstado(new Apagado());
        }

        public override string Describir()
        {
            return "Switch Encendido";
        }
    }
}