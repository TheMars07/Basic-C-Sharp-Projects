using System;

namespace MathAndComparisonOperators
{
    internal class Program
    {
        static void Main()
        {
            //Prints program's name
            Console.WriteLine("Anonymous Income Comparison Program");

            //Prints questions related to person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate?");
            string rate1 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string worked1 = Console.ReadLine();

            //Prints questions related to person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            string rate2 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string worked2 = Console.ReadLine();

            //Calculates and prints the annual salary of each person
            Console.WriteLine("Annual salary of Person 1");
            int salary1 = Convert.ToInt32(rate1) * Convert.ToInt32(worked1) * 52;
            Console.WriteLine(salary1);
            Console.WriteLine("Annual salary of Person 2");
            int salary2 = Convert.ToInt32(rate2) * Convert.ToInt32(worked2) * 52;
            Console.WriteLine(salary2);

            //Determines if person 1 makes more money than person 2 by printing true or false
            Console.WriteLine("Person 1 makes more money than Person 2");
            bool whoMakesMore = salary1 > salary2;
            Console.WriteLine(whoMakesMore);

            //Avoids console to close without input
            Console.Read();
        }
    }
}