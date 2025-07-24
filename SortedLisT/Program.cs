using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SortedLisT
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("EmpId", 101);
            sl.Add("EmpName", "Karan");
            sl.Add("EmpSal", 20000);
            sl.Add("EmpLocation", "Pune");

            /*    sl.Remove("EmpId");
                sl.RemoveAt(2); */

          Console.WriteLine(sl.Contains("EmpName"));
          Console.WriteLine("_____________________________________________");

          Console.WriteLine(sl.ContainsKey("EmpSname"));
          Console.WriteLine("_____________________________________________");

         Console.WriteLine(sl.ContainsValue(20000));
         Console.WriteLine("_____________________________________________");

         Console.WriteLine(sl.GetByIndex(3));
         Console.WriteLine("_____________________________________________");

         Console.WriteLine(sl.GetKey(1));
         Console.WriteLine("_____________________________________________");

            foreach (var key in sl.GetKeyList())
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("_____________________________________________");

            foreach (var value in sl.GetValueList())
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("_____________________________________________");

            Console.WriteLine($"Index of EmpSal :  {sl.IndexOfKey("EmpSal")}");
            Console.WriteLine("_____________________________________________");

            Console.WriteLine($"Index of  :  {sl.IndexOfValue("Pune")}");
            Console.WriteLine("_____________________________________________");

            foreach (DictionaryEntry sortlst in sl)
            {
                Console.WriteLine(sortlst.Key +" : "+ sortlst.Value);
            }

            Console.ReadLine();
        }
    }
}
