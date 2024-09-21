using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversion
{
    internal class ifelse
    {
        static void Main()
        {
            //if-else
            Console.WriteLine("Enter a, b values");
            int a = int.Parse(Console.ReadLine());  
            int b= int.Parse(Console.ReadLine());   
            if(a>b)
            {
                Console.WriteLine($"{a} is max");

            }
            else
            {
                Console.WriteLine($"{b} is max");
                
            }
            Console.WriteLine("enter no");
            int no = int.Parse(Console.ReadLine());
            if (no % 2 == 0)
            {
                Console.WriteLine($"{no} is Even");

            }
            else
                Console.WriteLine($"{no} is Odd");

        }
    }
}
