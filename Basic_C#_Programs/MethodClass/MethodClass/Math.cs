using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    internal class Math
    {
        //Create a void method that takes two integers as parameters
        public void MathOperation(int numb1, int numb2) 
        {
            //Perform a math operation on the first integer
            int result = numb1 * 2;
            Console.WriteLine("Result of the operation: " + result);

            //Display the second integer
            Console.WriteLine($"Second number: {numb2}");
        }
    }
}
