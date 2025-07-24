using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            class1 obj1 = new class1();
            obj1.num1 = 10;
            obj1.str1 = "Kartik";


            class1 obj2 = new class1();
            obj2.num1 = 20;
            obj2.str1 = "Karan";

            class1 obj3 = new class1();
            obj3 = obj1 + obj2;
        }


    }
     class class1
    {
       public int num1 = 0;
       public string str1 = "";

        public static class1 operator +(class1 obj1 , class1 obj2)
        {
            class1 obj3 = new class1();
            obj3.num1 = obj1.num1 + obj2.num1;
            obj3.str1 = obj1.str1 + obj2.str1;
            return obj3;
        }
    }

}