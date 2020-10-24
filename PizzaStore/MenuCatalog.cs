using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PizzaStore
{
    public class MenuCatalog
    {
        private Dictionary<int, Pizza> _pizzas;

        public MenuCatalog()
        {
            _pizzas = new Dictionary<int, Pizza>();
        }

        public void RemovePizza(int userInput)
        {
            if (_pizzas.ContainsKey(userInput))
            {
                Console.WriteLine($"The pizza with the ID: {userInput} called {_pizzas[userInput].Name} has been removed successfully");
                _pizzas.Remove(userInput);
            }
            else
            {
                Console.WriteLine($"The entered ID doesn't seem to exist, please try again");
            }
        }
        public void AddPizza(int key, Pizza pizza)
        {
            if (_pizzas.ContainsKey(key))
            {
                Console.WriteLine($"The ID: {key} for the {pizza.Name} already exists, please try again");
            }
            else if (_pizzas.ContainsValue(pizza))

            {
                Console.WriteLine($"The Pizza: {pizza} with the ID: {key} already exists, please try again");
            }
            else
            {
                _pizzas.Add(key, pizza);
                Console.WriteLine($"Pizza Added Successfully");
            }
        }

        public void SearchPizza()
        {

            Console.Write("Please write a number ID or a Pizza Name to find the desired pizza:\n");
            string input = Console.ReadLine();
            if (input != "")
            {

                char firstChar = input[0];
                bool isNumber = Char.IsDigit(firstChar);
                bool foundId = false;
                bool foundName = false;

                if (!isNumber)
                {
                    foreach (Pizza p in _pizzas.Values)
                    {
                        _ = p.Name.ToLower() == input.ToLower() ? foundName = true : foundName = false;

                        if (foundName)
                        {

                            Console.Clear();
                            Console.WriteLine($"Data for the pizza -> {input}\n");
                            Console.WriteLine($"Name: {p.Name}");
                            Console.WriteLine($"Price:{p.Price}");
                            Console.WriteLine($"Size: {p.Size}");
                            p.ListPizzaIngredients();
                            break; //break so it doesn't repeat the output
                            //Spaghetti, how to display ingredients in a better way ask mohammed.
                        }
                    }

                    if (!foundName)
                    {
                        Console.WriteLine("Name not found, please check if you wrote the Name correctly");
                    }
                }
                else
                {
                    Console.WriteLine("");
                    int numericInput = Int32.Parse(input);
                    foreach (int key in _pizzas.Keys)
                    {
                        _ = key == numericInput ? foundId = true : foundId = false;

                        if (foundId)
                        {
                            Console.Clear();
                            Console.WriteLine($"Data for the pizza -> {input}\n");
                            Console.WriteLine($"Name: {_pizzas[key].Name}");
                            Console.WriteLine($"Price:{_pizzas[key].Price}");
                            Console.WriteLine($"Size: {_pizzas[key].Size}");
                            _pizzas[key].ListPizzaIngredients();
                            break; //break so it doesn't repeat the output
                            //Spaghetti, how to display ingredients in a better way ask mohammed.
                        }
                    }

                    if (!foundId)
                    {
                        Console.WriteLine("ID not found, please check if you wrote the ID correctly");
                    }

                }
            }//if empty
            else
            {
                Console.WriteLine("Please write something");
            }

        }//End of the Search Method

        public void PrintPizzas()
        {
            Console.Write("****************************\n");
            Console.Write("**********Pizza List********\n");
            Console.Write("****************************\n");
            foreach (var item in _pizzas)
            {
                Console.WriteLine($"\nID: {item.Key} | Name: {item.Value.Name} | Price: {item.Value.Price} | Size: {item.Value.Size}");
                item.Value.ListPizzaIngredients();
            }
        }

        public void UpdatePizza()
        {
            Console.Write("Please write the ID of the pizza you wish to update\n");
            string id = Console.ReadLine();
            if (id == "")
            {
                Console.Clear();
                Console.WriteLine("Please write something next time");
            }
            else
            {
                char firstChar = id[0];
                bool isNumber = Char.IsDigit(firstChar);
                if (isNumber)
                {
                    int numericId = Int32.Parse(id);
                    // { _pizzas[key].Name}
                    Console.Write("Please write a new Name to update the selected pizza\n");
                    string name = Console.ReadLine();
                    Console.Write("Please write a new Size (Small, Medium or Big) to update the selected pizza\n");
                    string size = Console.ReadLine();
                    Console.Write("Please write a new Price (format xx.xx e.g : 79.99) to update the selected pizza\n");
                    string stringPrice = Console.ReadLine();
                    double price = Convert.ToDouble(stringPrice);

                    _pizzas[numericId].Name = name;
                    _pizzas[numericId].Size = size;
                    _pizzas[numericId].Price = price;
                    Console.WriteLine(
                        "Pizza updated successfully, please list them through the menu to see the changes ");
                }
                else
                {
                    Console.WriteLine("PLEASE WRITE A NUMBER!!!!!!");
                }
            }

        }

    }
}
