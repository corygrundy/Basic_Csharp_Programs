using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPage223
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number would you like to add 5 to?");
            int ui1 = Convert.ToInt32(Console.ReadLine());
            int result1 = Class1.Method1(ui1);
            Console.WriteLine("Your number plus 5 is " + result1);

            Console.WriteLine("What number would you like to  multiply by 4?");
            int ui2 = Convert.ToInt32(Console.ReadLine());
            int result2 = Class1.Method2(ui2);
            Console.WriteLine("Your number multiplied by 4 is " + result2);

            Console.WriteLine("What number would you like to divide by 3 with?");
            int ui3 = Convert.ToInt32(Console.ReadLine());
            int result3 = Class1.Method3(ui3);
            Console.WriteLine("Your number divided by 3 is " + result3);
        }
    }
}
