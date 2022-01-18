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

            var methods = new Methods();
            var costTotal = methods.Terminal(userInput);

            Console.WriteLine("The total price is: $" + (costTotal));
            Console.ReadLine();
        }
    }
}
