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
        {   //Part 2 begin
            Class1 classObj = new Class1();
            //Part 3 begin
            Console.WriteLine("Enter in a number.");
            int ui1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter in a second number.");
            int ui2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");    //Added in to avoid confusion. And for practice.  \n is a shortcut for a break or like the <br> statement in HTML.
            classObj.Method1(ui1, ui2);

            //Part 4 begin
            int u1 = 2;
            int u2 = 3;
            classObj.Method1(u2 , u1);
        }
    }
}
