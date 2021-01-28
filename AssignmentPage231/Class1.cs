using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentPage231
{
    public class Class1
    {
        public void Method1(int num1)
        {
            int result = num1 / 2;
            Console.WriteLine(result);
        }

        public int Method1(int num2 = 3, int num3 = 4)
        {
            int result2 = num2 + num3;
            return result2;
        }
    }

    public static class Class2
    {
        
    }
}
