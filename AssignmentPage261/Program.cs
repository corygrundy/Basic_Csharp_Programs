using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPage261
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Monday=0,
            Tuesday=1,
            Wednesday=2,
            Thursday=3,
            Friday=4,
            Saturday=5,
            Sunday=6
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week.");
            string ui1 = Console.ReadLine();
            try
            {
                DaysOfTheWeek dayValue = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), ui1, true);
                if (Enum.IsDefined(typeof(DaysOfTheWeek), dayValue) | dayValue.ToString().Contains(","))
                    Console.WriteLine("Converted '{0}' to {1}.", ui1, dayValue.ToString());
                else
                    Console.WriteLine("Please enter a day of the week.", ui1);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter a day of the week.", ui1);
            }
        }
    }
}
