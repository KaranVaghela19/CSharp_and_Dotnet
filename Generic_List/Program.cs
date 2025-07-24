using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ls = new List<string>();
            ls.Add("Karan");
            ls.Add("Mayur");
            ls.Add("Nishant");
            ls.Add("Neil");
            ls.Add("Yuvraj");

            List<string> list = new List<string>();
            ls.Add("Pranav");
            ls.Add("Pratham");

            ls.AddRange(list);
            ls.Sort();

            Console.WriteLine(ls.Contains("Yuvi"));
            Console.WriteLine("_______________________________________________________");

            ls.Insert(7, "Brad");
            ls.Remove("Mayur");
           Console.WriteLine( "The Index Position of Neil is : " + ls.IndexOf("Neil"));

           Console.WriteLine("_______________________________________________________");
           Console.WriteLine(ls.LastIndexOf("Pratham"));
           Console.WriteLine("_______________________________________________________");
           


            foreach (string lst in ls)
            {
                Console.WriteLine(lst);
            }
            Console.ReadLine();
        }
    }
}
