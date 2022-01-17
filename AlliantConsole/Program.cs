using System;
using System.Collections.Generic;
using System.Linq;
using AlliantLibrary;

namespace AlliantConsole
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter items.");
            string InputRaw = Console.ReadLine();
            string userInput = InputRaw.ToUpper();
            
            Methods.Scan(userInput);
            Methods.Total(Methods.productList);

            Console.WriteLine("The total price is: $" + (Methods.sumTotal));
            Console.ReadLine();
        }
    }
}
