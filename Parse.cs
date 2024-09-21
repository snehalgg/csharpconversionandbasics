using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversion
{
    internal class Parse
    {
     static void Main() 
        {
            //Parse() method use to convert string to any value type (int, short, byte, double, float etc)
            int k = int.Parse("100"); //convert string to int
            byte b = byte.Parse("23");
            short s = short.Parse("100"); //convert string to short
            double d = double.Parse("100.23"); //string to double
            float f = float.Parse("23.34"); //string to float
            decimal dc = decimal.Parse("12.23444"); //string to decimal
            bool b1 = bool.Parse("true"); //string to bool
            Console.WriteLine($"{k} {b} {dc}");
            string s1 = "123";
            int i1 = int.Parse(s1);
            double d2 = double.Parse(s1);
            float f2 = float.Parse("abcd"); //exception(runtime error)
        }
    }
}
