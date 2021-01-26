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
            //Begin part 1
            string[] dogsarray = new string[4];
            dogsarray[0] = "alaskan malamute";
            dogsarray[1] = "pug";
            dogsarray[2] = "alaskan husky";
            dogsarray[3] = "german shepard";


            Console.WriteLine("Please add breed to the array of dogs");
            string userinput = Console.ReadLine();

            for (int i = 0; i < dogsarray.Length; i++)
            {
                Console.WriteLine(dogsarray[i] = dogsarray[i] + " " + userinput); //This line will print off every item in the array with the user's input added. It was missing "Console.WriteLine()" when I last submitted this.
            }
            Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "stop")
                {
                    Console.WriteLine("goodbye!");
                    break;
                }

                Console.WriteLine("> " + input.ToUpper());
            }
    
            //Begin part 2
               //Below is an infinite loop.
            //while (true)
            //{
            //    int input = convert.toint32(console.readline());

            //    if (input < 25)
            //    {
            //        console.writeline("goodbye!");
            //        break;
            //    }

            //    console.writeline("> " + input);
            //}


            //Begin part 3
            int k = 0;     //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
            while (k < 10)
            {
                Console.WriteLine("k = {0}", k);

                k++;
            }

            int c = 0;     //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
            while (c <= 10)
            {
                Console.WriteLine("c <= {0}", c);

                c++;
            }

            //Begin part 4
            List<string> catList1 = new List<string> { "George", "Kenny", "Shade" };
            Console.WriteLine("Please input  to search for a cat.");
            string Input4 = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < catList1.Count; i++)
            {
                if (Input4 == catList1[i]) //if a user's input matches a string in the list above, it will execute this code.
                {
                    Console.WriteLine(i); //output the index of the found item in the list.
                    found = true;
                    break;  //this stops the loop if a match is found.
                }
            }
            if (!found)
            {
                Console.WriteLine("Your input is not in the list.");
            }

            //Begin part 5
            List<string> catList2 = new List<string> { "Sadie", "Spicy", "Spicy" };
            Console.WriteLine("Please enter Sadie or Spicy to continue.")
            string Input5 = Console.ReadLine();
            for (int i = 0; i < catList2.Count; i++)
            {
                if (Input5 == catList2[i])
                {
                    Console.WriteLine(i);       
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Your input is not in the list.");
            }

            //Begin part 6
            List<string> List3 = new List<string> { "Kobe", "Millie", "Millie", "Sadie" };
            List<string> List4 = new List<string>();
            foreach (string dogname in List3)
            {
                foreach (string dogname2 in List4)
                {
                    if (dogname == dogname2)
                    {
                        Console.WriteLine(dogname + " has appeared before.");
                    }
                }
                List4.Add(dogname);
            }
            Console.WriteLine(List4);
            Console.ReadLine();
        }
    }
}
