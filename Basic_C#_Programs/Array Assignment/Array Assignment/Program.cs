using System;
using System.Collections.Generic;

namespace Array_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an array of strings
            string[] fruitArray = { "apple", "banana", "orange", "grapes", "watermelon" };

            //Ask the user to select an index
            Console.WriteLine("Enter the index of the string you want to display between 0 and 4:");
            int indexfruit = Convert.ToInt32(Console.ReadLine());

            //Check if the index is within the valid range
            if (indexfruit >=0 && indexfruit < fruitArray.Length)
            {
                //Display the string of the selected index
                Console.WriteLine("The string at index " + indexfruit + " is: " + fruitArray[indexfruit]);
            }
            else
            {
                Console.WriteLine("Invalid index. Please enter a valid index within the range.");
            }

            //Create an array of integers
            int[] numberArray = { 10, 22, 33, 44, 56, 63, 77, 81, 99 };

            //Ask the user to select an index
            Console.WriteLine("Enter the index of the string you want to display between 0 and 8:");
            int indexnumber = Convert.ToInt32(Console.ReadLine());

            //Check if the index is within the valid range
            if (indexnumber >= 0 && indexnumber < numberArray.Length)
            {
                //Display the string of the selected index
                Console.WriteLine("The string at index " + indexnumber + " is: " + numberArray[indexnumber]);
            }
            else
            {
                Console.WriteLine("Invalid index. Please enter a valid index within the range.");
            }

            //Create a list of strings
            List<string> carParts = new List<string>() { "door", "wheel", "seat", "engine", "gearbox", "mirrors" };

            //Ask the user to select an index
            Console.WriteLine("Enter the index of the string you want to display between 0 and 5:");
            int carindex = Convert.ToInt32(Console.ReadLine());

            //Check if the index is within the valid range
            if (carindex >= 0 && carindex < carParts.Count)
            {
                //Display the string of the selected index
                Console.WriteLine("The string at index " + carindex + " is: " + carParts[carindex]);
            }
            else
            {
                Console.WriteLine("Invalid index. Please enter a valid index within the range.");
            }
            //Keep the console window open
            Console.ReadLine();
        }
    }
}
