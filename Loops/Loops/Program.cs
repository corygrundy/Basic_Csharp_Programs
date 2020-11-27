using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number?");
                        break;
                    case 29:
                        Console.WriteLine("You gussed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number?");
                        break;
                    case 12:
                        Console.WriteLine("You guessed the number 12. That is correct!");
                        Console.WriteLine("Guess a number?");
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        break;
                }
            }
            while (!isGuessed);
            Console.ReadLine();
        }
    }
}
