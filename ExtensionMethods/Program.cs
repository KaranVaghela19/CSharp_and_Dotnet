using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maths;
using ExtensionMethods;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Custlib cl = new Custlib();
            Console.WriteLine( cl.Sub(20, 10));

            string name = "Karan";
            name.Iterate(c => Console.WriteLine($"Character: {c}"));
            Console.ReadLine();


        }
    }
}