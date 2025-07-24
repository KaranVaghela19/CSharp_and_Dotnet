using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello";
            string str1 = "Welcome to .Net programming";
            string str2 = "olhel";
            Console.WriteLine(str1.ToUpper());
            Console.WriteLine(str1.ToLower());
            Console.WriteLine(str1.Substring(1, 8));
            Console.WriteLine(str1.Trim());
            Console.WriteLine(str == str2); // it also checks value and compres string in string constant pool
            Console.WriteLine(str.Equals(str2)); // check value of two string it is method
            int result = String.Compare(str1, str2); // compare will check whether two strings have similar character in it and will return true 
            Console.WriteLine(result);
            Console.WriteLine(str.CompareTo(str2)); /// it checks wether two string are has similar content if not it will return -1 if yes then it will return 0
            Console.ReadLine();

        }
    }
}
