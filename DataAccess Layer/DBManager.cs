using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer
{
    public class DBManager
    {
        static string conString = @"Data source=DESKTOP-VBKRVAQ;initial catalog=icecreamProject;integrated security=true;";
        public int IUD(String query)
        {
            SqlConnection con=new SqlConnection(conString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand(query, con);
            int r=cmd.ExecuteNonQuery();
            return r;
        }
        public DataTable Fetch(String query)
        {
            SqlConnection con = new SqlConnection(conString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            sdr.Close();
            con.Close();
            return dt;
        }
       
    }
}
