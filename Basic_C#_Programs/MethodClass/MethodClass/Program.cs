using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the Math class
            Math math = new Math();

            //Call the method in the class, passing in two numbers
            math.MathOperation(3, 12);

            //Call the method in the class, specifying the parameters by name
            math.MathOperation(numb1: 7, numb2: 56);

            Console.ReadLine();
        }
    }
}
