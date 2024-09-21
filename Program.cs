using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            a += 2; //a=a+2
            a=a+10;
            a += 10;
            Console.WriteLine(a);
            int b = 100;
            b-=10; //b= b-10
            Console.WriteLine(b);
            int c = 5;
            c *= 5; //c=c*5
            Console.WriteLine(c);
            int d = 100;
            d /=5;
            Console.WriteLine(d);

            int e = 27;
                e %= 5;
            Console.WriteLine(e);
        }
    }
}
