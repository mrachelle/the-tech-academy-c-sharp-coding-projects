using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number: ");
            string num1 = Console.ReadLine();
            long number1 = Convert.ToInt64(num1);  //use long for longer numeric values both neg and pos 
            long product = number1 * 50; 
            Console.WriteLine("Your number x 50 is " + product );

            Console.WriteLine("Pick new number: ");
            string num2 = Console.ReadLine();
            long number2 = Convert.ToInt32(num2);
            long total = number2 + 25;
            Console.WriteLine("your number plus 25 is " + total);

            Console.WriteLine("Pick another number: ");
            string num3 = Console.ReadLine();
            long number3 = Convert.ToInt64(num3); 
            decimal number4 = 12.5m;                     //this is a decimal value so you need to 
            decimal quotient = number3 / number4;       //use decimal quotient 
            Console.WriteLine("Your number divided by 12.5 is " + quotient);

            Console.WriteLine("Pick one more number: ");
            int num5 = int.Parse(Console.ReadLine());
            if (num5 < 50)                               //condition that needs to be met 
                {
                    Console.WriteLine("Your number is less than 50!");
                }
            else 
                {
                    Console.WriteLine("Your number is greater than 50!");
            }


            Console.WriteLine("Pick one last number for this: ");
            string num6 = Console.ReadLine();
            long number6 = Convert.ToInt32(num6);
            long remainder = number6 % 7;
            Console.WriteLine("When your number divided by 7, it has a remainder of " + remainder);
            Console.ReadKey();
        }
    }
}
