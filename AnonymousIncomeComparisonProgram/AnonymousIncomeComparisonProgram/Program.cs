using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
                
            Console.WriteLine("Person 1");
                Console.WriteLine("Hourly rate?");
                    string person1hr = Console.ReadLine();
                    decimal p1HourRate = Convert.ToDecimal(person1hr);
                Console.WriteLine("Hours Worked per week?");
                    string person1Hrworked = Console.ReadLine();
                    decimal p1HourWorked = Convert.ToDecimal(person1Hrworked);
                        decimal salary1 = p1HourRate * p1HourWorked * 52;

                Console.WriteLine("Person 2");
                Console.WriteLine("Hourly rate?");
                    string person2hr = Console.ReadLine();
                    decimal p2HourRate = Convert.ToDecimal(person2hr);
                Console.WriteLine("Hours Worked per week?");
                    string person2Hrworked = Console.ReadLine();
                    decimal p2HourWorked = Convert.ToDecimal(person2Hrworked);
                        decimal salary2 = p2HourRate * p2HourWorked * 52;
                
            Console.WriteLine("Annual salary of Person 1:");
                Console.WriteLine(salary1);
            Console.WriteLine("Annual salary of Person 2:");
                Console.WriteLine(salary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
                bool greater = salary1 > salary2;
                Console.WriteLine(greater);    
                Console.ReadLine();
        }
    }
}
