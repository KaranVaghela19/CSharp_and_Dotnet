using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Generic_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            // Add key-value pairs using Add()
            students.Add(1, "Alice");
            students.Add(2, "Bob");
            students.Add(3, "Charlie");

            // Access items using indexer
            Console.WriteLine("Student with ID 2: " + students[2]);

            // Check if a key exists using ContainsKey()
            if (students.ContainsKey(4))
                Console.WriteLine("Student with ID 4 exists.");
            else
                Console.WriteLine("Student with ID 4 does not exist.");

            // Check if a value exists using ContainsValue()
            if (students.ContainsValue("Alice"))
                Console.WriteLine("Alice is in the dictionary.");

            // Update a value
            students[2] = "Bobby";

            // Remove an entry using Remove()
            students.Remove(1);

            // Get count using Count property
            Console.WriteLine("Total students: " + students.Count);

            // Iterate using foreach
            Console.WriteLine("All students:");
            foreach (KeyValuePair<int, string> entry in students)
            {
                Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
            }

            // TryGetValue() to safely get a value
            if (students.TryGetValue(3, out string name))
                Console.WriteLine($"ID 3 belongs to {name}");
            Console.ReadLine();
        }
    }
}
