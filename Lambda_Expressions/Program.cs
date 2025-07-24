using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ls = new List<int>();
            ls.Add(10);
            ls.Add(23);
            ls.Add(30);
            ls.Add(13);
            List<int> result = new List<int>();

            Func<int, bool> isEven = x => x % 2 == 0;

            foreach (int cl in ls)
            {
                if (isEven(cl))
                {
                    result.Add(cl);
                }
            }
            Console.WriteLine("Even Numbers:");
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
