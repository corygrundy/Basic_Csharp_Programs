using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dogsArray = new string[4];
            dogsArray[0] = "Alaskan Malamute";
            dogsArray[1] = "Pug";
            dogsArray[2] = "Alaskan Husky";
            dogsArray[3] = "German Shepard";


            Console.WriteLine("Please change the value of array[3] from German Shpard to Great Dane");
            Console.ReadLine();

            for (string i = 0; i < dogsArray.Length; i++)
            {
                if (dogsArray[i] > 85)
                {
                    Console.WriteLine("Passing test score: " + dogsArray[i]);
                }
                Console.ReadLine();
            }

            foreach (string dogs in dogsArray)
            {
                Console.WriteLine(dogs);
                
            }
            Console.ReadLine();
        }
    }
}
