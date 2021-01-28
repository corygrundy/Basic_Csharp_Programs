using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPage227
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number.");
            int ui1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You may add a second number here, otherwise leave it blank.");
            string input2 = Console.ReadLine();
            if (input2 == "")
            {
                int result1 = Class1.MethodAdd1(ui1);
                Console.WriteLine("The result is " + result1);
            }
            else
            {
                int ui2 = Convert.ToInt32(input2);
                int result1 = Class1.MethodAdd1(ui1, ui2);
                Console.WriteLine("The result is " + result1);
            }
            Console.ReadLine();
        }
    }
}
