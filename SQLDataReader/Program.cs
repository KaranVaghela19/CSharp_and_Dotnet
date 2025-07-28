using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace SQLDataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Selectstmnt();

            new Program().multipleselectstmnt();
            Console.ReadKey();
        }

        public void Selectstmnt()
        {
            string constr = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand sc = new SqlCommand("select id, FirstName, LastName, City from dbo.Customer", con);

            try
            {
                con.Open();
                SqlDataReader sdr = sc.ExecuteReader();

                if (sdr.HasRows)
                {
                    Console.WriteLine("Customer Details : ");
                    while (sdr.Read())
                    {
                        Console.WriteLine(sdr["FirstName"] + " " + sdr["LastName"] + " " + sdr["City"]);
                    }
                }
                else
                {
                    Console.WriteLine("It consist no rows");

                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
            Console.ReadLine();
        }

        public void multipleselectstmnt()
        {
            string cons = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
            SqlConnection sq = new SqlConnection(cons);
            SqlCommand sc = new SqlCommand("select * from dbo.Customer;select * from dbo.Orders;", sq);

            try
            {
                sq.Open();
                SqlDataReader reader = sc.ExecuteReader();

                Console.WriteLine("Customers : ");
                while (reader.Read())
                {
                    Console.WriteLine(reader["Id"] + " " + reader["FirstName"] + " " + reader["LastName"] + " " + reader["City"] + " " + reader["Country"] + " " + reader["Phone"]);

                }
                if (reader.NextResult())
                {
                    Console.WriteLine("\nOrders : ");

                    while (reader.Read())
                    {
                        Console.WriteLine(reader["Id"] + " " + reader["OrderDate"] + " " + reader["OrderNumber"] + " " + reader["CustomerId"] + " " + reader["TotalAmount"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sq.Close();
            }

        }

    }
}
