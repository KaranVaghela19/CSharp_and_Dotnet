using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "Karan", age = 18 },
            new Student() { StudentID = 2, StudentName = "Mayur",  age = 21 },
            new Student() { StudentID = 3, StudentName = "Nayan",  age = 18 },
            new Student() { StudentID = 4, StudentName = "Ram" , age = 20  },
            new Student() { StudentID = 5, StudentName = "Stephen" , age = 21 }
        };

            var students = from s in studentList
                           select new { Id = s.StudentID, Name = s.StudentName ,};

            foreach (var stud in students)
                Console.WriteLine(stud.Id + " - " + stud.Name );
                Console.ReadLine();
        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int age { get; set; }
    }

}
