using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number.");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dividing the two...");
            int numberThree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numberOne + " divided by" + numberTwo + " equals " + numberThree);
            Console.ReadLine();
        }
    }
}
