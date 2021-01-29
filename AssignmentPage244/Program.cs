using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPage244
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Begin part 5     //Added <string> for part 3 on page 255
            List<string> employees = new List<string>();
            Employee<string> emp1 = new Employee<string>();
            emp1.firstName = "Sample";
            emp1.lastName = "Student";
            emp1.Id = 001;  //Also part of part 1 on page 252
            emp1.Things = "Sample info.";
            //emp1.SayName();
            //IQuittable quittable1 = new Employee();
            //quittable1.Quit(emp1);

            //Part of part 1 on page 252
            Employee<string> emp2 = new Employee<string>();
            emp2.firstName = "Jack";
            emp2.lastName = "Grundy";
            emp2.Id = 002;
            emp2.Things = "My Father.";
            //Console.WriteLine(emp1 == emp2);
            //Console.WriteLine(emp1 != emp2);
            //Console.ReadLine();

            //Begin part 4 from page 255
            Employee<int> emp3 = new Employee<int>();
            emp3.firstName = "Cory";
            emp3.lastName = "Grundy";
            emp3.Id = 003;
            emp3.Things = "My info.";

            foreach ( in )
            {
                Console.WriteLine();
            }
        }
    }
}
