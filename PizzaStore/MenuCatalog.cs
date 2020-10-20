using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class MenuCatalog
    {
        private Dictionary<int, Pizza> _pizzas = new Dictionary<int, Pizza>();

        public void AddPizza(int key, Pizza pizza)
        {
            if (_pizzas.ContainsKey(key))
            {
                Console.WriteLine($"The ID : {key} for the {pizza.Name} already exists, please try again");
            }
            else if (_pizzas.ContainsValue(pizza))

            {
                Console.WriteLine($"The Pizza : {pizza} with the ID :{key} already exists, please try again");
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

            char firstChar = input[0];
            bool isNumber = Char.IsDigit(firstChar);
            int numericInput = Int32.Parse(input);
            if (!isNumber)
            {
                foreach (Pizza p in _pizzas.Values)
                {
                    if (input == p.Name)
                    {
                        Console.WriteLine($"The searched pizza {input} is called {p.Name}, costs {p.Price},\n" +
                                          $"is size {p.Size} and" +
                                          $" has the following ingredients : "); p.ListPizzaIngredients(); //Spaguetti, how to display ingredients in a better way ask mohammed.
                    }
                    else
                    {
                        Console.WriteLine("Name not found, please check if you're writing the name correctly");
                    }
                }
            }
            else
            {
                foreach (int k in _pizzas.Keys)
                {
                    if (numericInput == k)
                    {
                        Console.WriteLine($"The searched pizza ID {numericInput} found a pizza called {_pizzas[k].Name}, " +
                                          $"costs {_pizzas[k].Price} and" +
                                          $" has the following ingredients : "); _pizzas[k].ListPizzaIngredients(); //Spaguetti, how to display ingredients in a better way ask mohammed.
                    }
                    else
                    {
                        Console.WriteLine("ID not found, please check if you wrote the ID correctly");
                    }
                }

            }

        }//End of the Search Method


    }
}
