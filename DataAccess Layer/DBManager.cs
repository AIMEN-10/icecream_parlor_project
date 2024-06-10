using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer
{
    public class DBManager
    {
        static string conString = @"Data source= ;initial catalog= ;integrated security=true;";
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
        public int IUDobj(string storedProcedureName, Dictionary<string, object> parameters)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand(storedProcedureName, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                
                foreach (var param in parameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result;
                }
                catch (Exception ex)
                {
                    // Log or handle the exception as needed
                    //MessageBox.Show("Error: " + ex.Message);
                    return -1;
                }
            }
        }
        public DataTable Fetchobj(String procedureName, Dictionary<string, object> parameters)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(procedureName, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    //SqlParameter outputParam = new SqlParameter("@Password", SqlDbType.NVarChar, 50)
                    //{
                    //    Direction = ParameterDirection.Output
                    //};
                    //cmd.Parameters.Add(outputParam);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(sdr);
                        return dt;
                    }
                }
            }
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
