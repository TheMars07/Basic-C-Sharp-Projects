using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //Define the Employee class and inherit IQuittable interface
    public class Employee : IQuittable
    {
        //Properties of the Employee class
        public string firstName {  get; set; }
        public string lastName { get; set; }
        
        //Constructor
        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //Implement the Quit() method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + " is quitting their job.");
        }
    }
}
