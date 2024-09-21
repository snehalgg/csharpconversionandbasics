using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversion
{
    internal class convert_inttodouble
    {
        static void Main()
        {
            int i = Convert.ToInt32(12.34); //convert to int
            i = Convert.ToInt32("123"); //string to double
            double d = Convert.ToDouble("123.34");
            byte b = Convert.ToByte(i); //Convert string 
            string s = Convert.ToString('c');
            s = Convert.ToString(100);
            s = Convert.ToString(12.34);
            s = Convert.ToString(true);
            int k = Convert.ToInt32(345.56); //double 
            long l = Convert.ToInt64(345.21); //double
            k = Convert.ToInt32(l); //long to int
        }    }
}
