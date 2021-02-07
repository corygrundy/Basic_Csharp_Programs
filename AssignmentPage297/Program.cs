using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AssignmentPage297
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\grund\Logs\log.txt";  //This line of code helps to easily refer to the filepath when writing to or reading from a file. this allows a coder to shorten the amount of time typing this same path over and over in code.

            Console.WriteLine("Enter a number");  //This line prints to the console a line asking a user for input
            string userNum = Console.ReadLine();  //This line takes the user's input into a string to be easily recalled in the code later.
            File.WriteAllText(path, userNum);  //This line logs the user's input into the file specified in line 14. If you don't make the string path in line 14, just type out the path to the file you are going to use.
            string readText = File.ReadAllText(path);  //This line of code will create a new string to be printed to the screen, and using the File.ReadAllText method, will read all the text from a file to a user.
            Console.WriteLine(readText);
        }
    }
}
