
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Core;

namespace Data
{
    public class CompetitieDal : ICompetitiecollectieDal
    {
        static readonly SqlConnection _conn = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=VolleydatabaseS2;User Id=;Password=;");

        private static DataTable Select(string query)
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

        public DataTable GetCompetities()
        {
            return Select("SELECT * FROM Competitie;");
        }
    }
}