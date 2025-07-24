using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
        label1:
            String str = "";
            while (string.IsNullOrEmpty(str))
            { 
            
                Console.WriteLine("Enter the String");
                str = Console.ReadLine()?.ToUpper();

                if (string.IsNullOrEmpty(str))
                {
                    Console.WriteLine("String cannot be empty");
                }
            }

            char[] arr = str.ToCharArray();
            string s = "aeiouAEIOU";
            Console.Write("Vowels in the input ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (s.Contains(arr[i]))
                {
                    Console.Write(arr[i] + " ");
                }

            }
            Console.WriteLine("\nHit enter to try again");
            Console.ReadKey(); 
            goto label1;
        }
        }

        
    

    }

 