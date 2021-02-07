using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace AssignmentPage300
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime localDate = DateTime.Now;
            Console.WriteLine(localDate);
            Console.WriteLine("Please enter a number.");
            int hour = Convert.ToInt32(Console.ReadLine());
            DateTime later = DateTime.Now.AddHours(hour);
            Console.WriteLine(later);
            Console.ReadLine();
        }
    }
}
