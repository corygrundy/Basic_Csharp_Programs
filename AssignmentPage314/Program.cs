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
                    if (userAge < 0 || userAge <= -1)
                    {
                        throw new NumberException();
                    }
                    else if (userAge == 0)
                    {
                        throw new ZeroException();
                    }
                    else
                    Console.WriteLine(currentYear - userAge);
                    Console.ReadLine();
                }
                
            }
            catch (ZeroException)
            {
                Console.WriteLine("Error. User must not enter their age as 0.");
                Console.ReadLine();
                return;
            }
            catch (NumberException)
            {
                Console.WriteLine("Error. User must enter a positive whole number.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Uh oh, something went wrong.");
                Console.ReadLine();
                return;
            }
        }
    }
}
