using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Students std = new Students();
            std.Name = "Karan";
            std.Age = 22;

            Console.WriteLine("name : " + std.Name);
            Console.WriteLine("age :  " + std.Age);
            Console.ReadLine();
        }
    }


    public class Students
    {
       
        private String studentName;
        private int studentAge;

        public String Name
        {
            get { return studentName;
            }

            set { studentName = value;
            }
        }
        public int Age
        {
            get { return studentAge; }

            set { studentAge = value; }
        }
    }
}
