using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.Start();

            Console.WriteLine();
            Console.WriteLine("Thank you for using my program");

            Console.ReadKey();
        }
    }
}
