using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversion
{
    internal class Ternary_opp
    {
        static void Main()
        {
            int a = 10;
            int b = 20;
            string result = a > b ? $"{a} is Max" : $"{b} is Max"; //Ternary operator
            Console.WriteLine(result);
            bool r = a > b ? true : false;
            Console.WriteLine(r);
        }
    }
}
