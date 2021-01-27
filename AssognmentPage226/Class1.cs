using System;
using System.Collections.Generic;
using System.Text;

namespace AssognmentPage226
{
    class Class1
    {   //Begin part 1
        public static int MethodMulti1(int num1)
        {
            int total1 = num1 * 10;
            return total1;
        }

        //Begin part 3
        public static decimal MethodSub1(decimal num2) //This method will subtract 1.3 form a user's input.
        {
            decimal total2 = num2 - 1.3m;   //The m after 1.3 is a datatype suffix that declares the integer as a decimal. useful to ensure the method runs smoothly.
            return total2;
        }

        //Begin part 5
        public static int MethodAdd1(string num3)
        {
            int Num3 = Convert.ToInt32(num3);   //An attempt to convert the user's input into a integer.
            int total3 = Num3 + 5;
            //string total3string = Convert.ToBase64String(total3);
            return total3;
        }
    }
}
