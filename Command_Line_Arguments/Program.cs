using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Line_Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            args[0] = "Hello";
            args[1] = "World";

            Console.WriteLine(args[1] + args[0]);
            Console.ReadLine();

        }
    }
}
