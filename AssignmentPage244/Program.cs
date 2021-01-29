using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPage244
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Begin part 5
            Employee emp1 = new Employee();
            emp1.firstName = "Sample";
            emp1.lastName = "Student";
            emp1.SayName();
            IQuittable quittable1 = new Employee();
            quittable1.Quit(emp1);
        }
    }
}
