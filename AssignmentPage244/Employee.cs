using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPage244
{
    //begin part 3
    public class Employee : Person, IQuittable
    {
        public int Id { get; set;}
        //Begin part 4
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        //Begin part 2 of page 247
        public void Quit(Employee employee)
        {
            Console.WriteLine("Employee " + firstName + " " + lastName + "has quit.");
        }

        //Begin part 1 of page 252

        public static Boolean operator ==(Employee emp1, Employee emp2)
        {
            bool comp1 = emp1.Id == emp2.Id;
            return comp1;  
        }
        public static Boolean operator !=(Employee emp1, Employee emp2)
        {
            bool comp2 = emp1.Id != emp2.Id;
            return comp2;
        }
    }
}
