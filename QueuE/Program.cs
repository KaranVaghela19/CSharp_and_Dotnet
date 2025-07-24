using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace QueuE
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("Karan");
            q.Enqueue("Nayan");
            q.Enqueue("Niraj");
            q.Enqueue("Deep");
            q.Enqueue("Neel");

            Console.WriteLine($"Element Removed from the Queue : {q.Dequeue()}");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"Element at the Top Of Queue : {q.Peek()}");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"Element is present in Queue : {q.Contains("Niraj")}");
            Console.WriteLine("---------------------------------------------------------");
           

            foreach (object qu in q)
            {
                Console.WriteLine(qu);
            }
            Console.ReadLine();

        }



    }
}