using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversion
{
    internal class conversiondemo
    {
        static void Main()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Weight");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Mobile No");
            long mobile= Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Name:{name} Age:{age} Weight{weight}");
            Console.WriteLine($"Mobile: {mobile}");
        }
    }
}
