using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class CustomerCatalog
    {
        private Dictionary<int, Customer> _customers;


        public CustomerCatalog()
        {
            _customers = new Dictionary<int, Customer>();
        }

        public void RemoveCustomer(int userInput)
        {
            if (_customers.ContainsKey(userInput))
            {
                Console.WriteLine($"The Customer with the ID: {userInput} called {_customers[userInput].Name} has been removed successfully");
                _customers.Remove(userInput);
            }
            else
            {
                Console.WriteLine($"The entered CustomerID doesn't seem to exist, please try again");
            }
        }
        public void AddCustomer(int key, Customer customer)
        {
            if (_customers.ContainsKey(key))
            {
                Console.WriteLine($"The ID: {key} for the {customer.Name} already exists, please try again");
            }
            else if (_customers.ContainsValue(customer))

            {
                Console.WriteLine($"The Customer: {customer} with the ID: {key} already exists, please try again");
            }
            else
            {
                _customers.Add(key, customer);
                Console.WriteLine($"Customer Added Successfully");
            }
        }
        public void SearchCustomer()
        {

            Console.Write("Please write a CustomerID or a Customer Name to find the desired Customer:\n");
            string input = Console.ReadLine();
            if (input != "")
            {

                char firstChar = input[0];
                bool isNumber = Char.IsDigit(firstChar);
                bool foundId = false;
                bool foundName = false;

                if (!isNumber)
                {
                    foreach (Customer c in _customers.Values)
                    {
                        _ = c.Name == input ? foundName = true : foundName = false;

                        if (foundName)
                        {

                            Console.Clear();
                            Console.WriteLine($"Data for the Customer -> {input}\n");
                            Console.WriteLine($"Name: {c.Name}");
                            Console.WriteLine($"Address:{c.Address}");
                            Console.WriteLine($"Phone: {c.Phone}");
                            Console.WriteLine($"Email: {c.Email}");
                            break; //break so it doesn't repeat the output
                            
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
                    foreach (int key in _customers.Keys)
                    {
                        _ = key == numericInput ? foundId = true : foundId = false;

                        if (foundId)
                        {
                            Console.Clear();
                            Console.WriteLine($"Data for the Customer -> {_customers[numericInput].Name}\n");
                            Console.WriteLine($"Name: {_customers[key].Name}");
                            Console.WriteLine($"Price:{_customers[key].Address}");
                            Console.WriteLine($"Size: {_customers[key].Phone}");
                            Console.WriteLine($"Size: {_customers[key].Email}");
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
        public void PrintCustomers()
        {
            Console.Write("****************************\n");
            Console.Write("********CustomerList********\n");
            Console.Write("****************************\n");
            foreach (var item in _customers)
            {
                Console.WriteLine($"\nID: {item.Key} | Name: {item.Value.Name} | Address: {item.Value.Address} | Phone: {item.Value.Phone} | Email: {item.Value.Email} ");
            }
        }
        public void UpdateCustomer()
        {
            Console.Write("Please write the ID of the Customer you wish to update\n");
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
                    
                    Console.Write($"Please write a new Name to update the selected Customer (Current Name: {_customers[numericId].Name}\n");
                    string name = Console.ReadLine();
                    Console.Write($"Please write a new Address to update the selected Customer (Current Address: {_customers[numericId].Address}\n");
                    string address = Console.ReadLine();
                    Console.Write($"Please write a new PhoneNumber to update the selected Customer (Current Phone: {_customers[numericId].Phone}\n");
                    string phone = Console.ReadLine();
                    Console.Write($"Please write a new Email to update the selected Customer (Current Name: {_customers[numericId].Email}\n");
                    string email = Console.ReadLine();

                    _customers[numericId].Name = name;
                    _customers[numericId].Address = address;
                    _customers[numericId].Phone = phone;
                    _customers[numericId].Email = email;
                    Console.WriteLine(
                        "Customer updated successfully, please list them through the menu to see the changes ");
                }
                else
                {
                    Console.WriteLine("PLEASE WRITE A NUMBER!!!!!!");
                }
            }

        }
    }
}
