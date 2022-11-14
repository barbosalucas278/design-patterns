using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern.Core
{
    public class NumericExpression : IExpression
    {
        private string _value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="token">Numero expresado en un string, en palabra</param>
        public NumericExpression(string token)
        {
            _value = token;
        }

        public void Interpret(Context context)
        {
            context.SetOperator(context.GetInteger(_value));
            context.Calculate();
        }
    }
}
