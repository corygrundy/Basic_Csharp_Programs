using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPage231
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 classObj = new Class1();
            Console.WriteLine("Please enter a number.");
            int ui1 = Convert.ToInt32(Console.ReadLine());
            classObj.Method1(ui1);

            Console.WriteLine("How about some math? \n Enter a number.");
            int ui2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now wenter a second number.");
            int ui3 = Convert.ToInt32(Console.ReadLine());
            int response1 = classObj.Method1( out ui2, out ui3);
            Console.WriteLine("Your numbers added together equal " + response1);
            Console.ReadLine();
        }
    }
}
