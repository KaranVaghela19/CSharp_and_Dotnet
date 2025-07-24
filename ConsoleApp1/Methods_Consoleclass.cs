using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Methods_Consoleclass
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ReadLine();

            Console.WriteLine("ForegroundColor: White");

            int i = Convert.ToInt32(Console.ReadLine());
            //Write Method Print the value and goes to different line
            Console.WriteLine($"Hello .Net {i} ");
            Console.ReadKey();

            //Write Method Print the value and stay in the same line
            Console.Write("Hello from C#");
            Console.ReadLine();

            Console.WriteLine("Enter");
                int num1 = Console.Read();  // This method read a single character from the keyboard and returns its ASCII value
                Console.WriteLine($"The ASCII Value of letter is {num1}");
                Console.ReadKey();
            /*ReadKey():  This method reads a single character from the keyboard and returns that character information like what key has been entered
            , and what its corresponding ASCII value is.  */

        
        }
    }
}
