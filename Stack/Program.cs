using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StacK
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack sc = new Stack();
            sc.Push(10);
            sc.Push(20);
            sc.Push(30);
            sc.Push(40);
            sc.Push(50);

            foreach (int stc in sc)
            {
                Console.WriteLine(stc);
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"The Peek(Top) element in Stack is : { sc.Peek()}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Top Element is Removed : { sc.Pop()}");
            Console.WriteLine("---------------------------------------------------");
            object[] arr = new object[sc.Count];
            sc.CopyTo(arr, 0);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine( sc.Contains(40));

            Console.WriteLine("---------------------------------------------------");
            Stack syncStack = Stack.Synchronized(sc);
            Console.WriteLine("Is original stack synchronized? " + sc.IsSynchronized); // False
            Console.WriteLine("Is sync stack synchronized? " + syncStack.IsSynchronized);         // True
            Console.ReadLine();
        }
    }
}
