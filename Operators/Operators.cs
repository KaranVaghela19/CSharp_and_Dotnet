using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Operators
    {
        static void Main(string[] args)
        {

            //Arithmetic Operators
            int add = 10 + 20;
            int sub = 90 - 10;
            int mul = 10 * 10;
            int div = 10 / 10;
            int mod = 4 % 2;

            Console.WriteLine(add);
            Console.WriteLine(sub);
            Console.WriteLine(mul);
            Console.WriteLine(div);
            Console.WriteLine(mod);
            Console.Read();


            // Assignment Operators
            int a = 10;
            a += 15;
            Console.WriteLine("Output of addition is" +a);
            Console.Read();


            a = 30;
            a -= 10;
            Console.WriteLine("Output of substraction is " + a);
            Console.Read();

            a = 15;
            a *= 5;
            Console.WriteLine("Output of multiplication is " + a);
            Console.Read();


            // Relational Operators
            bool Result;
            int Num1 = 5, Num2 = 10;
            Console.WriteLine(Result = Num1 == Num2 );
            Console.Read();

            Console.WriteLine(Result = Num1 != Num2);
            Console.Read();

            Console.WriteLine(Result = Num1 > Num2);
            Console.Read();

            Console.WriteLine(Result = Num1 < Num2);
            Console.Read();

            // logical operators
            bool res;
            bool b1 = true; bool b2 = false;
            Console.WriteLine(res = b1 && b2);
           Console.Read();

            Console.WriteLine(res = b1 || b2);
            Console.Read();

            Console.WriteLine(res =  ! b2);
            Console.Read();

            // unary operators
            int x = 10;
            int nt =  ++x;
            Console.WriteLine(nt);
            Console.Read();

            // Ternary operators
            int t1 = 10; int t2 = 20;
            int res1 = ((t1 > t2) ? t1 : t2);
            Console.WriteLine(res1);
            Console.Read();

        }
    }
}
