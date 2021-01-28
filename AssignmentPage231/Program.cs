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

            Console.WriteLine("How about some math?");
            int response1 = classObj.Method1();
            Console.WriteLine("Three plus Four equals " + response1);
            Console.ReadLine();
        }
    }
}
