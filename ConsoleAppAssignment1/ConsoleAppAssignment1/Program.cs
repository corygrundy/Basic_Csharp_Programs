﻿using System;
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
            string[] dogsarray = new string[4];
            dogsarray[0] = "alaskan malamute";
            dogsarray[1] = "pug";
            dogsarray[2] = "alaskan husky";
            dogsarray[3] = "german shepard";


            Console.WriteLine("please add breed to the array of dogs");
            string userinput = Console.ReadLine();

            for (int i = 0; i < dogsarray.Length; i++)
            {
                dogsarray[i] = dogsarray[i] + userinput;
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

            int k = 0;
            while (k < 10)
            {
                Console.WriteLine("k = {0}", k);

                k++;
            }

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

            List<string> catList2 = new List<string> { "Sadie", "Spicy", "Spicy" };

            string Input5 = Console.ReadLine();

            for (int i = 0; i < catList2.Count; i++)
            {
                if (Input5 == catList2[i])
                {
                    Console.WriteLine(i);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Your input is not in the list.");
            }

            List<string> List3 = new List<string> { "Kobe", "Millie", "Millie", "Sadie" };

            foreach (string it in List3)
            {
                Console.WriteLine(List3[1] + List3[2] + " are repeating in this list.");
                Console.ReadLine();
            }
            
        }
    }
}