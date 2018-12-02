using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the weight of the package in pounds:");
            int packageWeight = Console.Read();
            if (packageWeight >= 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    Console.ReadKey();
                }
            else
            {
                Console.WriteLine("Please enter package width in inches:");
                int packageWidth = Console.Read();
                Console.WriteLine("Please enter package length in inches:");
                int packageLength = Console.Read();
                int packageDimensions = (packageWidth + packageLength);
                    if (packageDimensions > 50)
                    {
                        Console.WriteLine("Package too big to be shipped via Package Express.");
                        Console.ReadKey();
                    }
                decimal packageQuote = ((packageDimensions * packageWeight) / 100);
                Console.WriteLine(packageQuote);
            }
        Console.ReadKey();
        }
    }
}
