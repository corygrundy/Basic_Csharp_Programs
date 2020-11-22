using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTechAcademyDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();

            Console.WriteLine("What page number?");
            string yourPage = Console.ReadLine();
            int Pagenumber = Convert.ToInt32(yourPage);

            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"false.\"");
            string help = Console.ReadLine();
            bool plsHelp = Convert.ToBoolean(help);

            Console.WriteLine("Were there any positive experiances you'd like to share? Please give specifcs.");
            string positiveExp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string Feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int studyTime = Convert.ToInt32(hours);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have agreat day!");
            Console.ReadLine();
        }
    }
}
