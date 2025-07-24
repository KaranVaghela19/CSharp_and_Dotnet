using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maths;

namespace Access_Specifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Custlib c = new Custlib();
            Console.WriteLine(c.Addition(10,10));
            Console.Read();
        }
    }
}
