using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SQLDataAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().datable();
            new Program().dataset();
            new Program().sp(1);
            Console.ReadKey();
        }

        public void datable() // Represents a single in-memory table
        {
            string cons = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(cons);
            SqlDataAdapter sd = new SqlDataAdapter("select * from dbo.Customer", con);

            DataTable dt = new DataTable("Customer Table");
            sd.Fill(dt);
            Console.WriteLine("Using Data Table");
            Console.WriteLine("____________________");
            Console.WriteLine(dt.TableName);
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"{row[0]}, {row[1]}, {row[2]}, {row[3]}, {row[4]}, {row[5]}");
            }
            Console.WriteLine("_____________________________________________________________");
        }

        public void dataset() // Represents a collection of tables (DataTables)
        {
            string cons = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(cons);
            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.Customer; select * from dbo.Orders", con);
            DataSet ds = new DataSet("Customers and Order");
            da.Fill(ds);
            Console.WriteLine("using DataSet");
            Console.WriteLine(ds.DataSetName);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine($"{row[0]}, {row[1]}, {row[2]}, {row[3]}, {row[4]}, {row[5]}");
            }

            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("OrdersTable :");

            foreach (DataRow row in ds.Tables[1].Rows)
            {
                Console.WriteLine($"{row[0]}, {row[1]}, {row[2]}, {row[3]}, {row[4]}");
            }
            Console.WriteLine("______________________________________________");
        }

        public void sp(int productId)
        {
            string cons = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(cons);
            SqlDataAdapter da = new SqlDataAdapter("GetCustomerDetailsByProductID", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@ProductID", productId);

            DataTable dt = new DataTable();
            da.Fill(dt);
            Console.WriteLine("Using StoredProcedure");

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"{row[0]}, {row[1]}, {row[2]}, {row[3]}, {row[4]}, {row[5]}");
            }
        }
    }
}
