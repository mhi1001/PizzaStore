using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class Topping
    {
        private string _type;
        private double _price;


        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public override string ToString()
        {
            return $"{Type}";
        }
    }
}
