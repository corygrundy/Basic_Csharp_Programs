using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPage198
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringsArray = new string[3];
            stringsArray[0] = "This string is in the first of three in this array.";
            stringsArray[1] = "This string is in the second of three in this array.";
            stringsArray[2] = "This string is the last o three in this array.";

            Console.WriteLine("Please select an index for the array of strings.");
            int indexNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringsArray[indexNum]);
            Console.ReadLine();
        }
    }
}
