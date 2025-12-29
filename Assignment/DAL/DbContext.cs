using Assignment.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.DAL
{
    internal class DbContext
    {
        string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Dac48;Integrated Security=True";

        public int checkUser(User userCheck)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);

            string findUser = $"SELECT * FROM [User] WHERE Username='{userCheck.UserName}' AND PasswordHash='{userCheck.Password}'";


            SqlCommand cmd = new SqlCommand(findUser, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                conn.Close();
                return 1;
            }

            conn.Close();
            return 0;
        }

        public int InsertUser(User insertUser)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            string insertQuery = $"INSERT INTO [User] (Name, Username, PasswordHash) VALUES ('{insertUser.Name}','{insertUser.UserName}','{insertUser.Password}')";
            SqlCommand cmd = new SqlCommand(insertQuery, con);

            con.Open();
            int rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;
        }

        public int UpdateUser(User updateUser)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            string updateQuery = $"Update [User]  SET PasswordHash='{updateUser.Password}' where Username='{updateUser.UserName}'";
            SqlCommand cmd = new SqlCommand(updateQuery, con);

            con.Open();
            int rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;
        }
    }
}