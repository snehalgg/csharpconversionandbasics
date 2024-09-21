using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversion
{
    internal class postNO
    {
    static void Main(string[] args)
        {
            //simple if
            Console.WriteLine("Enter Age");
            int age= int.Parse(Console.ReadLine());
            if (age >=5 && age <= 15) 
            {
                Console.WriteLine("U r the student");

            }
            Console.WriteLine("Enter no");
            int no = int.Parse(Console.ReadLine()); 
            if (no>0)
            {
                Console.WriteLine($"{no} is +ve number");
    
            }
        }
    }
}
