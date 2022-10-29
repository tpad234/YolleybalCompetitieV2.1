
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Core;
namespace Data
{
    class DalAlgemeen
    {
        static readonly SqlConnection _conn = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=VolleydatabaseS2;User Id=;Password=;");

        public static DataTable Select(string query, List<SqlParameter> parameters = null)
        {
            DataTable result = new DataTable();

            OpenSqlConnection();

            if (_conn.State == ConnectionState.Open)
            {
                SqlCommand mySqlCommand = new SqlCommand(query, _conn);

                try
                {
                    SqlDataReader SqlDataReader = mySqlCommand.ExecuteReader();
                    result.Load(SqlDataReader);
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} Exception caught.", e);
                }
                finally
                {
                    CloseSqlConnection();
                }


            }
            return result;
        }
        private static int UpdateDeleteInsert(string query, List<SqlParameter> parameters = null)
        {
            int rowsAffected = 0;
            OpenSqlConnection();

            if (_conn.State == ConnectionState.Open)
            {
                SqlCommand mySqlCommand = new SqlCommand(query, _conn);

                if (parameters != null)
                {
                    mySqlCommand.Parameters.AddRange(parameters.ToArray());
                }
                try
                {
                    rowsAffected = mySqlCommand.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    Console.WriteLine("Error connecti ng to the database. Contact it support.", "Database error 1234");
                }
                finally
                {
                    CloseSqlConnection();
                }
            }
            return rowsAffected;
        }
        public static void OpenSqlConnection()
        {



            _conn.Open();

            Console.WriteLine("State: {0}", _conn.State);
            Console.WriteLine("ConnectionString: {0}", _conn.ConnectionString);

        }
        public static void CloseSqlConnection()
        {


            _conn.Close();
            Console.WriteLine("State: {0}", _conn.State);
            Console.WriteLine("ConnectionString: {0}", _conn.ConnectionString);

        }
    }
}
