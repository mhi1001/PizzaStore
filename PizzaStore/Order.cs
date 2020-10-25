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
        
        private Dictionary<int, Customer> _customer;
        private Dictionary<int, Pizza> _pizza;
        
        

        public Order(int id, DateTime date)
        {
            _customer = new Dictionary<int, Customer>();
            _pizza = new Dictionary<int, Pizza>();
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

        public Dictionary<int, Customer> Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        public Dictionary<int, Pizza> Pizza
        {
            get { return _pizza; }
            set { _pizza = value; }

        }

        public double CalculateTotalPrice() //calculates the price of all pizza and all of its ingredients + 40 kr tax inside an order
        {
           double totalPizzaPrice = _pizza.Values.Sum(pizza =>pizza.Price);
           double totalIngredientPrice = _pizza.Values.Sum(pizza => pizza.Ingredients.Sum(ingredients => ingredients.Price));
           
            return totalPizzaPrice + totalIngredientPrice + 40;
        }

        public void AddPizzaToOrder(int key, Pizza pizza)
        {
            Pizza.Add(key, pizza);
        }

        public void AddCustomerToOrder(int key, Customer customer)
        {
            Customer.Add(key, customer);
        }
          public override string ToString()
        {
            return $"{OrderId}";
        }
    }
}
