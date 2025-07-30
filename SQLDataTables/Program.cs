using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SQLDataTables
{
    class Program
    {
        static void Main(string[] args)
        {
           new Program().insertmultiple();
           // new Program().updateName();
            Console.ReadKey();
        }

        public void insertmultiple() // Inserts multiple student records using DataTable
        {
            try
            {
                string cons = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(cons);
                DataTable dt = new DataTable("Student Table");
                dt.Columns.Add("RollNo", typeof(int));
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("marks", typeof(int));
                for (int i = 0; i <1; i++) 
                {
                    Console.Write("Enter Roll No: ");
                    int roll = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Marks: ");
                    int marks = Convert.ToInt32(Console.ReadLine());

                    dt.Rows.Add(roll, name, marks);
                }
                SqlDataAdapter sd = new SqlDataAdapter();
                sd.InsertCommand = new SqlCommand("Insertdata", con);
                sd.InsertCommand.CommandType = CommandType.StoredProcedure;

                sd.InsertCommand.Parameters.Add("@RollNo", SqlDbType.Int, 0, "RollNo");
                sd.InsertCommand.Parameters.Add("@Name", SqlDbType.VarChar, 20, "Name");
                sd.InsertCommand.Parameters.Add("@marks", SqlDbType.Int, 0, "marks");

                sd.InsertCommand.UpdatedRowSource = UpdateRowSource.None;
                sd.UpdateBatchSize = dt.Rows.Count;
                sd.Update(dt);

                Console.WriteLine("Using Data Table");
                Console.WriteLine("____________________");
                Console.WriteLine(dt.TableName);
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine($"{row[0]}, {row[1]}, {row[2]}");
                }
                Console.WriteLine("_____________________________________________________________");
                Console.WriteLine("All records inserted successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Duplicate RollNo is not allowed please enter New RollNo");
            }
        }

        public void updateName()
        {
            string cons = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(cons);
            DataTable dt = new DataTable(" Update Student Table");
            SqlDataAdapter sd = new SqlDataAdapter("SELECT RollNo, Name, marks FROM Student", con);
            sd.Fill(dt);
            Console.WriteLine("Enter the Name you want to update");
            string inputName = Console.ReadLine();
            if (dt.Rows.Count > 0)
            {
                dt.Rows[7]["Name"] = inputName;
            }
            sd.UpdateCommand = new SqlCommand("UPDATE Student SET Name = @Name WHERE RollNo = @RollNo", con);
            sd.UpdateCommand.Parameters.Add("@Name", SqlDbType.VarChar, 100, "Name");
            sd.UpdateCommand.Parameters.Add("@RollNo", SqlDbType.Int, 0, "RollNo");
            con.Open();
            int rowsaffected = sd.Update(dt);
            con.Close();

            Console.WriteLine("Updated data: " + rowsaffected);
            Console.WriteLine("Successfully Updated the Data");
        }



    }
}
