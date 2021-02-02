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
            List<string> employees = new List<string>();
            //Begin part 5     //Added <string> for part 3 on page 255
            Employee<string> emp1 = new Employee<string>();
            emp1.Things = new List<string> { "Sample info.", "Sample", "Student", "001" };
            emp1.firstName = "Sample";
            emp1.lastName = "Student";
            emp1.Id = 001;  //Also part of part 1 on page 252
            employees.Add(emp1.firstName);
            //emp1.SayName();
            //IQuittable quittable1 = new Employee();
            //quittable1.Quit(emp1);

            //Part of part 1 on page 252
            Employee<string> emp2 = new Employee<string>();
            emp2.Things = new List<string> { "My Father.", "Jack", "Grundy", "002" };
            emp2.firstName = "Jack";
            emp2.lastName = "Grundy";
            emp2.Id = 002;
            employees.Add(emp2.firstName);
            //Console.WriteLine(emp1 == emp2);
            //Console.WriteLine(emp1 != emp2);
            //Console.ReadLine();

            //Begin part 4 from page 255
            Employee<int> emp3 = new Employee<int>();
            emp3.Things = new List<int> { 5, 3, 12, 8, 7 };
            emp3.firstName = "Cory";
            emp3.lastName = "Grundy";
            emp3.Id = 003;
            employees.Add(emp3.firstName);

            //Begin part 1
            Employee<string> emp4 = new Employee<string>();
            emp4.Things = new List<string> { "Caleb", "Grundy", "004" };
            emp4.firstName = "Caleb";
            emp4.lastName = "Grundy";
            emp4.Id = 004;
            employees.Add(emp4.firstName);
            Employee<string> emp5 = new Employee<string>();
            emp5.Things = new List<string> { "Chase", "Sabre", "005" };
            emp5.firstName = "Chase";
            emp5.lastName = "Sabre";
            emp5.Id = 005;
            employees.Add(emp5.firstName);
            Employee<string> emp6 = new Employee<string>();
            emp6.Things = new List<string> { "Joe", "Laphardy", "006" };
            emp6.firstName = "Joe";
            emp6.lastName = "Laphardy";
            emp6.Id = 006;
            employees.Add(emp6.firstName);
            Employee<string> emp7 = new Employee<string>();
            emp7.Things = new List<string> { "Valdus", "White", "007" };
            emp7.firstName = "Valdus";
            emp7.lastName = "White";
            emp7.Id = 007;
            employees.Add(emp7.firstName);
            Employee<string> emp8 = new Employee<string>();
            emp8.Things = new List<string> { "Logan", "Vegas", "008" };
            emp8.firstName = "Logan";
            emp8.lastName = "Vegas";
            emp8.Id = 008;
            employees.Add(emp8.firstName);
            Employee<string> emp9 = new Employee<string>();
            emp9.Things = new List<string> { "Joe", "Johnson", "009" };
            emp9.firstName = "Joe";
            emp9.lastName = "Johnson";
            emp9.Id = 009;
            employees.Add(emp9.firstName);
            Employee<string> emp10 = new Employee<string>();
            emp10.Things = new List<string> { "Patrick", "Roy", "010" };
            emp10.firstName = "Patrick";
            emp10.lastName = "Roy";
            emp10.Id = 010;
            employees.Add(emp10.firstName);

            //Begin part 2 of page 271
            List<string> Joes = new List<string>();
            Console.WriteLine(employees[1]);

            
            foreach (string employee in employees)
            {/*(int i = 0; i < employees.Count; i++) I only need this for a for loop right?*/
                employee == "Joe";
                Joes.Add(employee);
                Console.ReadLine();
                
            }

            //foreach (var firstname in employees)
            //{


            //    Joes.Add(Things.firstName);
            //    Console.WriteLine(Joes);

            //}

            //List<string> empList = new List<string>() {  } 

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
