using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Generic_HashSet
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside HashSet");
            HashSet<int> hs = new HashSet<int>();
            hs.Add(10);
            hs.Add(20);
            hs.Add(30);
            hs.Add(4);
            hs.Add(50);
            hs.Add(50);

            Console.WriteLine(hs.Remove(4));

            Console.WriteLine(hs.Contains(30));


            foreach (var hashset in hs)
            {
                Console.WriteLine(hashset);
            }
           
          //  Console.ReadLine();

            Console.WriteLine("___________________________________________");
            Console.WriteLine("Inside SortedSet");

            SortedSet<string> ss = new SortedSet<string>();
            ss.Add("Pune");
            ss.Add("Sangli");
            ss.Add("Satara");
            ss.Add("Kolhapur");
            ss.Add("Mumbai");

          Console.WriteLine(  ss.Contains("Pune"));

            foreach (var sortedset in ss)
            {
                Console.WriteLine(sortedset);
            }
            Console.ReadLine();
        }
    }
}
