using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter First Number");
                int i = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second Number");
                int j = Convert.ToInt32(Console.ReadLine());


                int result = i / j;
                Console.WriteLine($"The Result odf the following Operation is : {result}");
                Console.ReadLine();
            }
            catch(DivideByZeroException exp)
            {
                Console.WriteLine(" Error Occcured Cannot Divide By Zero");
                Console.WriteLine(exp.StackTrace);
            } 
            catch (Exception e)
            {
                Console.WriteLine("All Exception are catched");
                Console.WriteLine($"Message: {e.Message}");  // Gives Custom Message
                Console.WriteLine($"Source: {e.Source}"); // The name of the application or the object that causes the error
                Console.WriteLine($"HelpLink: {e.HelpLink}"); // A link to external help documentation.
                Console.WriteLine($"StackTrace: {e.StackTrace}"); //which line gives error
                Console.WriteLine($"TargetSite: {e.TargetSite}"); // Shows the method where the exception was thrown
                Console.WriteLine($"Data: {e.Data}"); // A dictionary that stores custom key/value data about the error.
                Console.WriteLine($"HRresult: {e.HResult}"); // A system-specific numeric code representing the error.
            }
            finally
            {
                Console.WriteLine("Finally Executed");
            }
            Console.ReadLine();
        }
        }
    }
