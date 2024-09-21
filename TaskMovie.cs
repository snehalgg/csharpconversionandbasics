using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversion
{
    internal class TaskMovie
    {
        static void Main()
        {
            Console.WriteLine("Enter Movie id");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Movie Name");
            string name = Console.ReadLine();

            Console.WriteLine("Release Year");
            long year = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter Language");
            string language = Console.ReadLine();

            Console.WriteLine("Enter Director");
            string director = Console.ReadLine();

            Console.WriteLine("Enter Actor");
            string actor = Console.ReadLine();


            Console.WriteLine($"Movie id:{id}");
            Console.WriteLine($"Movie Name:{name}");
            Console.WriteLine($"Year:{year}");
            Console.WriteLine($"Language:{language}");
            Console.WriteLine($"Director: {director}");
            Console.WriteLine($"Actor:{actor}");

        }
    }
}
