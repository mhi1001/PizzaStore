using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class Pizza
    {
        private string _name;
        private string _size;
        private double _price;

        private Topping _topping;


        public String Name
        {
            get { return _name; }
            set { _name = value; }
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

        public Topping Topping
        {
            get { return _topping; }
            set { _topping = value; }
        }
    }
}
