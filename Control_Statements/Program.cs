using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the following operations");
            String add = "1. Addidion";
            String sub = "2. Substraction";
            String div = "3. Division";
            String mul = "4. Multiplication";
            Console.WriteLine(add);
            Console.WriteLine(sub);
            Console.WriteLine(div);
            Console.WriteLine(mul);

            label1:
            Console.WriteLine("Enter your Choice");
            String Choice = Console.ReadLine();

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result;

            switch (Choice)
            {
                case "1":
                    result = num1 + num2;
                    Console.WriteLine("Additionof two numbers " + result);
                    break;
                case "2":
                    result = num1 - num2;
                    Console.WriteLine("Substraction of two numbers "  + result);
                    break;
                case "3":
                    result = num1 / num2;
                    Console.WriteLine("Division of two numbers "+ result);
                    break;
                case "4":
                    result = num1 * num2;
                    Console.WriteLine("Multiplication of two numbers "+ result);
                    break;
                default:
                    Console.WriteLine("Enter correct choice");
                    break;
            }
            goto label1;
            Console.ReadLine();
            
        
        }

    }
}