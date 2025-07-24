using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Empid = 1001;
            emp.EmpName = "Karan";
            Console.WriteLine($"Id of Employee is: {emp.Empid}");
            Console.WriteLine($"Name of Employee is: {emp.EmpName}");
            Console.ReadLine();
        }
    }

    public class Employee
    {
       public int Empid { get; set; }
       public string EmpName { get; set; }

    }
}
