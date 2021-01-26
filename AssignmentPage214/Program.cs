using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPage214
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 4, 26, 38, 68 };
                Console.WriteLine("Enter a number to divide some integers.");
                int ui1 = Convert.ToInt32(Console.ReadLine());
            try
            {
                foreach (int item in list1)
                {
                        int answer1 = item / ui1;
                        Console.WriteLine(answer1);
                }
            }
            catch (FormatException ex)  //used to catch errors with different format together i.e. an integer "8" and a string "Cory".
            {
                Console.WriteLine("Please type a whole number.");
                //return;    //This is used to return back to another page after an exception
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine("The program has left the try/catch block.");
            Console.ReadLine();
        }
    }
}
