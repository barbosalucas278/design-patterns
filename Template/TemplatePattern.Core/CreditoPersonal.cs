using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Core
{
    public class CreditoPersonal : Credito
    {
        public CreditoPersonal(Cliente cliente) : base(cliente)
        {
        }

        protected override string VerificarAcciones()
        {
            return "Se verifican acciones aptas para un credito personal";
        }

        protected override string VerificarBalances()
        {
            return "Se verifican los balances anuales de los ultimos 3 años";
        }

        protected override string VerificarCreditos()
        {
            return "Se verifica que tenga creditos activos";
        }

        protected override string VerificarIngresos()
        {
            return "Se verifica que tenga ingresos declarados en los ultimos 3 años";
        }
    }
}
