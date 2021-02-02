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
            Employee<string> Things = new List<string>();
            //Begin part 5     //Added <string> for part 3 on page 255
            Employee<string> emp1 = new Employee<string>();
            emp1.Things = new List<string> { "Sample info.", "Sample", "Student", "001" };
            emp1.firstName = "Sample";
            emp1.lastName = "Student";
            emp1.Id = 001;  //Also part of part 1 on page 252
            //emp1.SayName();
            //IQuittable quittable1 = new Employee();
            //quittable1.Quit(emp1);

            //Part of part 1 on page 252
            Employee<string> emp2 = new Employee<string>();
            emp2.Things = new List<string> { "My Father.", "Jack", "Grundy", "002" };
            emp2.firstName = "Jack";
            emp2.lastName = "Grundy";
            emp2.Id = 002;
            //Console.WriteLine(emp1 == emp2);
            //Console.WriteLine(emp1 != emp2);
            //Console.ReadLine();

            //Begin part 4 from page 255
            Employee<int> emp3 = new Employee<int>();
            emp3.Things = new List<int> { 5, 3, 12, 8, 7 };
            emp3.firstName = "Cory";
            emp3.lastName = "Grundy";
            emp3.Id = 003;

            //Begin part 1
            Employee<string> emp4 = new Employee<string>();
            emp3.Things = new List<string> { "Caleb", "Grundy", "004" };
            emp3.firstName = "Caleb";
            emp3.lastName = "Grundy";
            emp3.Id = 004;
            Employee<string> emp5 = new Employee<string>();
            emp3.Things = new List<string> { "Chase", "Sabre", "005" };
            emp3.firstName = "Chase";
            emp3.lastName = "Sabre";
            emp3.Id = 005;
            Employee<string> emp6 = new Employee<string>();
            emp3.Things = new List<string> { "Joe", "Laphardy", "006" };
            emp3.firstName = "Joe";
            emp3.lastName = "Laphardy";
            emp3.Id = 006;
            Employee<string> emp7 = new Employee<string>();
            emp3.Things = new List<string> { "Valdus", "White", "007" };
            emp3.firstName = "Valdus";
            emp3.lastName = "White";
            emp3.Id = 007;
            Employee<string> emp8 = new Employee<string>();
            emp3.Things = new List<string> { "Logan", "Vegas", "008" };
            emp3.firstName = "Logan";
            emp3.lastName = "Vegas";
            emp3.Id = 008;
            Employee<string> emp9 = new Employee<string>();
            emp3.Things = new List<string> { "Joe", "Johnson", "009" };
            emp3.firstName = "Joe";
            emp3.lastName = "Johnson";
            emp3.Id = 009;
            Employee<string> emp10 = new Employee<string>();
            emp3.Things = new List<string> { "Patrick", "Roy", "010" };
            emp3.firstName = "Patrick";
            emp3.lastName = "Roy";
            emp3.Id = 010;

            //Last part of page 255
            foreach (var element in emp1.Things)
            {
                Console.WriteLine(element);
            }
            foreach (var element in emp2.Things)
            {
                Console.WriteLine(element);
            }
            foreach (var element in emp3.Things)
            {
                Console.WriteLine(element);
            }
            //foreach (string LastName  in Things.lastName)
            //{
            //    Console.WriteLine(lastName);
            //}
        }
    }
}
