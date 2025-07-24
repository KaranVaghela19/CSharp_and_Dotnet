using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBy_Refrence_and_Value
{
    class CallbyRef_Value
    {
        static void Main(string[] args)
        {

            Employee Emp1 = new Employee(); // call by value with refrence
            Emp1.Employee_Id = 1001;
            Emp1.Employee_Name = "Karan";

            Employee Emp2 = Emp1;
            Emp1.Employee_Name = "Smith";
            Console.WriteLine($"Emp1 Name = {Emp1.Employee_Name}");
            Console.WriteLine($"Emp2 Name = {Emp2.Employee_Name}");
            Console.ReadKey();

            Call_by_Vlaue();  //call by value
            Console.Read();

            int a = 15;   //call by refrence with value types
            UpdateValue(ref a);
            Console.WriteLine($"This is value for call by refrence with value types : {a}");
            Console.ReadKey();



            students std1 = new students(); // call by refrence with refrence
            std1.rollno = 1001;
            std1.name = "James";
            UpdateName(ref std1);
            Console.WriteLine($"Emp1 Name = {std1.name}");
            Console.ReadKey();

        }
        // call by value
        static void Call_by_Vlaue()
        {
            int i = 10;
            int j = i;
             j = 15;
            j = i;
            Console.WriteLine($"This is value for call by value : {j}");
            
        }

        //call by refrence with value types
        static void UpdateValue(ref int b)
        {
            b = 30;
        }


        // call by value with refrence
        public class Employee
        {
          public int Employee_Id;
          public string Employee_Name;
        }


        // call by refrence with refrence 
        public class students
        {
          public  int rollno;
          public string name;
        }
        public static void UpdateName(ref students std2)
        {
            std2 = null;

        }
    }
}

