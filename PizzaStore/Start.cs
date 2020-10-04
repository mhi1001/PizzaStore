using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class Start
    {
        public void MyCode()
        {
            //created private class only for this Start class, with all the content so i could call it
            //here inside MyCode so it would be easier to make this little menu.
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private bool MainMenu()
        {
            Topping topping1 = new Topping(); topping1.Type = "Pepperoni"; topping1.Price = 8.5;
            Topping topping2 = new Topping(); topping2.Type = "Ham"; topping2.Price = 10.5;
            Topping topping3 = new Topping(); topping3.Type = "Banana"; topping3.Price = 11.5;

            Pizza pizza1 = new Pizza();
            pizza1.Size = "Medium";
            pizza1.Name = $"MegaCool Pizza";
            pizza1.Price = 70.79;
            pizza1.Topping = topping1;

            Pizza pizza2 = new Pizza();
            pizza2.Size = "Small";
            pizza2.Name = $"SuperJumbo Pizza";
            pizza2.Price = 40.39;
            pizza2.Topping = topping2;

            Pizza pizza3 = new Pizza();
            pizza3.Size = "Large";
            pizza3.Name = $"SuperVegan Pizza";
            pizza3.Price = 70.60;
            pizza3.Topping = topping3;

            Customer customer1 = new Customer();
            customer1.Name = "John Smith";
            customer1.Email = "john@gmail.com";
            customer1.Phone = "919191919";
            customer1.Address = "Denmarkvej";

            Customer customer2 = new Customer();
            customer2.Name = "Jane Doe";
            customer2.Email = "jane@gmail.com";
            customer2.Phone = "818181818";
            customer2.Address = "Copenhagenvej";

            Customer customer3 = new Customer();
            customer3.Name = "Joseph Mcguire";
            customer3.Email = "Mcguire@gmail.com";
            customer3.Phone = "2727272727";
            customer3.Address = "Swedenvej";

            Order order1 = new Order(1, DateTime.Now);
            order1.Customer = customer1;
            order1.Pizza = pizza1;

            Order order2 = new Order(54, DateTime.Now);
            order2.Customer = customer2;
            order2.Pizza = pizza2;

            Order order3 = new Order(91, DateTime.Now);
            order3.Customer = customer3;
            order3.Pizza = pizza3;


            Console.Clear();
            Console.Write("------------------------------------------------\n");
            Console.Write("Welcome to BigMama's pizzeria management program\n");
            Console.Write("------------------------------------------------\n");
            Console.Write("\n");
            Console.Write("\nHere are the options :\n\n");
            Console.Write("1 -> As the owner, I want to display the ID, name of the pizzas and the total price for a single order\n\n" +
                          "2 -> As the owner/waiter, I want to display the name of the customer who made a specific order\n\n" +
                          "3 -> As a customer I want to know the total price\n\n" +
                          "4 -> As the owner, I want to know the specific order, who ordered it and contact/address details to deliver\n\n" +
                          "5 -> As a customer I want to know how much I am paying for toppings\n\n" +
                          "6 -> Exit Program\n\n");
            Console.Write("\nInput your choice :");


            switch (Console.ReadLine())
            {
                case "1":
                    //1.As the owner, I want to display the ID, name of the pizzas and the total price for a single order
                    Console.Clear();
                    Console.WriteLine($"The order ID {order1.OrderId} at time {order1.Date} :\n" +
                                      $"Pizza name is {order1.Pizza.Name}, with topping {order1.Pizza.Topping}\n" +
                                      $"Total price of the order with tax+delivery is {order1.CalculateTotalPrice()}\n\n");
                    Console.WriteLine("Press any key to go back to the menu");
                    Console.ReadLine();
                    return true;

                case "2":
                    Console.Clear();
                    //5.As the owner/waiter, I want to display the name of the customer who made a specific order
                    //Using order1.Customer instead of order1.Customer.Name to take advantage of the override ToString method
                    Console.WriteLine($"The order {order1.OrderId} was made by the customer {order1.Customer} at {order1.Date}");
                    Console.WriteLine($"The order {order2.OrderId} was made by the customer {order2.Customer} at {order2.Date}");
                    Console.WriteLine($"The order {order3.OrderId} was made by the customer {order3.Customer} at {order3.Date}");
                    Console.WriteLine("\nPress any key to go back to the menu");
                    Console.ReadLine();
                    return true;

                case "3":
                    Console.Clear();
                    //8.As a customer I want to know the total price
                    Console.WriteLine($"My name is {order1.Customer} and I ordered a {order1.Pizza} that was {order1.Pizza.Price} kr" +
                                      $"\nplus the {order1.Pizza.Topping} topping which was {order1.Pizza.Topping.Price}kr \n" +
                                      $"plus 40 kr tax/delivery which led me to pay {order1.CalculateTotalPrice()} kr\n\n");

                    Console.WriteLine($"My name is {order2.Customer} and I ordered a {order2.Pizza} that was {order2.Pizza.Price} kr" +
                                      $"\nplus the {order2.Pizza.Topping} topping which was {order2.Pizza.Topping.Price}kr \n" +
                                      $"plus 40 kr tax/delivery which led me to pay {order2.CalculateTotalPrice()} kr\n\n");

                    Console.WriteLine($"My name is {order3.Customer} and I ordered a {order3.Pizza} that was {order3.Pizza.Price} kr" +
                                      $"\nplus the {order3.Pizza.Topping} topping which was {order3.Pizza.Topping.Price}kr \n" +
                                      $"plus 40 kr tax/delivery which led me to pay {order3.CalculateTotalPrice()} kr\n\n");
                    Console.WriteLine("Press any key to go back to the menu");
                    Console.ReadLine();
                    return true;

                case "4":
                    //3.As the owner I want to know the address, contact info of the customer
                    //and the full description of the order, so I can do the delivery correctly.
                    Console.Clear();
                    Console.WriteLine($"The customer {order1.Customer} with the orderID of : {order1.OrderId}, ordered a {order1.Pizza}" +
                                      $"\n with the {order1.Pizza.Topping} topping, and lives in {order1.Customer.Address} " +
                                      $"with the contact of {order1.Customer.Phone} and {order1.Customer.Email}\n\n");

                    Console.WriteLine($"The customer {order2.Customer} with the orderID of : {order2.OrderId}, ordered a {order2.Pizza}" +
                                      $"\n with the {order2.Pizza.Topping} topping, and lives in {order2.Customer.Address} " +
                                      $"with the contact of {order2.Customer.Phone} and {order2.Customer.Email}\n\n");

                    Console.WriteLine($"The customer {order3.Customer} with the orderID of : {order3.OrderId}, ordered a {order3.Pizza}" +
                                      $"\n with the {order3.Pizza.Topping} topping, and lives in {order3.Customer.Address} " +
                                      $"with the contact of {order3.Customer.Phone} and {order3.Customer.Email}\n\n");
                    Console.WriteLine("Press any key to go back to the menu");
                    Console.ReadLine();
                    return true;

                case "5":
                    //7.As a customer I want to know how much I am paying for toppings
                    Console.Clear();
                    Console.WriteLine($"{order1.Customer} is paying {order1.Pizza.Topping.Price} kr for {order1.Pizza.Topping} topping.\n\n");
                    Console.WriteLine($"{order2.Customer} is paying {order2.Pizza.Topping.Price} kr for {order2.Pizza.Topping} topping.\n\n");
                    Console.WriteLine($"{order3.Customer} is paying {order3.Pizza.Topping.Price} kr for {order3.Pizza.Topping} topping.\n\n");
                    Console.WriteLine("Press any key to go back to the menu");
                    Console.ReadLine();
                    return true;

                case "6":
                    return false;

                default:
                    Console.WriteLine($"Wrong Option, Please Try Again");
                    Console.ReadLine();
                    return true;
            }
        }
    }
}
