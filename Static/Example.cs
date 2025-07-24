using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Example
    {

        int x = 100;
        static int y = 200;
        static void Add()
        {
            //we can access non static members X with the help of Exam
            //This is a static blockple object
            //We can access the static member directly or through class name
            Example obj = new Example();
            //Console.WriteLine(obj.x + Example.y);
            Console.WriteLine("Sum of 100 and 200 is :" + (obj.x + y));
            Console.WriteLine("Sum of 100 and 200 is :" + (obj.x + Example.y));
        }
        void Mul()
        {
            //This is a Non-Static method
            //we can access static members directly or through class name
            //we can access the non-static members directly or through this keyword
            Console.WriteLine("Multiplication of 100 and 200 is :" + (this.x * Example.y));
            Console.WriteLine("Multiplication of 100 and 200 is :" + (x * y));
        }
            static void Main(string[] args)
        {

            Example.Add();

            Example ex = new Example();
            ex.Mul();
            Console.ReadLine();
        }
    }
   

    }
      

   
        
    

