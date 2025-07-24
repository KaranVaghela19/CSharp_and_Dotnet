using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefined_Functions
{
    class User_Defined
    {
        static void Main(string[] args)
        {
            Sum(10, 20);
            Sum(10, 10);
            float s = Sum(13.5f, 10.3f);
            Console.WriteLine($"The value is {s}");
            Console.ReadLine();
        }
        static void Sum(int a , int b)
        {
           int  result = a + b;
            Console.WriteLine($"The sum of two numbers: {result}");
        }

        static void Sum(int c , double d)
        {
            int i = (int)d;
            int result = c + i;
            Console.WriteLine($"The sum of two numbers: {result}");

        }
        static float Sum(float a, float b)
        {
            return a + b;
        }
    }
}
