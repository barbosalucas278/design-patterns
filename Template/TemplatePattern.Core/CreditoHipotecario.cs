using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Core
{
    public class CreditoHipotecario : Credito
    {
        public CreditoHipotecario(Cliente cliente) : base(cliente)
        {
        }

        protected override string VerificarAcciones()
        {
            return "Se verifican acciones aptas para un credito hipotecario";
        }

        protected override string VerificarBalances()
        {
            return "Se verifican los balances anuales del ultimo año";
        }

        protected override string VerificarCreditos()
        {
            return "Se verifica que no tenga creditos activos";
        }

        protected override string VerificarIngresos()
        {
            return "Se verifica que tenga ingresos declarados";
        }
    }
}
