using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer
{
    public class Authentication
    {
        private string connectionString = @"Data source=DESKTOP-VBKRVAQ;initial catalog = icecreamProject; integrated security = true;"; // Replace with your actual connection string

        public AdminDisplay AuthenticateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Replace "Users" with the actual name of your user table
                string query = $"SELECT * FROM admin WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a User object based on the retrieved data
                            return new AdminDisplay
                            {
                               
                                name = (string)reader["Username"],
                                password = (string)reader["Password"]
                            };
                        }
                    }
                }
            }

            // Return null if no matching user found
            return null;
        }
    }
}
