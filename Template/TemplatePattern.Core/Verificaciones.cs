using System.Collections.Generic;

namespace TemplateMethodPattern.Core
{
    public abstract class Verificaciones
    {
        protected Cliente _cliente;
        public string[] Verificar()
        {
            var mensajes = new List<string>();
            mensajes.Add("Haciendo verificaciones para el usuario: " + _cliente.Nombre);
            mensajes.Add(VerificarAcciones());
            mensajes.Add(VerificarBalances());
            mensajes.Add(VerificarCreditos());
            mensajes.Add(VerificarIngresos());

            return mensajes.ToArray();
        }

        protected abstract string VerificarIngresos();

        protected abstract string VerificarCreditos();

        protected abstract string VerificarBalances();

        protected abstract string VerificarAcciones();
    }
}