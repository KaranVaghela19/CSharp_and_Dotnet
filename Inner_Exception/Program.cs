using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inner_Exception
{
    class Program
    {

        static void Main(string[] args)
        {

            try
            {
                ReadFile("Karan.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Outer Exception: " + ex.Message);

                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                }
            }
            Console.ReadLine();
        }
        static void ReadFile(string fileName)
        {
            try
            {
                string content = File.ReadAllText(fileName);
                Console.WriteLine("File content: " + content);
            }
            catch (Exception fileEx)
            {
                throw new Exception("Could not read the file.", fileEx);
            }
        }
    }
}
