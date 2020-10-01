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
            
            Topping topping1 = new Topping(); topping1.Type = "Pepperoni"; topping1.Price = 8.5;
            Topping topping2 = new Topping(); topping2.Type = "Ham"; topping2.Price = 10.5;
            Topping topping3 = new Topping(); topping3.Type = "Banana"; topping3.Price = 11.5;

            Pizza pizza1 = new Pizza();
            pizza1.Size = "Medium";
            pizza1.Name = $"{topping1.Type} pizza"; 
            pizza1.Price = 70.79;
            pizza1.Topping = topping1;

            Pizza pizza2 = new Pizza();
            pizza2.Size = "Small";
            pizza2.Name = $"{topping2.Type} pizza"; 
            pizza2.Price = 40.39;
            pizza2.Topping = topping2;

            Pizza pizza3 = new Pizza();
            pizza3.Size = "Large";
            pizza3.Name = $"{topping3.Type} pizza";
            pizza3.Price = 70.60;
            pizza3.Topping = topping3;

            Customer customer1 = new Customer();
            customer1.Name = "John";
            customer1.Email = "john@gmail.com";
            customer1.Phone = "919191919";
            customer1.Address = "Denmarkvej";

            Customer customer2 = new Customer();
            customer2.Name = "Jane";
            customer2.Email = "jane@gmail.com";
            customer2.Phone = "818181818";
            customer2.Address = "Copenhagenvej";

            Customer customer3 = new Customer();
            customer3.Name = "Paul";
            customer3.Email = "paul@gmail.com";
            customer3.Phone = "2727272727";
            customer3.Address = "Swedenvej";

            Order order1 = new Order(22, DateTime.Now);
            order1.Customer = customer1;
            order1.Pizza = pizza1;

            Order order2 = new Order(34, DateTime.Now);
            order2.Customer = customer2;
            order2.Pizza = pizza2;

            Order order3 = new Order(22, DateTime.Now);
            order3.Customer = customer3;
            order3.Pizza = pizza3;

            double totalOrder1 = order1.CalculateTotalPrice();

            Console.WriteLine($"The order ID {order1.OrderId} at time {order1.Date} :\n" +
                              $"Pizza name is {order1.Pizza.Name}\n" +
                              $"Customer name is {order1.Customer.Name}\n" +
                              $"Total price of the order is {order1.CalculateTotalPrice()}\n\n");

            Console.WriteLine($"The order ID {order2.OrderId} at time {order2.Date} :\n" +
                              $"Pizza name is {order2.Pizza.Name}\n" +
                              $"Customer name is {order2.Customer.Name}\n" +
                              $"Total price of the order is {order2.CalculateTotalPrice()}\n\n");

            Console.WriteLine($"The order ID {order3.OrderId} at time {order3.Date} :\n" +
                              $"Pizza name is {order3.Pizza.Name}\n" +
                              $"Customer name is {order3.Customer.Name}\n" +
                              $"Total price of the order is {order3.CalculateTotalPrice()}\n\n");

        }
    }
}
