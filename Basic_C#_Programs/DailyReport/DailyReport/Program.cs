using System;

namespace DailyReport
{
    internal class Program
    {
        static void Main()
        {
            //Prints academy's name and daily report
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            //Asks the student's name
            Console.WriteLine("What is your name?");
            //Reads student's name as a string
            string name = Console.ReadLine();
            //Asks the student's course
            Console.WriteLine("What course are you on?");
            //Reads student's course as a string
            string course = Console.ReadLine();
            //Asks the current page the student is on
            Console.WriteLine("What page number?");
            //Reads student's page number as a integer
            int pageNumb = Convert.ToInt32(Console.ReadLine());
            //Asks if the student needs help
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            //Reads if the student needs help as true or false
            bool needHelp = bool.Parse(Console.ReadLine());
            //Asks for the student's experiences
            Console.WriteLine("Were there any positive experiences you’d like to share ? Please give specifics.");
            //Reads student's experiences as a string
            string experiences = Console.ReadLine();
            //Asks for the student's feedback
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            //Reads student's feedback as a string
            string feedback = Console.ReadLine();
            //Ask how many hours the student studied
            Console.WriteLine("How many hours did you study today?");
            //Reads how many hours the student studied as a string and then converts it to integer
            string hoursStudied = Console.ReadLine();
            int hoursNumb = Convert.ToInt32(hoursStudied);
            //Prints academy's feedback
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            //Avoids console to close without the student answers
            Console.ReadLine();
        }
    }
}
