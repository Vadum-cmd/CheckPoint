using System;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Connection
{

    class Program
    {
        static void Main()
        {
            string theConnectionString = ConfigurationManager.ConnectionStrings["MainConnection"].ToString();
            MySqlConnection connection = new MySqlConnection(theConnectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Connected to database.");

                // Perform your database operations here

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
