using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Non Generic Collections
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(true);
            al.Add("Hello");
            al.Add(13.9f);
            al.AddRange(new object[] { "World", false, 99 });
            al.Insert(1, "Hii");
            al.InsertRange(2, new object[] { "A", "B" });
            al.Contains("Hello");
            al.Remove("Hello");
            ArrayList clonedList = (ArrayList)al.Clone();
            clonedList.Clear();
            int lastIndex = al.LastIndexOf(99);
            Console.WriteLine("Last index of '99': " + lastIndex);
            int total = al.Count;
            Console.WriteLine(string.Format($"Capacity: {al.Capacity}"));

            Console.ReadLine();
            foreach (object coll in al)
            {
                Console.WriteLine(coll);
            }
           
            Console.ReadLine();

            foreach (object col in clonedList)
            {
                Console.WriteLine(col);
            }
            Console.ReadLine();

            ArrayList li = new ArrayList() { 10, 0, 9, 20, 11, 2};
            li.Sort();
            int index = li.BinarySearch(11);
            li.Reverse();
            foreach (int lis in li)
            {
                Console.WriteLine(lis);
            }
            Console.WriteLine("\nIndex of 11: " + index);
            Console.ReadLine();
            

        }
    }
}
