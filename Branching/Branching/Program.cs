using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have an awesome favorite number." : "You do not have an awesome favorite number.";

            Console.WriteLine(result);
            Console.ReadLine();
            
            //int roomTemperature = 70;
            //Console.WriteLine("Hi what is your name>");
            //string name = Console.ReadLine():

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currntTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currntTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room Temperature.");
            //}
            //else if (currntTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currntTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("Uhhhhh.... something went wrong.");
            //}

            //int currentTemperature = 70;
            //int roomTemprtature = 70;

            //string comparisonResult = currentTemperature == roomTemprtature ? "it is room temp." : "It is not room temp.";
            //Console.WriteLine(comparisonResult);
            //if (currentTemperature == roomTemprtature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemprtature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemprtature > currentTemperature)
            //{
            //    Console.WriteLine("Room temperature is warmer than current temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exaclty room temperature.");
            //}
            Console.ReadLine();
        }
    }
}
