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
            Customer customer1 = new Customer();
            customer1.Name = "John";
            customer1.Address = "Københavnsvej";
            customer1.Email = "john@gmail.com";
            customer1.Phone = "+351928020747";

            Pizza pizza1 = new Pizza();
            pizza1.Number = 1;
            pizza1.Price = 10.3;
            pizza1.Size = "Medium";
            
            Order order1 = new Order(1,DateTime.Now);
            order1.Customer = customer1;
            order1.Pizza = pizza1;

            Console.WriteLine($"The order number {order1.OrderId} is made by the customer {customer1} " +
                              $"and ordered menu number Id-{order1.OrderId} and its {pizza1.Price} kr");

        }
    }
}
