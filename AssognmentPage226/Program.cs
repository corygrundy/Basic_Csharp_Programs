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
            Console.WriteLine("Enter a number to add 10 to.");
            int ui1 = Convert.ToInt32(Console.ReadLine());
            int result1 = Class1.MethodAdd1(ui1);
            Console.WriteLine("Your number plus 10 is " + result1);

            //Begin part 4
            Console.WriteLine("Enter a number for subtraction with decimals.");
            decimal ui2 = Convert.ToDecimal(Console.ReadLine());    //Using Convert.ToDecimal here so a user may input a decimal
            decimal resault2 = Class1.MethodSub1(ui2);
            Console.WriteLine("Your number minus 1.3 is " + resault2);
            Console.ReadLine();
        }
    }
}
