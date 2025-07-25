using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            A[0] = 1;
            A[1] = 2;
            A[2] = 3;
            A[3] = 4;
            A[4] = 5;
            foreach(int arr in A)
            {
                Console.WriteLine(arr);
            }
            Console.WriteLine("________________________________");
            Console.WriteLine("Methods of Array");



            Console.WriteLine(A.Contains(5));
            Console.ReadLine();
        }
    }
}
