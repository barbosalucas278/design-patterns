using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Core
{
    public abstract class Credito : Verificaciones
    {
        protected Credito(Cliente cliente)
        {
            _cliente = cliente;
        }

        protected override abstract string VerificarIngresos();

        protected override abstract string VerificarCreditos();

        protected override abstract string VerificarBalances();

        protected override abstract string VerificarAcciones();
    }
}
