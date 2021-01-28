using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssingmentPage228
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in a number.");
            int ui1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter in a second number.");
            int ui2 = Convert.ToInt32(Console.ReadLine());
            int result1 = Class1.Method1(ui1, ui2);
        }
    }
}
