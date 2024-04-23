using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Polymorphism to create an object of type IQuittable
            IQuittable quittableEmployee = new Employee("Mary", "Smith");
            
            //Call the Quit() method of the IQuittable object
            quittableEmployee.Quit();
            
            Console.ReadLine();
        }
    }
}
