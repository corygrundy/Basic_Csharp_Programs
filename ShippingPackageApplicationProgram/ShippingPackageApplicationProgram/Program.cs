using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingPackageApplicationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter package weight.");
            int packW = Convert.ToInt32(Console.ReadLine());
            if (packW > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            Console.WriteLine("What is the package width?");
            int packWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height of the package?");
            int packH = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the length of the package?");
            int packL = Convert.ToInt32(Console.ReadLine());
            if (packWidth + packH + packL > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            int package1 = packWidth * packH * packL;
            int packageTotal = package1 * packW;
            int packageQuote = packageTotal / 100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + packageQuote + ".00.");
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
