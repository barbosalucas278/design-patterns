using InterpreterPattern.Core;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

namespace InterpreterPattern.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrBuffer;
            Context contexto = new Context();
            List<IExpression> expressions = new List<IExpression>();
            Console.WriteLine("Ingrese la expresion que quiere resolver:");
            string input = Console.ReadLine();
            arrBuffer = input.Split(" ");
            IExpression expression;

            foreach (var elemento in arrBuffer)
            {
                if (contexto.GetInteger(elemento) >= 0)
                {
                    expression = new NumericExpression(elemento);
                }
                else
                {
                    expression = new OperatorExpression(elemento);
                }
                expression.Interpret(contexto);
            }
            Console.WriteLine($"El resultado para '{input}' es {contexto.Result}");
        }
    }
}
