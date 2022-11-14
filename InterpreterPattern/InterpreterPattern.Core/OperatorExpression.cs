using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern.Core
{
    public class OperatorExpression : IExpression
    {
        private string _operation;
        public OperatorExpression(string token)
        {
            _operation = token;
        }
        public void Interpret(Context context)
        {
            context.SetOperation(_operation);
        }
    }
}
