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

        public int Method2(out int num2, out int num3)
        {
            num2 = 2;
            num3 = 3;
            int result2 = num2 + num3;
            return result2;
        }
    }

    public static class Class2
    {
        
    }
}
