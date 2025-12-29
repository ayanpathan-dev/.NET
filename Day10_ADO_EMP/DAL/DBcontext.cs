using Day10_ADO_EMP.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day10_ADO_EMP.DAL
{
    internal class DBcontext
    {
        static string strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Dac48;Integrated Security=True";
        SqlConnection con = new SqlConnection(strcon);
        public List<Emp> GetEmpRecord()
        {
            string str = "select * from Emp";
            SqlCommand cmd = new SqlCommand(str, con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            List<Emp> allemprecords = new List<Emp>();

            while (dr.Read())
            {
                allemprecords.Add(new Emp()
                {
                    Eid = Convert.ToInt32(dr["empid"]),
                    EName = dr["ename"].ToString(),
                    EAddress = dr["eaddress"].ToString()
                });

            }
            con.Close();
            return allemprecords;
        }



        public List<Emp> GetById(int empid)
        {
            string qry = ($"Select * from emp where empid={empid}");
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<Emp> list = new List<Emp>();
                while (dr.Read())
                {
                    list.Add(new Emp()
                    {
                        Eid = Convert.ToInt32(dr["empid"]),
                        EName = dr["Ename"].ToString(),
                        EAddress = dr["ename"].ToString(),
                    });
                }
                con.Close();
            return list;
        }
    }
}
