using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Parents p = new Child();
            p.father();
            p.mother();

            Console.ReadLine();
        }
    }


    public interface Parents {

        void father();
        void mother();
    }



    public interface Parent1
    {
        void v1();
        void v2();
    }

    public class Child: Parents, Parent1 {

        public void father()
        {
            Console.WriteLine("Child inherits the behaviour of father");
        }

       public void mother()
        {
            Console.WriteLine("Child Inherits the behaviour of mother");
        } 

        public void v1()
        {
            Console.WriteLine("Can access properties of p1");
        }
        public void v2()
        {
            Console.WriteLine("Can access properties of p2");
        }
        }



}