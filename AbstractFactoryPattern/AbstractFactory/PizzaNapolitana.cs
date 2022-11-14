﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PizzaNapolitana : Pizza
    {
        public PizzaNapolitana(string descripcion, decimal precio) : base(descripcion, precio)
        {
        }
    }
}
