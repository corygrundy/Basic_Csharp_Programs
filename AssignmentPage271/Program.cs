using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPage271
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            List<Employee> employees = new List<Employee>
            {
                new Employee { firstName = "Sample", lastName = "Student", Id = 001 },
                new Employee { firstName = "Jack", lastName = "Grundy", Id = 002 },
                new Employee { firstName = "Cory", lastName = "Grundy", Id = 003 },
                new Employee { firstName = "Caleb", lastName = "Grundy", Id = 004 },
                new Employee { firstName = "Chase", lastName = "Sabre", Id = 005 },
                new Employee { firstName = "Joe", lastName = "Laphardy", Id = 006 },
                new Employee { firstName = "Valdus", lastName = "White", Id = 007 },
                new Employee { firstName = "Logan", lastName = "Vegas", Id = 008 },
                new Employee { firstName = "Joe", lastName = "Johnson", Id = 009 },
                new Employee { firstName = "Patrick", lastName = "Roy", Id = 010 }
            };

            List<int> numbers = new List<int>()
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10
            };
            
            //Part 2
            //List<Employee> Joes = new List<Employee>();
            //foreach (Employee emp in employees )
            //{
            //    if ( emp.firstName == "Joe")
            //    {
            //        Joes.Add(new Employee { firstName = emp.firstName, lastName = emp.lastName, Id = emp.Id });
            //    }
            //}
            //foreach (Employee joe in Joes)
            //{
            //    Console.WriteLine(joe.firstName, joe.lastName, joe.Id);
            //}
            
            //Part 3
            List<Employee> Joes = employees.Where(x => x.firstName == "Joe").ToList();
            foreach (Employee employee in Joes)
            {
                Console.WriteLine(employee.firstName);
            }

            //Part 4
            List<Employee> newList = employees.Where(x => x.Id >= 5).ToList();
            foreach (Employee employee in newList)
            {
                Console.WriteLine(employee.Id);
            }
            Console.ReadLine();
        }
    }
}
