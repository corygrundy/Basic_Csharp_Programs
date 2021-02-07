using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPage314
{
    class Program
    {
        static void Main(string[] args)
        {   
            int currentYear = 2021;
            int userAge = 0;
            bool validAnswer = false;
            try
            {
                while (!validAnswer)
                {
                    Console.WriteLine("What is your age?");
                    validAnswer = int.TryParse(Console.ReadLine(), out userAge);
                    Console.WriteLine(currentYear - userAge);
                    Console.ReadLine();
                }
                if (userAge < 0 || userAge <= -1)
                {
                    throw new NumberException();
                }
            }
            catch (NumberException)
            {
                Console.WriteLine("Error. User must enter a whole number.");
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Uh oh, something went wrong.");
                return;
            }
        }
    }
}
