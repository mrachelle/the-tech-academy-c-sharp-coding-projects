using System;


namespace Daily_Report_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            string whatPage = Console.ReadLine();
            int pageNumber = Convert.ToInt32(whatPage);
            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'. ");
            bool needHelp = true;
            Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studiedFor = Console.ReadLine();
            int studyHours = Convert.ToInt32(studiedFor);
            Console.Write("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadKey(); 
           
        }
        }
}
