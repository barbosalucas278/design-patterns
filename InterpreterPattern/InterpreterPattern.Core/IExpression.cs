using System;

namespace InterpreterPattern.Core
{
    public interface IExpression
    {
        void Interpret(Context context);
    }
}
