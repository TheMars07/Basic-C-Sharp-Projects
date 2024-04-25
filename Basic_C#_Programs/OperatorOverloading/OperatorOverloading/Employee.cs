using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    //Define Employee class 
    public class Employee
    {
        //Class properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Constructor
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        //Overloaded == operator
        public static bool operator== (Employee emp1, Employee emp2)
        {
            //Returns true if the Id properties are equal, otherwise returns false
            return emp1.Id == emp2.Id;
        }

        //Overloaded != operator
        public static bool operator!= (Employee emp1, Employee emp2)
        { 
            return !(emp1.Id == emp2.Id);
        }
    }
}
