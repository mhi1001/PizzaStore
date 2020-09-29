﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class Topping
    {
        private string _type;


        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public override string ToString()
        {
            return $"{Type}";
        }
    }
}
