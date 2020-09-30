using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            
            Topping topping1 = new Topping(); topping1.Type = "Pepperoni";
            Topping topping2 = new Topping(); topping2.Type = "Ham";
            Topping topping3 = new Topping(); topping3.Type = "banana";

            Pizza pizza1 = new Pizza();
            pizza1.Size = "Medium";
            pizza1.Number = 2;
            pizza1.Price = 70.79;
            pizza1.Topping = topping1;

            Pizza pizza2 = new Pizza();
            pizza2.Size = "Small";
            pizza2.Number = 6;
            pizza2.Price = 40.39;
            pizza2.Topping = topping2;

            Pizza pizza3 = new Pizza();
            pizza3.Size = "Large";
            pizza3.Number = 9;
            pizza3.Price = 70.60;
            pizza3.Topping = topping3;

            Customer customer1 = new Customer();
            customer1.Name = "John";
            customer1.Email = "john@gmail.com";
            customer1.Phone = "919191919";
            customer1.Address = "Denmarkvej";

            Customer customer2 = new Customer();
            customer1.Name = "Jane";
            customer1.Email = "jane@gmail.com";
            customer1.Phone = "818181818";
            customer1.Address = "Copenhagenvej";

            Customer customer3 = new Customer();
            customer1.Name = "paul";
            customer1.Email = "paul@gmail.com";
            customer1.Phone = "2727272727";
            customer1.Address = "Swedenvej";

            Order order1 = new Order(22, DateTime.Now);
            order1.Customer = customer1;
            order1.Pizza = pizza1;

            Order order2 = new Order(34, DateTime.Now);
            order1.Customer = customer2;
            order1.Pizza = pizza2;

            Order order3 = new Order(22, DateTime.Now);
            order1.Customer = customer3;
            order1.Pizza = pizza3;



        }
    }
}
