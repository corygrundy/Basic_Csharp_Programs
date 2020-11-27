using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringsFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string concatenation1 = "This is a string.";
            string concatenation2 = " This string was added to the first.";
            string concatenation3 = " This last string is also an addition.";
            string Concatenate = concatenation1 + concatenation2 + concatenation3;
            string name = "Cory Grundy";

            Console.WriteLine(Concatenate);
            Console.ReadLine();

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            name = name.ToUpper();

            Console.WriteLine(name);

            StringBuilder sb = new StringBuilder("This paragraph is built using multiple stings.");

            sb.AppendFormat("GHI{0}{1}", " Allowing us to make paragraphs with multiple strings.", " That can be easily manipulated later.", " This is very fun to utilize.");


            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
