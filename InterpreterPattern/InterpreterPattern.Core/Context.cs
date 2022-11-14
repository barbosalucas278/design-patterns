using System;

namespace InterpreterPattern.Core
{
    public class Context
    {
        private string _proximaOperacion = "";
        private int _operador = 0;
        private int _resultado = 0;
        internal void Calculate()
        {
            if (_proximaOperacion == "+"|| _proximaOperacion == "")
            {
                _resultado += _operador;
            }
            else if (_proximaOperacion == "-")
            {
                _resultado -= _operador;
            }
        }

        public void SetOperator(int operador)
        {
            _operador = operador;
        }

        public int GetInteger(string value)
        {
            var valueNormalizado = value.ToLower();
            return valueNormalizado switch
            {
                "cero" => 0,
                "uno" => 1,
                "dos" => 2,
                "tres" => 3,
                "cuatro" => 4,
                "cinco" => 5,
                "seis" => 6,
                "siete" => 7,
                "ocho" => 8,
                "nueve" => 9,
                _ => -1,
            };
        }

        public void SetOperation(string operation)
        {
            var operationNormalizada = operation.ToLower();
            if (operationNormalizada == "mas")
            {
                _proximaOperacion = "+";
            }
            else
            {
                _proximaOperacion = "-";
            }
        }
        public int Result
        {
            get
            {
                return _resultado;
            }
        }
    }
}