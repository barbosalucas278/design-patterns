namespace StatePattern.Core
{
    public class Apagado : Estado
    {
        public override void ControlarEstado(Switch @switch)
        {
            @switch.DefinirEstado(new Encendido());
        }

        public override string Describir()
        {
            return "Switch Apagado";
        }
    }
}