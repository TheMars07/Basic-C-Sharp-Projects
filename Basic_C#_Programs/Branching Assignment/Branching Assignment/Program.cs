using System;


namespace Branching_Assignment
{
    internal class Program
    {
        static void Main()
        {
            //Prints a welcoming message into console
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //Asks the user the package weight and stores the value as a double
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());
            
            //Uses a if statement to determine how heavy the package is and displays a message accordingly 
            if (weight > 50) {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else {
                Console.WriteLine("Please enter the package width:");
            }

            //Stores the width value as a double
            double width = Convert.ToDouble(Console.ReadLine());
            
            //Asks the user the package height and stores the value as a double
            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());

            //Asks the user the package lenght and stores the value as a double
            Console.WriteLine("Please enter the package length:");
            double lenght = Convert.ToDouble(Console.ReadLine());

            //Uses a if statement to determine what the package dimensions are and displays a message accordingly 
            if (width + height + lenght > 50) {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else {
                //Establishes the shipping quote by using all the stored values
                double quote = (weight * width * height * lenght) / 100;
                //Formats the quote value into a string with 2 decimal digits 
                string quoteFormat = string.Format("{0:N2}", quote);
                //Prints the quote as a dollar amount
                Console.WriteLine("Your estimated total for shipping this package is: $" + quoteFormat);
            }

            //Prints a thank you message into console
            Console.WriteLine("Thank you!");
            //Avoids closing the console before the previous message is dislpayed
            Console.ReadLine();
        }
    }
}
