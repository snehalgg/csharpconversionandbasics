using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversion
{
    internal class implicitconversion
    {
        static void Main(string[] args) 
        {
            //implicit conversion
            byte b = 100;
            int k = b;
            short c = b;
            char ch = 'a';
            k= ch; //return ascii value of a 
            Console.WriteLine(k);
            int i = 100;
            long l = i;
            double d = i;
            float f = i;
            long l1 = 4320943;
            double d1 = l1;
            decimal dc = l1;
            float f1 = 34.56f;
            double d2 = f1;

        }
    }
}
