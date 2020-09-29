using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class Pizza
    {
        private int _number;
        private string _size;
        private double _price;




        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
