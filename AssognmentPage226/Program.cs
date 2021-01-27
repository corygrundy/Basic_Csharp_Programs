using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssognmentPage226
{
    class Program
    {
        static void Main(string[] args)
        {    //Begin part 2
            Console.WriteLine("Enter a number to multiply by 10.");
            int ui1 = Convert.ToInt32(Console.ReadLine());
            int result1 = Class1.MethodMulti1(ui1);
            Console.WriteLine("Your number plus 10 is " + result1);

            //Begin part 4
            Console.WriteLine("Enter a number for subtraction with decimals.");
            decimal ui2 = Convert.ToDecimal(Console.ReadLine());    //Using Convert.ToDecimal here so a user may input a decimal
            decimal result2 = Class1.MethodSub1(ui2);
            Console.WriteLine("Your number minus 1.3 is " + result2);
            

            //Begin part 6
            Console.WriteLine("Enter a string to add the number 5 to it.");
            string ui3 = Console.ReadLine();
            //string result3 = Convert.ToString(Class1.MethodAdd1(ui3)); 
            int result3 = Class1.MethodAdd1(ui3);
            Console.WriteLine("Your string with the added number of ten reads, " + result3);
            Console.ReadLine();
        }
    }
}
