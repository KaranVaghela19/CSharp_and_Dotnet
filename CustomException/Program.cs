using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    public class MyException : Exception
    {
        public MyException(string message) : base(message) { 
        }
    }

    class class2
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Your Age");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 0)
                {
                    throw new MyException("Age cannot be negative");
                }
                Console.WriteLine("Age is invalid");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }

    }
}
