using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // the process of converting the value of one data type (int, float, double, etc.)
            // to another data type ((int, float, double, etc.)) is known as type conversion or typecasting.

            Console.WriteLine("Explicit Type Casting");
            double dl = 1.23;
            int i = (int)dl;
            Console.WriteLine(i);
            Console.ReadLine();

            Console.WriteLine("Implicit Type Casting");
            int a = 10;
            long l = a;
            Console.WriteLine(l);
            Console.ReadLine();


            try
            {
                string str = "Hello";
                int i1 = Convert.ToInt32(str); //Converting string to Integer

                Console.WriteLine($"Original value str: {str} and Converted Value i1:{i1}");
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("its not posssible " + ex.Message);
                Console.ReadLine();
            }


            // Parse method (type conversion)
            string str2 = "100";
            int b = int.Parse(str2);
            Console.WriteLine($"value of converted string : {b}");
            Console.ReadLine();


        }
    }
}
