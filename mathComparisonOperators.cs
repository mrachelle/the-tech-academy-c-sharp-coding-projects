using System;

namespace mathComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate");
            string rateP1 = Console.ReadLine();
            decimal p1Rate;
            decimal.TryParse(rateP1, out p1Rate);
            Console.WriteLine("Hours worked per week");
            string hoursP1 = Console.ReadLine();
            decimal p1Hours;
            decimal.TryParse(hoursP1, out p1Hours);
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate");
            string rateP2 = Console.ReadLine();
            decimal p2Rate;
            decimal.TryParse(rateP2, out p2Rate);
            Console.WriteLine("Hours worked per week");
            string hoursP2 = Console.ReadLine();
            decimal p2Hours;
            decimal.TryParse(hoursP1, out p2Hours);

            decimal p1Salary = (p1Rate * p1Hours * 52); //rate x hours p/week x weeks p/year
            decimal p2Salary = (p2Rate * p2Hours * 52); //rate x hours p/week x weeks p/year


            Console.WriteLine("Annual Salary of Person 1: " + p1Salary);
            Console.WriteLine("Annual Salary of Person 2: " + p2Salary);
            Console.WriteLine("Does person 1 make more money than person 2?");
            if (p1Salary > p2Salary)
            { Console.WriteLine("TRUE"); }
            else
            { Console.WriteLine("FALSE"); }

                Console.ReadKey();
        }
    }
}
