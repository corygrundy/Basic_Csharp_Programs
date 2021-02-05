using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPage244
{
    //Begin part 3      //Begin part 1 from page 255  (the <T>).
    public class Employee : Person, IQuittable
    {
        //Begin part 2 from page 255
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
        
        //Going to test this code below.    Made these lines to fix an issue that it couldn't implicitly turn a string into a string, so I bypassed it by making them into a shared string type.
        public static implicit operator Employee(string v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Employee(List<string> v)
        {
            return null;       //had no idea what to put here but this works.
        }

        public static explicit operator string(Employee v)
        {
            return null;
        }
    }
}
