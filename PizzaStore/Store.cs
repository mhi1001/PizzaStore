using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class Store
    {       
            //Declared here so it can be used by the menu method(Probably not the best practice, but i dont have time to redo it)

           MenuCatalog catalog = new MenuCatalog();
           CustomerCatalog customerCatalog = new CustomerCatalog();
           Ingredients ingredient4 = new Ingredients();
           Ingredients ingredient5 = new Ingredients();
           Pizza pizza4 = new Pizza();
           Pizza pizza5 = new Pizza();
           Order order1 = new Order(21, DateTime.Now);
           Order order2 = new Order(54, DateTime.Now);
           Order order3 = new Order(91, DateTime.Now);
           Customer customer1 = new Customer();
           Customer customer2 = new Customer();
           Customer customer3 = new Customer();
        public void Start()
        {
           //Object Creation
            Ingredients ingredient1 = new Ingredients(); ingredient1.Name = "Pepperoni"; ingredient1.Price = 8.5;
            Ingredients ingredient2 = new Ingredients(); ingredient2.Name = "Ham"; ingredient2.Price = 10.5;
            Ingredients ingredient3 = new Ingredients(); ingredient3.Name = "PineApple"; ingredient3.Price = 20.5;
             ingredient4.Name = "Mushroom"; ingredient4.Price = 17.99;
             ingredient5.Name = "Pepper"; ingredient5.Price = 29.99;
            
            Pizza pizza1 = new Pizza();
            Pizza pizza2 = new Pizza();
            Pizza pizza3 = new Pizza();


            pizza1.Size = "Medium";
            pizza1.Name = $"MegaCoolPizza";
            pizza1.Price = 10.10;
            pizza1.Id = 21;

            pizza2.Size = "Big";
            pizza2.Name = $"GiantPizza";
            pizza2.Price = 710.79;
            pizza2.Id = 22;

            pizza3.Size = "Small";
            pizza3.Name = $"SmallestPizza";
            pizza3.Price = 5.10;
            pizza3.Id = 23;

            pizza4.Size = "Big";
            pizza4.Name = $"ExoticPizza";
            pizza4.Price = 99.99;
            pizza4.Id = 31;

            pizza5.Size = "Medium";
            pizza5.Name = $"SimplePizza";
            pizza5.Price = 199.99;
            pizza5.Id = 32;

            
            customer1.Name = "John Smith";
            customer1.Email = "john@gmail.com";
            customer1.Phone = "919191919";
            customer1.Address = "Denmarkvej";
            customer1.Id = 1000;

            
            customer2.Name = "Jane Doe";
            customer2.Email = "jane@gmail.com";
            customer2.Phone = "818181818";
            customer2.Address = "Copenhagenvej";
            customer2.Id = 1001;

            
            customer3.Name = "Joseph Mcguire";
            customer3.Email = "Mcguire@gmail.com";
            customer3.Phone = "2727272727";
            customer3.Address = "Swedenvej";
            customer3.Id = 1002;

           
            order1.Customer = customer1;
            order1.AddPizzaToOrder(pizza1.Id,pizza1);

            Order order2 = new Order(54, DateTime.Now);
            order2.Customer = customer2;
            order2.AddPizzaToOrder(pizza2.Id, pizza2);

            Order order3 = new Order(91, DateTime.Now);
            order3.Customer = customer3;
            order3.AddPizzaToOrder(pizza3.Id, pizza3);

            //Add some default things, so its not empty
            pizza1.AddIngredients(ingredient1);
            pizza1.AddIngredients(ingredient2);

            pizza2.AddIngredients(ingredient2);

            pizza3.AddIngredients(ingredient5);

            pizza4.AddIngredients(ingredient4);
            pizza4.AddIngredients(ingredient3);
            pizza4.AddIngredients(ingredient5);

            pizza5.AddIngredients(ingredient1);
            //Existing Pizzas
            catalog.AddPizza(pizza1.Id, pizza1);
            catalog.AddPizza(pizza2.Id, pizza2);
            catalog.AddPizza(pizza3.Id, pizza3);
            //Existing Customers
            customerCatalog.AddCustomer(customer1.Id, customer1);
            customerCatalog.AddCustomer(customer2.Id, customer2);
            
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }


        private bool MainMenu()
        {
            
            Console.Clear();
            Console.Write("------------------------------------------------\n");
            Console.Write("Welcome to BigMama's pizzeria management program\n");
            Console.Write("------------------------------------------------\n");
            Console.Write("\n");
            Console.Write("****************************\n");
            Console.Write("Pizza Menu Administration\n");
            Console.Write("****************************\n");
            Console.Write("1 -> List existing pizzas\n" +
                          "2 -> Delete a pizza\n" +
                          "3 -> Create/Add pizza\n" +
                          "4 -> Update a pizza\n" +
                          "5 -> Search a pizza\n");
            Console.Write("****************************\n");
            Console.Write("Customer Administration\n");
            Console.Write("****************************\n");
            Console.Write("6 -> List existing Customers\n" +
                          "7 -> Delete a Customer\n" +
                          "8 -> Create/Add Customer\n" +
                          "9 -> Update a Customer\n" +
                          "10-> Search a Customer\n");
            Console.Write("\n\n\nQ -> Enter Q to Exit Program\n\n");
            Console.Write("\nInput your choice :");


            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    catalog.PrintPizzas();
                    Console.WriteLine("\n\nPress any key to go back to the menu");
                    Console.ReadLine();
                    return true;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Please write the ID of the pizza you want to remove");
                    int intTemp = Convert.ToInt32(Console.ReadLine());
                    catalog.RemovePizza(intTemp);
                    Console.WriteLine("\nPress any key to go back to the menu");
                    Console.ReadLine();
                    return true;

                case "3":
                    Console.Clear();
                    catalog.AddPizza(pizza4.Id, pizza4);
                    catalog.AddPizza(pizza5.Id, pizza5);
                    Console.WriteLine("Press any key to go back to the menu");
                    Console.ReadLine();
                    return true;

                case "4":
                    Console.Clear();
                    catalog.UpdatePizza();
                    Console.WriteLine("Press any key to go back to the menu");
                    Console.ReadLine();
                    return true;

                case "5":
                    Console.Clear();
                    catalog.SearchPizza();

                    Console.WriteLine("Press any key to go back to the menu");
                    Console.ReadLine();
                    return true;

                case "6":
                    Console.Clear();
                    customerCatalog.PrintCustomers();
                    Console.ReadLine();
                    return true;

                case "7":
                    Console.Clear();
                    Console.WriteLine("Please write the ID of the Customer you want to remove");
                    int intTemp2 = Convert.ToInt32(Console.ReadLine());
                    customerCatalog.RemoveCustomer(intTemp2);
                    Console.WriteLine("\nPress any key to go back to the menu");
                    Console.ReadLine();
                    return true;

                case "8":
                    Console.Clear();
                    customerCatalog.AddCustomer(customer3.Id, customer3);
                    Console.WriteLine("Press any key to go back to the menu");
                    Console.ReadLine();
                    return true;

                case "9":
                    Console.Clear();
                    customerCatalog.UpdateCustomer();
                    Console.WriteLine("Press any key to go back to the menu");
                    Console.ReadLine();
                    return true;

                case "10":
                    Console.Clear();
                    customerCatalog.SearchCustomer();
                    Console.WriteLine("Press any key to go back to the menu");
                    Console.ReadLine();
                    return true;


                case "q":
                    return false;

                default:
                    Console.WriteLine($"Wrong Option, Please Try Again");
                    Console.ReadLine();
                    return true;
            }
        }
    }
}
