using System;
using System.Collections.Generic;

namespace AssignmentPage244
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            //Begin part 5     //Added <string> for part 3 on page 255
            Employee emp1 = new Employee();
            emp1.firstName = "Sample";
            emp1.lastName = "Student";
            emp1.Id = 001;  //Also part of part 1 on page 252
            employees.Add(new Employee() { firstName = "Sample", lastName = "Student", Id = 001 });
            //emp1.SayName();
            //IQuittable quittable1 = new Employee();
            //quittable1.Quit(emp1);

            //Part of part 1 on page 252
            Employee emp2 = new Employee();
            emp2.firstName = "Jack";
            emp2.lastName = "Grundy";
            emp2.Id = 002;
            employees.Add(new Employee() { firstName = "Jack", lastName = "Grundy", Id = 002 });
            //Console.WriteLine(emp1 == emp2);
            //Console.WriteLine(emp1 != emp2);
            //Console.ReadLine();

            //Begin part 4 from page 255
            Employee emp3 = new Employee();
            emp3.firstName = "Cory";
            emp3.lastName = "Grundy";
            emp3.Id = 003;
            employees.Add(new Employee() { firstName = "Cory", lastName = "Grundy", Id = 003 });

            //Begin part 1
            Employee emp4 = new Employee();
            emp4.firstName = "Caleb";
            emp4.lastName = "Grundy";
            emp4.Id = 004;
            employees.Add(new Employee() { firstName = "Caleb", lastName = "Grundy", Id = 004 });
            employees.Add(emp4.firstName);
            Employee emp5 = new Employee();
            emp5.firstName = "Chase";
            emp5.lastName = "Sabre";
            emp5.Id = 005;
            employees.Add(new Employee() { firstName = "Chase", lastName = "Sabre", Id = 005 });
            employees.Add(emp5.firstName);
            Employee emp6 = new Employee();
            emp6.firstName = "Joe";
            emp6.lastName = "Laphardy";
            emp6.Id = 006;
            employees.Add(new Employee() { firstName = "Joe", lastName = "Laphardy", Id = 006 });
            employees.Add(emp6.firstName);
            Employee emp7 = new Employee();
            emp7.firstName = "Valdus";
            emp7.lastName = "White";
            emp7.Id = 007;
            employees.Add(new Employee() { firstName = "Valdus", lastName = "White", Id = 007 });
            employees.Add(emp7.firstName);
            Employee emp8 = new Employee();
            emp8.firstName = "Logan";
            emp8.lastName = "Vegas";
            emp8.Id = 008;
            employees.Add(new Employee() { firstName = "Logan", lastName = "Vegas", Id = 008 });
            employees.Add(emp8.firstName);
            Employee emp9 = new Employee();
            emp9.firstName = "Joe";
            emp9.lastName = "Johnson";
            emp9.Id = 009;
            employees.Add(new Employee() { firstName = "Joe", lastName = "Johnson", Id = 009 });
            employees.Add(emp9.firstName);
            Employee emp10 = new Employee();
            emp10.firstName = "Patrick";
            emp10.lastName = "Roy";
            emp10.Id = 010;
            employees.Add(new Employee() { firstName = "Patrick", lastName = "Roy", Id = 010 });

            //Begin part 2 of page 271
            List<string> Joes = new List<string>();
            Console.WriteLine(employees[1]);


            for (int i = 0; i < employees.Count; i++)
            {/*(int i = 0; i < employees.Count; i++) I only need this for a for loop right?*/
                string emp = (string)employees[i];
                if (emp == "Joe")
                {
                    Joes.Add(emp);
                }
                Console.WriteLine(Joes);
            }
            Console.ReadLine();
        }
    }
}
