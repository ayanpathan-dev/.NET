using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;
using System.Net;

namespace Day9_ConnectedAdoNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ConnctionString  = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Dac48;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConnctionString);

            #region
            //String SelectQuery = "select * from emp";

            //SqlCommand cmd = new SqlCommand(SelectQuery, conn);
            //cmd.CommandType =System.Data.CommandType.Text;
            //cmd.CommandText = SelectQuery;
            //cmd.Connection = conn;
            //conn.Open();

            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    int ID= Convert.ToInt32(reader[0]);
            //    //string? Name = reader[1].ToString();
            //    //string? Address = reader[2].ToString();
            //    string? Name = reader["Ename"].ToString();
            //    string? Address = reader["EAddress"].ToString();
            //    Console.WriteLine($"Id:{ID}, Name: {Name}, Address: {Address}");
            //}
            //conn.Close();
            #endregion

            Console.WriteLine("Enter a name");
            String nm = Console.ReadLine();
            Console.WriteLine("Enter a address");
            String addr=Console.ReadLine();
            string insertquery = $"insert into emp(Ename,EAddress) values('{nm}','{addr}')";

            SqlCommand cmd = new SqlCommand(insertquery, conn);
            cmd.CommandType =System.Data.CommandType.Text;
            cmd.CommandText = insertquery;
            cmd.Connection = conn;
            conn.Open();

            int noOfRowsAffected = cmd.ExecuteNonQuery();
            if (noOfRowsAffected > 0)
            {
                Console.WriteLine("Record inserted successfully!!");
            }
            else
            {
                Console.WriteLine("Error");
            }

            conn.Close();



        }
    }
}
