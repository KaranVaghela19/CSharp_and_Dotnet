using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
   public class Datatypes
    {
        public  static void Dt()
        {
            byte b = 0;
            Console.WriteLine($"Value of b is {b}");
            Console.WriteLine($"Byte Min Value:{sbyte.MinValue} and Max Value:{sbyte.MaxValue}");

            int j = 10;
            Console.WriteLine($"Value of j is {j} ");
            Console.WriteLine($"int Min Value:{int.MinValue} and Max Value:{int.MaxValue}");

            float f = 12.3f;
            Console.WriteLine($"Value of F is {f}");
            Console.WriteLine($"float Min Value:{float.MinValue} and Max Value:{float.MaxValue}");

            double d = 1234.4;
            Console.WriteLine($"Value of D is {d}");
            Console.WriteLine($"Double Min Value:{double.MinValue} and Max Value:{double.MaxValue}");

            char c = 'A';
            Console.WriteLine($"Value of C is {c}");
            Console.WriteLine($"Char Min Value:{(int)char.MinValue} and Max Value:{(int)char.MaxValue}");

            String s = "HELLO WORLD";
            Console.WriteLine($"Value of S is {s}");
    //        Console.WriteLine($"String Min Value:{String.MinValue} and Max Value:{sbyte.MaxValue}");

            short st = 777;
            Console.WriteLine($"value short String is {st}");
            Console.WriteLine($"Short Min Value:{short.MinValue} and Max Value:{short.MaxValue}");

            long l = 1234567800000000;
            Console.WriteLine($"Value of long is {l}");
            Console.WriteLine($"long Min Value:{long.MinValue} and Max Value:{long.MaxValue}");

            bool bl = false;
            Console.WriteLine($"Value of Boolean is {bl}");
            Console.WriteLine($"Default Value of Boolean: {default(bool)}");

            sbyte sb = 123;    //You can store negative number using sbyte data type.
            Console.WriteLine($"SByte Min Value:{sbyte.MinValue} and Max Value:{sbyte.MaxValue}");



            Console.WriteLine($"Size of Byte: {sizeof(byte)}");
            Console.WriteLine($"Size of Integer: {sizeof(int)}");
            Console.WriteLine($"Size of Character: {sizeof(char)}");
            Console.WriteLine($"Size of Float: {sizeof(float)}");
            Console.WriteLine($"Size of Long: {sizeof(long)}");
            Console.WriteLine($"Size of Double: {sizeof(double)}");
            Console.WriteLine($"Size of Bool: {sizeof(bool)}");
            Console.ReadKey();
        }
    }
}

