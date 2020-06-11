using System;
using System.Data.SqlClient;

namespace Proiect_MPP_CSharp.Repos
{
    public class DatabaseUtils
    {
        public DatabaseUtils() { }

        private SqlConnection connection = null;

        private SqlConnection getNewConnection() {
            string url = @"jdbc:sqlite:C:\Users\ripan\Desktop\Proiect MPP CSharp\BazaDeDate";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(url);
            }
            catch (SqlException e) {
                Console.WriteLine("Error getting connection: " + e.Message);
            }
            return conn;
        }

        public static SqlConnection connect()
        {
            string url = "Server=localhost\\MSSQLSERVER01;Database=DBExcursii;Integrated Security=true";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(url);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return connection;
        }
    }
}
