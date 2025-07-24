using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> sd = new SortedDictionary<int, string>();
            sd.Add(101, "Karan");
            sd.Add(99, "Mayur");
            sd.Add(102, null);
            sd.Add(103, "Nishant");
            sd.Add(104, "Niraj");
            sd.Add(100, null);
           
            string name;

            Console.WriteLine("Key is Present : " + sd.ContainsKey(99));
            Console.WriteLine("Value is Present : " + sd.ContainsValue(null));
            Console.WriteLine("Key has Been Removed: " + sd.Remove(100));
            Console.WriteLine(sd.TryGetValue(100, out name ));
            Console.WriteLine("______________________________________________");



            foreach (var sorteddic in sd)
            {
                Console.WriteLine($"Key: { sorteddic.Key}, Value: {sorteddic.Value}");
            }
            Console.ReadLine();

        }
    }
}
