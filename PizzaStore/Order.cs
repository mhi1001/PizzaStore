using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
   public class Order
    {
        private int _orderId;
        private DateTime _date;
        
        private Customer _customer;
        private Pizza _pizza;

        public Order(int id, DateTime date)
        {
            _customer = new Customer();
            _pizza = new Pizza();

            _orderId = id;
            _date = date;
        }

        public int OrderId
        {
            get { return _orderId; }
            set { _orderId = value; }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        public Pizza Pizza
        {
            get { return _pizza; }
            set { _pizza = value; }

        }

        //public double CalculateTotalPrice()
        //{
        //  //  return Pizza.Price + Pizza.ExistingIngredients.
        //}
        

        public override string ToString()
        {
            return $"{OrderId}";
        }
    }
}
