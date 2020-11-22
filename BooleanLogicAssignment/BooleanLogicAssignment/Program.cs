using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insureance Approval Program");
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int Age = Convert.ToInt32(age);
            Console.WriteLine("Have you ever had a DUI");
            string dui = Console.ReadLine();
            bool DUI = Convert.ToBoolean(dui);
            
            Console.WriteLine("How many speeding tickets do you have?");
            string speed = Console.ReadLine();
            int Speed = Convert.ToInt32(speed);

            Console.WriteLine("Qualified?");
            Console.WriteLine(Age > 15 && DUI == false && Speed <= 3);
            Console.ReadLine();
        }
    }
}
