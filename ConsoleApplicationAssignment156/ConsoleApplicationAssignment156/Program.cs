using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment156
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a number to et multiplied by 50.");
            string numberString = Console.ReadLine();
            decimal numberDecimal = Convert.ToDecimal(numberString);
            decimal product1 = numberDecimal * 50;
            Console.WriteLine(product1);

            Console.WriteLine("Type in another number that will get an additional 25.");
            string numberString2 = Console.ReadLine();
            decimal numberDecima2 = Convert.ToDecimal(numberString2);
            decimal total1 = numberDecima2 + 25;
            Console.WriteLine(total1);

            Console.WriteLine("Type in a number to get divided by 12.5.");
            string numberString3 = Console.ReadLine();
            float numberFloat1 = float.Parse(numberString3);
            float quotient1 = numberFloat1 / 12.5f;
            Console.WriteLine(quotient1);

            Console.WriteLine("Type in a number to compare it to 50.");
            string numberString4 = Console.ReadLine();
            int numberInt4 = Convert.ToInt32(numberString4);
            bool greater = numberInt4 > 50;
            Console.WriteLine(greater);

            Console.WriteLine("Type in a number to be divided by seven, and tell you if there is a remainder.");
            string numberString5 = Console.ReadLine();
            decimal numberDecimal5 = Convert.ToDecimal(numberString5);
            decimal remainder = numberDecimal5 % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();
        }
    }
}
