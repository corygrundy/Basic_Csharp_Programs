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

            int[] intArray = new int[4];
            intArray[0] = 1;
            intArray[1] = 4;
            intArray[2] = 23;
            intArray[3] = 5;

            Console.WriteLine("Please select an index number between 0-3");
            int ui = Convert.ToInt32(Console.ReadLine());     //The line of code that converts the user input into an int type allowing an index from an array be compared.
            if (ui > 3 || ui < 0)
            {

                Console.WriteLine("Error: that was not a number between 0-3. Shutting down...");
            }
            else
            {
                Console.WriteLine(intArray[ui]);
            }
            Console.ReadLine();

            List<string> List3 = new List<string> { "This is string at index 0.", "This is a string at index 1.", "This final string is at index 2." };
            Console.WriteLine("Please select an index between 0-2.");
            int ui1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(List3[ui1]);
            Console.ReadLine();
        }
    }
}
