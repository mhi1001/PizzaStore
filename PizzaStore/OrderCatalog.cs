using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class OrderCatalog
    {
        private Dictionary<int, Order> _orders;



        public OrderCatalog()
        {
            _orders = new Dictionary<int, Order>();

        }

        public void RemoveOrder(int userInput)
        {
            if (_orders.ContainsKey(userInput))
            {
                Console.WriteLine($"The order with the ID: {userInput}, created on the {_orders[userInput].Date} was removed");
                _orders.Remove(userInput);
            }
            else
            {
                Console.WriteLine($"The entered OrderID doesn't seem to exist, please try again");
            }
        }
        public void AddOrder(int key, Order order)
        {
            if (_orders.ContainsKey(key))
            {
                Console.WriteLine($"The ID: {key} for the Order already exists, please try again");
            }
            else if (_orders.ContainsValue(order))

            {
                Console.WriteLine($"The Order: {order.OrderId} already exists, please try again");
            }
            else
            {
                _orders.Add(key, order);
                Console.WriteLine($"Order Added Successfully");
            }
        }
        public void SearchOrder()
        {

            Console.Write("Please write a OrderID to find the desired Order:\n");
            string input = Console.ReadLine();
            if (input != "")
            {

                char firstChar = input[0];
                bool isNumber = Char.IsDigit(firstChar);
                bool foundId = false;
                bool foundName = false;

                if (isNumber)
                {
                    Console.WriteLine("");
                    int numericInput = Int32.Parse(input);
                    foreach (int key in _orders.Keys)
                    {
                        _ = key == numericInput ? foundId = true : foundId = false;

                        if (foundId)
                        {
                            Console.Clear();
                            Console.WriteLine($"Data for the Order -> {_orders[numericInput].OrderId}\n");
                            Console.WriteLine($"Date: {_orders[key].Date}");

                            break; //break so it doesn't repeat the output

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
        public void PrintOrders()
        {
            Console.Write("****************************\n");
            Console.Write("**********OrderList*********\n");
            Console.Write("****************************\n");
            foreach (var item in _orders)
            {
                Console.WriteLine($"\nID: {item.Key} | Date: {item.Value.Date}  ");
            }
        }

        public void OrdersTotalPrice()
        {
            foreach(Order i in _orders.Values)
                Console.WriteLine($"The orderID: {i.OrderId}, created at {i.Date} has a total price of { i.CalculateTotalPrice()} kr");
            Console.ReadLine();
        }
    }
}
