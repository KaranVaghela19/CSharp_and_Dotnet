using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_And_itsTypes
{
    class Program
    {
        static int I = 1;
        static Program(){   // STATIC CONSTRUCTOR

            Console.WriteLine("Inside the static constructor");
            Console.ReadLine();

        }
        static void Main(string[] args)
        {

            Console.WriteLine("Inside Main Method");
            Console.ReadLine();

            test t1 = new test(10);
            t1.display();

            test t2 = new test(t1);
            t2.display();
            Console.ReadLine();

            
       
        }
    }
    public class test
    {
        int x = 10;

        public test(int i) // EXPLICIT CONSTRUCTOR        
        {
            x = i;
            Console.WriteLine("Parameterized Constructor called " + i);
        }

        public test(test obj)  // COPY CONSTRUCTOR
        {
            x = obj.x;
        }


        public void display(){
            Console.WriteLine("value of x is " + x);
            }
    }


  
} /*
There can be only one static constructor in a class.
It can’t be called explicitly, it is always called implicitly.
The static constructor should be without any parameters.
It can only access the static members of the class.
There should not be any access specifiers in the static constructor definition.
If a class is static then we cannot create the object for the static class.
It is called automatically to initialize the static members.
Static constructor will be invoked only once i.e. at the time of class loading.*/