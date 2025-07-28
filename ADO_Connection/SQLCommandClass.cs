using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO_Connection
{
    class SQLCommandCLass
    {
        static void Main(string[] args)
        {
            new SQLCommandCLass().RetriveTable();
            new SQLCommandCLass().Selectrows();
            Console.ReadKey();

            /*  new SQLCommandCLass().manipulation();
              Console.ReadKey(); */

        /*    new SQLCommandCLass().delete();
            Console.ReadKey(); */
        }
        public void RetriveTable()
        {
           string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            Console.WriteLine("Connection: " + constr);
            SqlConnection con = new SqlConnection(constr);
           string selectQuery = "select * from dbo.Customer"; 

            SqlCommand sl = new SqlCommand(selectQuery, con);
            try
            {
                con.Open();
                SqlDataReader sdr = sl.ExecuteReader();
                
                while (sdr.Read())
                {
                    int id = sdr.GetInt32(0);        // Index 0: Id
                    string firstname = sdr.GetString(1);  // Index 1: Name
                    string lastname = sdr.GetString(2);
                    string city = sdr.GetString(3);  
                    string country = sdr.GetString(4);
                    string phoneno = sdr.GetString(5);

                    Console.WriteLine(id + " " + firstname + " " + lastname + " " + city + " " + country + "  " + phoneno);
                }

              

                Console.ReadLine();

            }
            catch (Exception ex)
            {
                 Console.WriteLine(ex.Message);

                Console.WriteLine("StackTrace: " + ex.StackTrace);
            }
            finally
            {
                con.Close();
            }
    }


        public void Selectrows()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand sc = new SqlCommand("select count(id) from dbo.Customer",con);

           try
            {
                con.Open();

                int totalrows = (int)sc.ExecuteScalar();
                Console.WriteLine("Total no of rows in table : " +totalrows);
                Console.ReadLine();
          }
           catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
           }
            finally
            {
                con.Close();
           }
            Console.ReadKey();
        }


        public void manipulation()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand sc = new SqlCommand("insert into dbo.Customer values('Kaushal','Amaral','Indore','India','99028983028')", con);

            try
            {
                con.Open();

                int rowsadded = sc.ExecuteNonQuery();
                Console.WriteLine(rowsadded);

                sc.CommandText = "update dbo.Customer set LastName = 'Patil' where id = 2";
                rowsadded = sc.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            Console.ReadLine();
        }

        public void delete()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand sc = new SqlCommand("Delete from dbo.Customer where id = 24",con);

            try
            {
                con.Open();
                int rowsdeleted = sc.ExecuteNonQuery();
                Console.WriteLine(rowsdeleted);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            Console.ReadLine();
        }



}
    } 
